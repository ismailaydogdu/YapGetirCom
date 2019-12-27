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
        public IProductOrderDetailRepository _ProductOrderDetailRepository;
        public ProductOrderDetailService(IProductOrderDetailRepository productOrderDetailRepository)
        {
            _ProductOrderDetailRepository = productOrderDetailRepository;
        }
        public void Insert(ProductOrderDetail entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductOrderDetail entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductOrderDetail entity)
        {
            throw new NotImplementedException();
        }

        public ProductOrderDetail Get(int entityID)
        {
            throw new NotImplementedException();
        }

        public ICollection<ProductOrderDetail> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
