using StockControl.Entities;

namespace StockControl.Interfaces
{
    public interface IStockService
    {
        Task<StockModel> AddStockAsync(StockModel stock);
        Task<StockModel> GetStockByIdAsync(Guid id);
        Task<IEnumerable<StockModel>> GetAllStockesAsync();
        Task<StockModel> UpdateStockAsync(Guid id, StockModel stock);
        void DeleteStockAsync(Guid id);
    }
}
