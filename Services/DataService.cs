using CsvHelper;
using CsvHelper.Configuration;
using SaleItemData.Models;
using System.Formats.Asn1;
using System.Globalization;

namespace SaleItemData.Services
{
    public class DataService : IDataService
    {
        private readonly IWebHostEnvironment _env;

        public DataService(IWebHostEnvironment env)
        {
            _env = env;
        }
        public List<SaleItem> ReadDaraFromCSV()
        {
            List<SaleItem> saleItemList;
            string dataFilePath = Path.Combine(_env.ContentRootPath, @"Data\Data.csv");

            if (File.Exists(dataFilePath))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true // Ignore the header row
                };

                using var sr = new StreamReader(dataFilePath);
                using var csv = new CsvReader(sr, config);
                csv.Context.RegisterClassMap<SaleItemMap>();
                saleItemList = csv.GetRecords<SaleItem>().ToList();
            }
            else
                saleItemList = new List<SaleItem>();
            return saleItemList;
        }
    }
}
