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
    public class RestaurantService : IRestaurantService
    {
        public IRestaurantRepository _restaurantRepository;
        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }
        public void Insert(Restaurant entity)
        {
            _restaurantRepository.Add(entity);
        }

        public void Delete(Restaurant entity)
        {
            _restaurantRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _restaurantRepository.Delete(Get(id));
        }

        public void Update(Restaurant entity)
        {
            _restaurantRepository.Update(entity);
        }

        public Restaurant Get(int entityID)
        {
            return _restaurantRepository.Get(x => x.RestaurantID == entityID);
        }

        public ICollection<Restaurant> GetAll()
        {
            return _restaurantRepository.GetAll();
        }
    }
}
