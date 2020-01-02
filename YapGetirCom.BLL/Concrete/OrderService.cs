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
    public class OrderService : IOrderService
    {
        public IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public void Insert(Order entity)
        {
            _orderRepository.Add(entity);
        }

        public void Delete(Order entity)
        {
            _orderRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _orderRepository.Delete(Get(id));
        }

        public void Update(Order entity)
        {
            _orderRepository.Update(entity);
        }

        public Order Get(int entityID)
        {
            return _orderRepository.Get(x => x.OrderID == entityID);
        }

        public ICollection<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public List<Order> GetByRestaurantID(int id)
        {
            return _orderRepository.GetAll(x => x.RestaurantID==id).ToList();
        }

        public void UpdateOrderStatus(string orderStatus,int orderID)
        {
            Order order = Get(orderID);
            order.OrderStatus = orderStatus;
            order.UpdateDate = DateTime.Now;
            Update(order);
        }
    }
}
