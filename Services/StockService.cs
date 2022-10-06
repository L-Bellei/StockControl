using StockControl.Entities;
using StockControl.Interfaces;

namespace StockControl.Services
{
    public class StockService : IStockService
    {
        private readonly Infra.AppContext db;

        public StockService(Infra.AppContext db)
        {
            this.db = db;
        }

        public Task<StockModel> AddStockAsync(StockModel stock)
        {
            throw new NotImplementedException();
        }

        public void DeleteStockAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StockModel>> GetAllStockesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<StockModel> GetStockByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<StockModel> UpdateStockAsync(Guid id, StockModel stock)
        {
            throw new NotImplementedException();
        }
    }
}
