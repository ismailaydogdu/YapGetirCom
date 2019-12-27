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
            throw new NotImplementedException();
        }

        public void Delete(CategoryType entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CategoryType entity)
        {
            throw new NotImplementedException();
        }

        public CategoryType Get(int entityID)
        {
            throw new NotImplementedException();
        }

        public ICollection<CategoryType> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
