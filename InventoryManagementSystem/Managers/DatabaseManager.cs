using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Managers
{
    internal class DatabaseManager
    {
        public static IMongoDatabase GetDatabase()
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://techtitans:<cRYU3Kvgqi5QKP>@inventorymanagementsyst.wqyhhjd.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            return client.GetDatabase("test");
        }
    }
}
