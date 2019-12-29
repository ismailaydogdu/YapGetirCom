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
    public class ProductOrderService : IProductOrderService
    {
        public IProductOrderRepository _productOrderRepository;
        public ProductOrderService(IProductOrderRepository productOrderRepository)
        {
            _productOrderRepository = productOrderRepository;
        }
        public void Insert(ProductOrder entity)
        {
            _productOrderRepository.Add(entity);
        }

        public void Delete(ProductOrder entity)
        {
            _productOrderRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _productOrderRepository.Delete(Get(id));
        }

        public void Update(ProductOrder entity)
        {
            _productOrderRepository.Update(entity);
        }

        public ProductOrder Get(int entityID)
        {
            return _productOrderRepository.Get(x => x.ProductOrderID == entityID);
        }

        public ICollection<ProductOrder> GetAll()
        {
            return _productOrderRepository.GetAll();
        }
    }
}
