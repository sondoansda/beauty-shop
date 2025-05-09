namespace beauty_shop.Model
{
    internal class ImportInvoiceDetail
    {
        public int ImportInvoiceID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
    }
}
