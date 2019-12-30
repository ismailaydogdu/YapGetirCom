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
    public class UnitAndProductService : IUnitAndProductService
    {
        private IUnitAndProductRepository _UnitAndProductRepository;
        public UnitAndProductService(IUnitAndProductRepository measurementAndMaterialRepository)
        {
            _UnitAndProductRepository = measurementAndMaterialRepository;
        }
        public void Insert(UnitAndProduct entity)
        {
            _UnitAndProductRepository.Add(entity);
        }

        public void Delete(UnitAndProduct entity)
        {
            _UnitAndProductRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _UnitAndProductRepository.Delete(Get(id));
        }

        public void Update(UnitAndProduct entity)
        {
            _UnitAndProductRepository.Update(entity);
        }

        public UnitAndProduct Get(int entityID)
        {
            return _UnitAndProductRepository.Get(x => x.UnitAndProductID == entityID);
        }

        public ICollection<UnitAndProduct> GetAll()
        {
            return _UnitAndProductRepository.GetAll();
        }
    }
}
