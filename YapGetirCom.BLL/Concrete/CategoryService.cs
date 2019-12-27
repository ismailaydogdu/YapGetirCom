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
        public ICampaignRepository _campaignRepository;
        public CategoryService(ICampaignRepository campaignRepository)
        {
            _campaignRepository = campaignRepository;
        }
        public void Insert(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(int entityID)
        {
            throw new NotImplementedException();
        }

        public ICollection<Category> GetAll()
        {
            throw new NotImplementedException();




        }
    }
}
