using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.BLL.Abstract;
using YapGetirCom.DAL.Repositories.Abstract;
using YapGetirCom.Model;

namespace YapGetirCom.BLL.Concrete
{
    public class StockService : IStockService
    {
        public IStockRepository _stockRepository;
        public StockService(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }
        public void Insert(Stock entity)
        {
            _stockRepository.Add(entity);
        }

        public void Delete(Stock entity)
        {
            _stockRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _stockRepository.Delete(Get(id));
        }

        public void Update(Stock entity)
        {
            _stockRepository.Update(entity);
        }

        public Stock Get(int entityID)
        {
            return _stockRepository.Get(x => x.StockID == entityID);
        }

        public ICollection<Stock> GetAll()
        {
            return _stockRepository.GetAll();
        }
    }
}
