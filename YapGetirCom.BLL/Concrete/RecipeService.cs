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
    public class RecipeService : IRecipeService
    {
        public IRecipeRepository _recipeRepository;
        public RecipeService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }
        public void Insert(Recipe entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Recipe entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Recipe entity)
        {
            throw new NotImplementedException();
        }

        public Recipe Get(int entityID)
        {
            throw new NotImplementedException();
        }

        public ICollection<Recipe> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
