using System;

namespace beauty_shop.Model
{
    internal class ImportInvoice
    {
        public int ImportInvoiceID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime ImportDate { get; set; }
        public int SupplierID { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
