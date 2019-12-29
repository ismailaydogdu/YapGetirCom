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
    public class ProductService : IProductService
    {
        public IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Insert(Product entity)
        {
            _productRepository.Add(entity);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _productRepository.Delete(Get(id));
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }

        public Product Get(int entityID)
        {
            return _productRepository.Get(x => x.ProductID == entityID);
        }

        public ICollection<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
    }
}
