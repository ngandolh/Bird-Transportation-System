using BusinessObject;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepo : IOrderRepo
    {
        public void CreateOder(Order order) => OrderDAO.CreateOder(order);

        public void DeleteOrder(Order ord) => OrderDAO.DeleteOrder(ord);

        public List<Order> GetAllOrder() => OrderDAO.GetAllOrder();

        public List<Bird> GetBirds() => BirdDAO.GetBirds();

        public List<Order> GetOrderByCustomer(int ID) => OrderDAO.GetOrderByCustomer(ID);

        public Order GetOrderByCustomerID(int id) => OrderDAO.GetOrderByCustomerID(id);

        public Order GetOrderByOrderID(int OrderID) => OrderDAO.GetOrderByOrderID(OrderID);

        public List<Order> GetOrderByStatus(string status) => OrderDAO.GetOrderByStatus(status);
        

        public void UpdateOrder(Order ord) => OrderDAO.UpdateOrder(ord);
    }
}
