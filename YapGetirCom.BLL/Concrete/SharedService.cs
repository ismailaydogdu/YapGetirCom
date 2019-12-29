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
            _sharedRepository.Add(entity);
        }

        public void Delete(Shared entity)
        {
            _sharedRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _sharedRepository.Delete(Get(id));
        }

        public void Update(Shared entity)
        {
            _sharedRepository.Update(entity);
        }

        public Shared Get(int entityID)
        {
            return _sharedRepository.Get(x => x.SharedID == entityID);
        }

        public ICollection<Shared> GetAll()
        {
            return _sharedRepository.GetAll();
        }
    }
}
