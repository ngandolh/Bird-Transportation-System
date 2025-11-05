using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CarrierDAO
    {
        private static CarrierDAO instance;

        public static CarrierDAO Instance
        {
            get { if (instance == null) instance = new CarrierDAO(); return instance; }
            private set { instance = value; }
        }

        public Carrier CheckLogin(string Phone, string password)
        {
            Carrier result = null;
            BTSContext DbContext = new BTSContext();
            var member = DbContext.Carriers
                    .Where(b => b.Carrier1 == Phone)
                    .FirstOrDefault();
            if (member == null)
            {
                throw new Exception("Carrier name does not existed!");
            }
            else
            {
                if (member.CarrierPass != password)
                {
                    throw new Exception("Password does not correct!");
                }
                else { result = member; }
            }
            return result;
        }
    }
}
