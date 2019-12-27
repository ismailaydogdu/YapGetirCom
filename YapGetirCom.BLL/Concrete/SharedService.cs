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
    public class SharedService : ISharedService
    {
        public ISharedRepository _sharedRepository;
        public SharedService(ISharedRepository sharedRepository)
        {
            _sharedRepository = sharedRepository;
        }
        public void Insert(Shared entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Shared entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Shared entity)
        {
            throw new NotImplementedException();
        }

        public Shared Get(int entityID)
        {
            throw new NotImplementedException();
        }

        public ICollection<Shared> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
