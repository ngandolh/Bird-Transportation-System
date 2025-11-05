using BusinessObject;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CarrierRepo : ICarrierRepocs
    {
        public Carrier CheckLogin(string Phone, string password) => CarrierDAO.Instance.CheckLogin(Phone, password);
        
    }
}
