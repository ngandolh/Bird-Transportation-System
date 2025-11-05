using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class TransportDAO
    {
        private static TransportDAO instance = null;
        private static readonly object instanceLock = new object();
        public static TransportDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TransportDAO();
                    }
                }
                return instance;
            }
        }

        public List<Transport> GetAllTransport()
        {
            var fr = new List<Transport>();
            try
            {
                using var context = new BTSContext();
                fr = context.Transports.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return fr;
        }

        public Transport GetTransportbyID(int id)
        {
            Transport fr = null;
            try
            {
                using var context = new BTSContext();
                fr = context.Transports.SingleOrDefault(c => c.TransportId == id);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }

            return fr;
        }


        public void AddTransport(Transport fr)
        {
            try
            {
                Transport Transport = GetTransportbyID(fr.TransportId);
                if (Transport == null)
                {
                    using var context = new BTSContext();
                    context.Transports.Add(fr);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Transport is already exist.");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void UpdateTransport(Transport fr)
        {
            try
            {
                Transport Transport = GetTransportbyID(fr.TransportId);
                if (Transport != null)
                {
                    using var context = new BTSContext();
                    context.Transports.Update(fr);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Transport is already exist.");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Remove(int id)
        {
            try
            {

                Transport Transport = GetTransportbyID(id);
                if (Transport != null)
                {
                    using var context = new BTSContext();
                    context.Transports.Remove(Transport);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Transport does not already exist.");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
