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
            _recipeRepository.Add(entity);
        }

        public void Delete(Recipe entity)
        {
            _recipeRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _recipeRepository.Delete(Get(id));
        }

        public void Update(Recipe entity)
        {
            _recipeRepository.Update(entity);
        }

        public Recipe Get(int entityID)
        {
            return _recipeRepository.Get(x => x.RecipeID == entityID);
        }

        public ICollection<Recipe> GetAll()
        {
            return _recipeRepository.GetAll();
        }
    }
}
