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
            throw new NotImplementedException();
        }

        public void Delete(Stock entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Stock entity)
        {
            throw new NotImplementedException();
        }

        public Stock Get(int entityID)
        {
            throw new NotImplementedException();
        }

        public ICollection<Stock> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
