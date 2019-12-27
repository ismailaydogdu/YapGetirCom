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
    public class MaterialService : IMaterialService
    {
        public IMaterialRepository _materialRepository;  
        public MaterialService(IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository;
        }
        public void Insert(Material entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Material entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Material entity)
        {
            throw new NotImplementedException();
        }

        public Material Get(int entityID)
        {
            throw new NotImplementedException();
        }

        public ICollection<Material> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
