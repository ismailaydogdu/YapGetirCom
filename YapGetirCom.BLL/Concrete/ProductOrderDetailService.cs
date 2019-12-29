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
    public class ProductOrderDetailService : IProductOrderDetailService
    {
        public IProductOrderDetailRepository _productOrderDetailRepository;
        public ProductOrderDetailService(IProductOrderDetailRepository productOrderDetailRepository)
        {
            _productOrderDetailRepository = productOrderDetailRepository;
        }
        public void Insert(ProductOrderDetail entity)
        {
            _productOrderDetailRepository.Add(entity);
        }

        public void Delete(ProductOrderDetail entity)
        {
            _productOrderDetailRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _productOrderDetailRepository.Delete(Get(id));
        }

        public void Update(ProductOrderDetail entity)
        {
            _productOrderDetailRepository.Update(entity);
        }

        public ProductOrderDetail Get(int entityID)
        {
            return _productOrderDetailRepository.Get(x => x.ProductOrderDetailID == entityID);
        }

        public ICollection<ProductOrderDetail> GetAll()
        {
            return _productOrderDetailRepository.GetAll();
        }
    }
}
