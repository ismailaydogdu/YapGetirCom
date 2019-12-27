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
            throw new NotImplementedException();
        }

        public void Delete(Supplier entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Supplier entity)
        {
            throw new NotImplementedException();
        }

        public Supplier Get(int entityID)
        {
            throw new NotImplementedException();
        }

        public ICollection<Supplier> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
