using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; }
            private set { instance = value; }
        }

        private CustomerDAO() { }

        //public bool Login(string userName, string passWord)
        //{
        //    try
        //    {
        //        using var context = new BTSContext();
        //        Customer checker = context.Customers.SingleOrDefault(acc => acc.Phone == userName && acc.Password == passWord);
        //        if (checker != null) return true;
        //        else return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        public Customer CheckLogin(string Phone, string password)
        {
            Customer result = null;
            BTSContext DbContext = new BTSContext();
            var member = DbContext.Customers
                    .Where(b => b.Phone == Phone)
                    .FirstOrDefault();
            if (member == null)
            {
                throw new Exception("Customer name does not existed!");
            }
            else
            {
                if (member.Password != password)
                {
                    throw new Exception("Password does not correct!");
                }
                else { result = member; }
            }
            return result;
        }

        public Customer GetCustomerByUserName(string userName)
        {
            try
            {
                using var context = new BTSContext();
                Customer acc = context.Customers.SingleOrDefault(a => a.CustomerName == userName);
                return acc;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Customer GetCustomerById(int id)
        {
            Customer Customer = new Customer();
            try
            {
                using (var context = new BTSContext())
                {
                    Customer = context.Customers.SingleOrDefault(m => m.CustomerId == id);

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Customer;
        }
        public static Customer getMemberByPhone(string phone)
        {
            Customer member = new Customer();
            try
            {
                using (var context = new BTSContext())
                {
                    member = context.Customers.SingleOrDefault(f => f.Phone == phone);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }

        public static List<Customer> GetCustomers()
        {
            List<Customer> listCustomers = new List<Customer>();
            try
            {
                using (var context = new BTSContext())
                {
                    listCustomers = context.Customers.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listCustomers;
        }

        public static void SaveCustomer(Customer Customer)
        {
            try
            {
                using (var context = new BTSContext())
                {
                    context.Customers.Add(Customer); // Thêm DbSet<Customer>
                    context.SaveChanges(); // Cập nhập DB
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteCustomer(Customer Customer)
        {
            try
            {
                using (var context = new BTSContext())
                {
                    var p1 = context.Customers.SingleOrDefault(m => m.CustomerId == Customer.CustomerId);
                    context.Customers.Remove(p1); // remove ra khỏi Collection(DbSet)
                    context.SaveChanges(); // Cập nhập database
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateCustomer(Customer olduser)
        {
            try
            {
                using var context = new BTSContext();
                var existingCustomer = context.Customers.FirstOrDefault(c => c.CustomerId == olduser.CustomerId);

                if (existingCustomer != null)
                {
                    // Cập nhật thông tin của khách hàng
                    existingCustomer.CustomerName = olduser.CustomerName;
                    existingCustomer.Password = olduser.Password;
                    existingCustomer.Phone = olduser.Phone;
                    existingCustomer.Address = olduser.Address;

                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Customer not found in the database.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating customer: " + ex.Message);
            }
        }

        public void AddNew(Customer customer)
        {
            try
            {
                using (var context = new BTSContext())
                {
                    context.Customers.Add(customer); // Thêm customer mới vào DbSet
                    context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

