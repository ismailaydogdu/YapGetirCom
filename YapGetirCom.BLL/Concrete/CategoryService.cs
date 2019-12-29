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
    public class CategoryService : ICategoryService
    {
        public ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void Insert(Category entity)
        {
            _categoryRepository.Add(entity);
        }

        public void Delete(Category entity)
        {
            _categoryRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _categoryRepository.Delete(Get(id));
        }

        public void Update(Category entity)
        {
            _categoryRepository.Update(entity);
        }

        public Category Get(int entityID)
        {
            return _categoryRepository.Get(x => x.CategoryID == entityID);
        }

        public ICollection<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }
    }
}
