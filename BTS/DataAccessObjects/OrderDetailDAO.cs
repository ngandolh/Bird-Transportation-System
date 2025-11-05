using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance;

        public static OrderDetailDAO Instance
        {
            get { if (instance == null) instance = new OrderDetailDAO(); return instance; }
            private set { instance = value; }
        }
        public OrderDetailDAO() { }

        public List<OrderDetail> GetAllOrderDetail()
        {
            var fr = new List<OrderDetail>();
            try
            {
                using var context = new BTSContext();
                fr = context.OrderDetails.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return fr;
        }

        public List<OrderDetail> GetOrderDetailStatus(int OrderID)
        {
            List<OrderDetail> fr = new List<OrderDetail>();
            try
            {
                using var context = new BTSContext();
                fr = context.OrderDetails.Where(c => c.OrderId == OrderID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return fr;
        }

        public OrderDetail GetOrderDetailbyID(int OrderIDetail)
        {
            OrderDetail od = null;
            try
            {
                using (var context = new BTSContext())
                {
                    od = context.OrderDetails.SingleOrDefault(c => c.OrderId == OrderIDetail);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return od;
        }

        public OrderDetail GetOrderDetailbyOrderDetailID(int OrderIDetail)
        {
            OrderDetail od = null;
            try
            {
                using (var context = new BTSContext())
                {
                    od = context.OrderDetails.SingleOrDefault(c => c.OrderIdetail == OrderIDetail);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return od;
        }

        public void AddOrderDetail(OrderDetail fr)
        {
            try
            {
                OrderDetail OrderDetail = GetOrderDetailbyID(fr.OrderIdetail);
                
                if (OrderDetail == null)
                {
                    using var context = new BTSContext();
                    context.OrderDetails.Add(fr);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The OrderDetail is already exist.");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void UpdateOrderDetail(OrderDetail fr)
        {
            try
            {
                OrderDetail OrderDetail = GetOrderDetailbyID(fr.OrderId);
                if (OrderDetail != null)
                {
                    using var context = new BTSContext();
                    context.OrderDetails.Update(fr);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The OrderDetail is already exist.");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Remove(int id)
        {
            try
            {

                OrderDetail OrderDetail = GetOrderDetailbyID(id);
                if (OrderDetail != null)
                {
                    using var context = new BTSContext();
                    context.OrderDetails.Remove(OrderDetail);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The OrderDetail does not already exist.");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public static void DeleteOrderDetail(OrderDetail OrderDetail)
        {
            try
            {
                using (var context = new BTSContext())
                {
                    var p1 = context.OrderDetails.SingleOrDefault(m => m.OrderId == OrderDetail.OrderId);
                    context.OrderDetails.Remove(p1); // remove ra khỏi Collection(DbSet)
                    context.SaveChanges(); // Cập nhập database
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static OrderDetail GetOrderDetailByOrderId(Order order)
        {
            OrderDetail orderDetail = null;
            try
            {
                using (var context = new BTSContext())
                {
                    orderDetail = context.OrderDetails.SingleOrDefault(o => o.OrderId == order.OrderId);

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return orderDetail;
        }
    }
}
