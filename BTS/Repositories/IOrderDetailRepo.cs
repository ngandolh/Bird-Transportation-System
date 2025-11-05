using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderDetailRepo
    {
        List<OrderDetail> GetAllOrderDetail();
        List<Transport> GetAllTransport();
        OrderDetail GetOrderDetailbyID(int id);
        void AddOrderDetail(OrderDetail fr);
        void UpdateOrderDetail(OrderDetail fr);
        void Remove(int id);
        void DeleteOrderDetail(OrderDetail OrderDetail);

        OrderDetail GetOrderDetailByOrderId(Order order);
        OrderDetail GetOrderDetailbyOrderDetailID(int OrderIDetail);

        List<OrderDetail> GetOrderDetailStatus(int OrderID);
    }
}
