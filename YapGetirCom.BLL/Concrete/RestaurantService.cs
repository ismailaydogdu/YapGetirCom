﻿using System;
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
            throw new NotImplementedException();
        }

        public void Delete(Restaurant entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Restaurant entity)
        {
            throw new NotImplementedException();
        }

        public Restaurant Get(int entityID)
        {
            throw new NotImplementedException();
        }

        public ICollection<Restaurant> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}