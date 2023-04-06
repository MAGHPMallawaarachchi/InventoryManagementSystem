using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.DataModels
{
    internal class Admin
    {
        public ObjectId Id { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
    }
}
