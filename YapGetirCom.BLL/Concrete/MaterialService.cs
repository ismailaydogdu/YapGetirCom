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
            _materialRepository.Add(entity);
        }

        public void Delete(Material entity)
        {
            _materialRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _materialRepository.Delete(Get(id));
        }

        public void Update(Material entity)
        {
            _materialRepository.Update(entity);
        }

        public Material Get(int entityID)
        {
            return _materialRepository.Get(x => x.MaterialID == entityID);
        }

        public ICollection<Material> GetAll()
        {
            return _materialRepository.GetAll();
        }
    }
}
