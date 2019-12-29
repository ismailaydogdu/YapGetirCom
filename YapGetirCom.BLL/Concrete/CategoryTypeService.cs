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
    public class CategoryTypeService : ICategoryTypeService
    {
        public ICategoryTypeRepository _categoryTypeRepository;
        public CategoryTypeService(ICategoryTypeRepository categoryTypeRepository)
        {
            _categoryTypeRepository = categoryTypeRepository;
        }
        public void Insert(CategoryType entity)
        {
            _categoryTypeRepository.Add(entity);
        }

        public void Delete(CategoryType entity)
        {
            _categoryTypeRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _categoryTypeRepository.Delete(Get(id));
        }

        public void Update(CategoryType entity)
        {
            _categoryTypeRepository.Update(entity);
        }

        public CategoryType Get(int entityID)
        {
            return _categoryTypeRepository.Get(x => x.CategoryTypeID == entityID);
        }

        public ICollection<CategoryType> GetAll()
        {
            return _categoryTypeRepository.GetAll();
        }
    }
}
