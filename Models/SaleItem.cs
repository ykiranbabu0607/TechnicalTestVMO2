using CsvHelper.Configuration;

namespace SaleItemData.Models
{
    public class SaleItem
    {
        public string Segment { get; set; }
        public string Country { get; set; }
        public string Product { get; set; }
        public string DiscountBand { get; set; }
        public string UnitsSold { get; set; }
        public string ManufactoringPrice { get; set; }
        public string SalePrice { get; set; }
        public string Date { get; set; }
    }

    public sealed class SaleItemMap : ClassMap<SaleItem>
    {
        public SaleItemMap()
        {
            Map(m => m.Segment).Name("Segment");
            Map(m => m.Country).Name("Country");
            Map(m => m.Product).Name(" Product ");
            Map(m => m.DiscountBand).Name(" Discount Band ");
            Map(m => m.UnitsSold).Name("Units Sold");
            Map(m => m.ManufactoringPrice).Name("Manufacturing Price");
            Map(m => m.SalePrice).Name("Sale Price");
            Map(m => m.Date).Name("Date");
        }
    }
}
