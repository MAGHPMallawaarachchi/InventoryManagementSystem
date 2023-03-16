using InventoryManagementSystem.DataModels;
using MongoDB.Bson;
using MongoDB.Driver;

namespace InventoryManagementSystem
{
    internal class MongoConnector
    {
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;

        public MongoConnector(string connectionString, string databaseName)
        {
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(databaseName);
        }

        //get the collection
        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }


        //CREATE

        //insert a document to a collection
        public async Task Insert<T>(string collectionName, T document)
        {
            var collection = GetCollection<T>(collectionName);
            await collection.InsertOneAsync(document);
        }



        //READ

        //get item by part_number
        public async Task<Item> GetByPartNumber(string partNumber)
        {
            var collection = GetCollection<Item>("items");
            var filter = Builders<Item>.Filter.Eq("part_number", partNumber);
            return await collection.Find(filter).FirstOrDefaultAsync();
        }

        //get customer by customer_id
        public async Task<Customer> GetByCustomerID(string customerID)
        {
            var collection = GetCollection<Customer>("customers");
            var filter = Builders<Customer>.Filter.Eq("customer_id", customerID);
            return await collection.Find(filter).FirstOrDefaultAsync();
        }

        //get unique brands
        public async Task<List<string>> GetUniqueBrands()
        {
            var collection = _database.GetCollection<BsonDocument>("items");
            var distinctResults = await collection.DistinctAsync<string>("brand", "{}");
            return distinctResults.ToList();
        }

        //get unique categories
        public async Task<List<string>> GetUniqueCategories()
        {
            var collection = _database.GetCollection<BsonDocument>("items");
            var distinctResults = await collection.DistinctAsync<string>("category", "{}");
            return distinctResults.ToList();
        }       

        //get items by brand
        public async Task<List<Item>> GetItemsByBrand(string brand)
        {
            var collection = _database.GetCollection<Item>("items");
            var filter = Builders<Item>.Filter.Eq("brand", brand);
            var items = await collection.Find(filter).ToListAsync();
            return items;
        }

        //get items by category
        public async Task<List<Item>> GetItemsByCategory(string category)
        {
            var collection = _database.GetCollection<Item>("items");
            var filter = Builders<Item>.Filter.Eq("category", category);
            var items = await collection.Find(filter).ToListAsync();
            return items;
        }

        //get unique categories by brand
        public async Task<List<string>> GetUniqueCategoriesByBrand(string selectedBrand)
        {
            var collection = _database.GetCollection<BsonDocument>("items");
            var filter = Builders<BsonDocument>.Filter.Eq("brand", selectedBrand);
            var distinctResults = await collection.DistinctAsync<string>("category", filter);
            return distinctResults.ToList();
        }

        //get all items
        public async Task<List<Item>> GetAllItems()
        {
            var collection = GetCollection<Item>("items");
            var filter = Builders<Item>.Filter.Empty;
            var result = await collection.Find(filter).ToListAsync();
            return result;
        }

        //get all customers
        public async Task<List<Customer>> GetAllCustomers()
        {
            var collection = GetCollection<Customer>("customers");
            var filter = Builders<Customer>.Filter.Empty;
            var sort = Builders<Customer>.Sort.Ascending(c => c.customer_id);
            var result = await collection.Find(filter).Sort(sort).ToListAsync();
            return result;
        }

        //get the sequence of the last invoice
        public async Task<int> GetLastInvoice()
        {
            var collection = GetCollection<Invoice>("invoices");
            var filter = Builders<Invoice>.Filter.Empty;
            var sort = Builders<Invoice>.Sort.Descending(c => c.sequence);
            var projection = Builders<Invoice>.Projection.Include(c => c.sequence);
            var result = await collection.Find(filter).Sort(sort).Project(projection).FirstOrDefaultAsync();
            return result?["sequence"]?.ToInt32() ?? 0;
        }

        //fetch documents from a collection and sort by quantity_sold in descending order
        public async Task<List<Item>> GetBestSellingItems()
        {
            var collection = _database.GetCollection<Item>("items");
            var filter = Builders<Item>.Filter.Empty;
            var sort = Builders<Item>.Sort.Descending(x => x.quantity_sold);
            var documents = await collection.Find(filter).Sort(sort).ToListAsync();
            return documents;
        }


        //UPDATE
        public async Task<bool> Update<T>(string id, T item)
        {
            var filter = Builders<T>.Filter.Eq("_id", id);
            var collection = GetCollection<T>("items");
            var result = await collection.ReplaceOneAsync(filter, item);
            return result.ModifiedCount > 0;
        }

        //update one field of item
        public async Task<bool> UpdateFieldItem<T>(ObjectId objectId, string fieldName, object value)
        {
            var collection = GetCollection<T>("items");
            var filter = Builders<T>.Filter.Eq("_id", objectId);
            var update = Builders<T>.Update.Set(fieldName, value);
            var result = await collection.UpdateOneAsync(filter, update);

            return result.ModifiedCount > 0;
        }

        //update 1 or more fields of item
        public async Task<bool> UpdateItem<T>(string partNumber, Item updatedItem)
        {
            var collection = GetCollection<T>("items");
            var filter = Builders<T>.Filter.Eq("part_number", partNumber);

            var update = Builders<T>.Update
                .Set("part_number", updatedItem.part_number)
                .Set("oem_number", updatedItem.oem_number)
                .Set("description", updatedItem.description)
                .Set("brand", updatedItem.brand)
                .Set("vehicle_brand", updatedItem.vehicle_brand)
                .Set("buying_price", updatedItem.buying_price)
                .Set("unit_price", updatedItem.unit_price)
                .Set("quantity", updatedItem.quantity)
                .Set("quantity_sold", updatedItem.quantity_sold)
                .Set("supplier", updatedItem.supplier);

            var result = await collection.UpdateOneAsync(filter, update);

            return result.ModifiedCount > 0;
        }





        //delete an item
        public async Task<bool> DeleteItem<T>(string part_number)
        {
            var collection = GetCollection<T>("items");
            var objectId = new ObjectId(part_number);
            var filter = Builders<T>.Filter.Eq("part_number", objectId);
            var result = await collection.DeleteOneAsync(filter);
            return result.DeletedCount > 0;
        }

        //delete a customer
        public async Task<bool> DeleteCustomer<T>(string customer_id)
        {
            var collection = GetCollection<T>("customers");
            var objectId = new ObjectId(customer_id);
            var filter = Builders<T>.Filter.Eq("customer_id", objectId);
            var result = await collection.DeleteOneAsync(filter);
            return result.DeletedCount > 0;
        }
    }
}
