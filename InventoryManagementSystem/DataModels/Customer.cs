using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.DataModels
{
    internal class Customer
    {
        public ObjectId Id { get; set; }
        public string? customer_id { get; set; }
        public string? name { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public string? phone_no { get; set; }
    }
}
