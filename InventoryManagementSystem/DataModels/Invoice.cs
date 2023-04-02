using MongoDB.Bson;

namespace InventoryManagementSystem.DataModels
{
    internal class Invoice
    {
        public ObjectId Id { get; set; }
        public string? prefix { get; set; }
        public int? sequence { get; set; }
        public string? invoice_no { get; set; }
        public DateTime date { get; set; }
        public string? time { get; set; }
        public string? customer_id { get; set; }
        public List<InvoiceItem>? items { get; set; }
        public decimal total_profit { get; set; }
        public decimal total_cost { get; set; }
        public decimal total_revenue { get; set; }
        public string? status { get; set; }
    }

    internal class InvoiceItem
    {
        public string? part_number { get; set; }
        public int quantity { get; set; }
        public decimal revenue { get; set; }
        public decimal cost { get; set; }
        public decimal profit { get; set; }
    }
}
