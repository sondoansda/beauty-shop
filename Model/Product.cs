namespace beauty_shop.Model
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? TypeID { get; set; }
        public int? UnitID { get; set; }
        public int? ManufacturerID { get; set; }
        public int? MaterialID { get; set; }
        public int? UsageID { get; set; }
        public int? SeasonID { get; set; }
        public int? ColorID { get; set; }
        public int? CountryID { get; set; }
        public int? Quantity { get; set; }
        public decimal? ImportPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public string WarrantyPeriod { get; set; }
        public string Image { get; set; }
        public string Note { get; set; }
    }
}
