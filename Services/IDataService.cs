using SaleItemData.Models;

namespace SaleItemData.Services
{
    public interface IDataService
    {
        List<SaleItem> ReadDaraFromCSV();
    }
}
