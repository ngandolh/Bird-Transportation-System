using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class DeliveryDAO
    {
        private static DeliveryDAO instance = null;
        private static readonly object instanceLock = new object();
        public static DeliveryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new DeliveryDAO();
                    }
                }
                return instance;
            }
        }

        public List<Delivery> GetAllDelivery()
        {
            var fr = new List<Delivery>();
            try
            {
                using var context = new BTSContext();
                fr = context.Deliveries.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return fr;
        }

        public Delivery GetDeliverybyID(int id)
        {
            Delivery fr = null;
            try
            {
                using var context = new BTSContext();
                fr = context.Deliveries.SingleOrDefault(c => c.DeliveryId == id);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }

            return fr;
        }


        public void AddDelivery(Delivery fr)
        {
            try
            {
                Delivery Delivery = GetDeliverybyID(fr.DeliveryId);
                if (Delivery == null)
                {
                    using var context = new BTSContext();
                    context.Deliveries.Add(fr);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Delivery is already exist.");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void UpdateDelivery(Delivery fr)
        {
            try
            {
                Delivery Delivery = GetDeliverybyID(fr.DeliveryId);
                if (Delivery != null)
                {
                    using var context = new BTSContext();
                    context.Deliveries.Update(fr);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Delivery is already exist.");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Remove(int id)
        {
            try
            {

                Delivery Delivery = GetDeliverybyID(id);
                if (Delivery != null)
                {
                    using var context = new BTSContext();
                    context.Deliveries.Remove(Delivery);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Delivery does not already exist.");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
