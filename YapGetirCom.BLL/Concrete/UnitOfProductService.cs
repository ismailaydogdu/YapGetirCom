using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.BLL.Abstract;
using YapGetirCom.DAL;
using YapGetirCom.DAL.Repositories.Abstract;
using YapGetirCom.Model;

namespace YapGetirCom.BLL.Concrete
{
    public class UnitOfProductService : IUnitOfProductService
    {
        private IUnitOfProductRepository _unitOfProductRepository;
        public UnitOfProductService(IUnitOfProductRepository unitOfProductRepository)
        {
            _unitOfProductRepository = unitOfProductRepository;
        }
        public void Insert(UnitOfProduct entity)
        {
            _unitOfProductRepository.Add(entity);
        }

        public void Delete(UnitOfProduct entity)
        {
            _unitOfProductRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _unitOfProductRepository.Delete(Get(id));
        }

        public void Update(UnitOfProduct entity)
        {
            _unitOfProductRepository.Update(entity);
        }

        public UnitOfProduct Get(int entityID)
        {
            return _unitOfProductRepository.Get(x => x.UnitOfProductID == entityID);
        }

        public ICollection<UnitOfProduct> GetAll()
        {
            return _unitOfProductRepository.GetAll();
        }
    }
}
