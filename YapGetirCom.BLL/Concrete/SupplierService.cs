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
    public class SupplierService : ISupplierService
    {
        public ISupplierRepository _supplierRepository;
        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        public void Insert(Supplier entity)
        {
            _supplierRepository.Add(entity);
        }

        public void Delete(Supplier entity)
        {
            _supplierRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _supplierRepository.Delete(Get(id));
        }

        public void Update(Supplier entity)
        {
            _supplierRepository.Update(entity);
        }

        public Supplier Get(int entityID)
        {
            return _supplierRepository.Get(x => x.SupplierID == entityID);
        }

        public ICollection<Supplier> GetAll()
        {
            return _supplierRepository.GetAll();
        }
    }
}
