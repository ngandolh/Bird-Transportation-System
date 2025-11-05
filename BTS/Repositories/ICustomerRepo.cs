using BusinessObject;
using System.Collections.Generic;

namespace Repositories
{
    public interface ICustomerRepo
    {
        Customer CheckLogin(string Phone, string password);
        Customer getMemberByPhone(string phone);
        Customer GetCustomerByUserName(string userName);
        Customer GetCustomerById(int id);
        List<Customer> GetCustomers();
        void SaveCustomer(Customer Customer);
        void DeleteCustomer(Customer Customer);
        void UpdateCustomer(Customer Customer);
        void AddNew(Customer Customer);
    }
}