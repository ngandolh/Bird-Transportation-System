using BusinessObject;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class DeliveryRepo : IDeliveryRepo
    {
        public void AddDelivery(Delivery fr) => DeliveryDAO.Instance.AddDelivery(fr);


        public List<Delivery> GetAllDelivery() => DeliveryDAO.Instance.GetAllDelivery();

        public Delivery GetDeliverybyID(int id) => DeliveryDAO.Instance.GetDeliverybyID(id);

        public void Remove(int id) => DeliveryDAO.Instance.Remove(id);

        public void UpdateDelivery(Delivery fr) => DeliveryDAO.Instance.UpdateDelivery(fr);
        
    }
}
