using InventoryManagementSystem.DataModels;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System.Collections;

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

        public async Task<bool> InsertDocumentAsync(string collectionName, BsonDocument document)
        {
            try
            {
                var collection = GetCollection<BsonDocument>(collectionName);
                await collection.InsertOneAsync(document);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to insert document: {ex}");
                return false;
            }
        }

        //insert a document to a collection
        public async Task Insert<T>(string collectionName, T document)
        {
            var collection = GetCollection<T>(collectionName);
            await collection.InsertOneAsync(document);
        }



        //READ

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

        public async Task<List<Item>> GetFilteredItems(FilterDefinition<Item> filter)
        {
            var collection = GetCollection<Item>("items");
            var result = await collection.Find(filter).ToListAsync();
            return result;
        }


        public async Task<List<Item>> GetLowQuantityItems()
        {
            var items = await GetAllItems();
            var filteredItems = items.Where(i => i.quantity_in_hand <= 20 && i.quantity_in_hand != 0)
                                     .OrderBy(i => i.quantity_in_hand)
                                     .ToList();
            return filteredItems;
        }

        public async Task<List<Item>> GetOutOfStockItems()
        {
            var items = await GetAllItems();
            var filteredItems = items.Where(i => i.quantity_in_hand == 0)
                                     .ToList();
            return filteredItems;
        }

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

        public async Task<List<string>> GetUniqueField(string field, FilterDefinition<BsonDocument> filter)
        {
            var collection = _database.GetCollection<BsonDocument>("items");
            var distinctResults = await collection.DistinctAsync<string>(field, filter);
            var sortedResults = distinctResults.ToList().OrderBy(x => x).ToList();
            return sortedResults;
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

        //get items by filters
        public async Task<List<Item>> GetItemsByFilter(FilterDefinition<Item> filter)
        {
            var collection = _database.GetCollection<Item>("items");
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

        //get all invoices
        public async Task<List<Invoice>> GetAllInvoices()
        {
            var collection = GetCollection<Invoice>("invoices");
            var filter = Builders<Invoice>.Filter.Empty;
            var invoices = await collection.Find(filter).ToListAsync();
            return invoices;
        }

        public async Task<List<Invoice>> GetInvoices(FilterDefinition<Invoice> filter)
        {
            var collection = GetCollection<Invoice>("invoices");
            var invoices = await collection.Find(filter).ToListAsync();
            return invoices;
        }

        public async Task<List<InvoiceItem>> GetInvoiceItems(int sequence)
        {
            var collection = GetCollection<Invoice>("invoices");
            var filter = Builders<Invoice>.Filter.Eq("sequence", sequence);
            var invoice = await collection.Find(filter).FirstOrDefaultAsync();
            if (invoice == null)
            {
                throw new ArgumentException("Invalid invoice ID");
            }
            return invoice.items!;
        }


        //UPDATE

        public async Task<bool> UpdateDocumentAsync(string collectionName, FilterDefinition<BsonDocument> filter, BsonDocument update)
        {

            var collection = GetCollection<BsonDocument>(collectionName);
            var result = await collection.UpdateOneAsync(filter, new BsonDocument("$set", update));
            return result.ModifiedCount > 0;
        }

        //UpdateCustomers
        public bool UpdateCustomer(string collectionName, string customerId, string name, string address, string city, string phoneNo)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("customer_id", customerId);

            var updateCustomer = Builders<BsonDocument>.Update
                .Set("customer_id", customerId)
                .Set("name", name)
                .Set("address", address)
                .Set("city", city)
                .Set("phone_no", phoneNo);

            var updateResult = _database.GetCollection<BsonDocument>(collectionName)
                                        .UpdateOne(filter, updateCustomer);

            return updateResult.ModifiedCount > 0;
        }

        //update status field of invoice
        public void UpdateStatus(string invoice_no, string status)
        {
            var collection = GetCollection<BsonDocument>("invoices");
            var filter = Builders<BsonDocument>.Filter.Eq("invoice_no", invoice_no);
            var update = Builders<BsonDocument>.Update.Set("status", status);

            collection.UpdateOne(filter, update);
        }

        //DELETE

        //delete an item
        public async Task<bool> DeleteItem(string part_number)
        {
            var collection = GetCollection<Item>("items");
            var filter = Builders<Item>.Filter.Eq(item => item.part_number, part_number);
            var result = await collection.DeleteOneAsync(filter);
            return result.DeletedCount > 0;
        }

        //delete a customer
        public async Task<bool> DeleteCustomer(string customer_id)
        {
            var collection = GetCollection<Customer>("customers");
            var filter = Builders<Customer>.Filter.Eq(customer => customer.customer_id, customer_id);
            var result = await collection.DeleteOneAsync(filter);
            return result.DeletedCount > 0;
        }
    }
}
