using BusinessObject;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderDetailRepo : IOrderDetailRepo
    {
        public void AddOrderDetail(OrderDetail fr) => OrderDetailDAO.Instance.AddOrderDetail(fr);

        public List<OrderDetail> GetAllOrderDetail() => OrderDetailDAO.Instance.GetAllOrderDetail();

        public List<Transport> GetAllTransport() => TransportDAO.Instance.GetAllTransport();

        public OrderDetail GetOrderDetailbyID(int id) => OrderDetailDAO.Instance.GetOrderDetailbyID(id);

        public OrderDetail GetOrderDetailbyOrderDetailID(int OrderIDetail) => OrderDetailDAO.Instance.GetOrderDetailbyOrderDetailID(OrderIDetail);
        

        public OrderDetail GetOrderDetailByOrderId(Order order)  => OrderDetailDAO.GetOrderDetailByOrderId(order);

        public List<OrderDetail> GetOrderDetailStatus(int OrderID) => OrderDetailDAO.Instance.GetOrderDetailStatus(OrderID);


        public void Remove(int id) => OrderDetailDAO.Instance.Remove(id);

        public void UpdateOrderDetail(OrderDetail fr) => OrderDetailDAO.Instance.UpdateOrderDetail(fr);

        void IOrderDetailRepo.DeleteOrderDetail(OrderDetail OrderDetail) => OrderDetailDAO.DeleteOrderDetail(OrderDetail);
        
    }
}
