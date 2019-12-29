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
    public class CookService : ICookService
    {
        public ICookRepository _cookRepository;
        public CookService(ICookRepository cookRepository)
        {
            _cookRepository = cookRepository;
        }
        public void Insert(Cook entity)
        {
            _cookRepository.Add(entity);
        }

        public void Delete(Cook entity)
        {
            _cookRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _cookRepository.Delete(Get(id));
        }

        public void Update(Cook entity)
        {
            _cookRepository.Update(entity);
        }

        public Cook Get(int entityID)
        {
           return _cookRepository.Get(x=>x.CookID==entityID);
        }

        public ICollection<Cook> GetAll()
        {
            return _cookRepository.GetAll();
        }
    }
}
