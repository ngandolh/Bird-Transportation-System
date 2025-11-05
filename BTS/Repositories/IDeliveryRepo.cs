using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IDeliveryRepo
    {
        List<Delivery> GetAllDelivery();
        Delivery GetDeliverybyID(int id);
        void AddDelivery(Delivery fr);
        void Remove(int id);
        void UpdateDelivery(Delivery fr);
    }
}
