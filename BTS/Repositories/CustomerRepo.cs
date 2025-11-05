using BusinessObject;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        public void AddNew(Customer Customer) => CustomerDAO.Instance.AddNew(Customer);
       

        public Customer CheckLogin(string Phone, string password) => CustomerDAO.Instance.CheckLogin(Phone, password);

        public void DeleteCustomer(Customer Customer) => CustomerDAO.DeleteCustomer(Customer);
        

        public Customer GetCustomerById(int id) => CustomerDAO.GetCustomerById(id);


        public Customer GetCustomerByUserName(string userName) => CustomerDAO.Instance.GetCustomerByUserName(userName);
       

        public List<Customer> GetCustomers() => CustomerDAO.GetCustomers();
       

        public Customer getMemberByPhone(string phone) => CustomerDAO.getMemberByPhone(phone);

        public void SaveCustomer(Customer Customer) => CustomerDAO.SaveCustomer(Customer);


        public void UpdateCustomer(Customer Customer) => CustomerDAO.Instance.UpdateCustomer(Customer);
        




        //public Customer GetCustomerByUserName(string userName) => CustomerDAO.Instance.GetCustomerByUserName(userName);



        //public void UpdateCustomer(Customer olduser) => CustomerDAO.Instance.UpdateCustomer(olduser);

    }
}
