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
    public class ProductOrderService : IProductOrderService
    {
        public IProductOrderRepository _productOrderRepository;
        public ProductOrderService(IProductOrderRepository productOrderRepository)
        {
            _productOrderRepository = productOrderRepository;
        }
        public void Insert(ProductOrder entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductOrder entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductOrder entity)
        {
            throw new NotImplementedException();
        }

        public ProductOrder Get(int entityID)
        {
            throw new NotImplementedException();
        }

        public ICollection<ProductOrder> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}