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
    public class UnitAndProductRecipeService : IUnitAndProductRecipeService
    {
        IUnitAndProductRecipeRepository _unitAndProductRecipeRepository;
        public UnitAndProductRecipeService(IUnitAndProductRecipeRepository unitAndProductRecipeRepository)
        {
            _unitAndProductRecipeRepository = unitAndProductRecipeRepository;
        }
        public void Delete(UnitAndProductRecipe entity)
        {
            _unitAndProductRecipeRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _unitAndProductRecipeRepository.Delete(Get(id));
        }

        public UnitAndProductRecipe Get(int entityID)
        {
            return _unitAndProductRecipeRepository.Get(x => x.UnitAndProductRecipeID == entityID);
        }

        public ICollection<UnitAndProductRecipe> GetAll()
        {
            return _unitAndProductRecipeRepository.GetAll();
        }

        public void Insert(UnitAndProductRecipe entity)
        {
            _unitAndProductRecipeRepository.Add(entity);
        }

        public void Update(UnitAndProductRecipe entity)
        {
            _unitAndProductRecipeRepository.Update(entity);
        }
    }
}
