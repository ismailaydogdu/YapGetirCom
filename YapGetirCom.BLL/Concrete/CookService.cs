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
            throw new NotImplementedException();
        }

        public void Delete(Cook entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Cook entity)
        {
            throw new NotImplementedException();
        }

        public Cook Get(int entityID)
        {
            throw new NotImplementedException();
        }

        public ICollection<Cook> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
