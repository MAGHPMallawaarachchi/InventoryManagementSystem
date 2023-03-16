using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.DataModels
{
    internal class Item
    {
        public ObjectId Id { get; set; }
        public string? part_number { get; set; }
        public string? oem_number { get; set; }
        public string? description { get; set; }
        public string? category { get; set; }
        public string? brand { get; set; }
        public string? vehicle_brand { get; set; }
        public decimal? buying_price { get; set; }
        public decimal? unit_price { get; set; }
        public int? quantity { get; set; }
        public int? quantity_sold { get; set; }

        public int? quantity_in_hand { get; set; }
        public string? supplier { get; set; }

    }
}
