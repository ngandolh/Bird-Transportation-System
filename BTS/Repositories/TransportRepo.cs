using BusinessObject;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class TransportRepo : ITransportRepo
    {
        public void AddTransport(Transport fr) => TransportDAO.Instance.AddTransport(fr);

        public List<Transport> GetAllTransport() => TransportDAO.Instance.GetAllTransport();

        public Transport GetTransportbyID(int id) => TransportDAO.Instance.GetTransportbyID(id);

        public void Remove(int id) => TransportDAO.Instance.Remove(id);

        public void UpdateTransport(Transport fr) => TransportDAO.Instance.UpdateTransport(fr);
    }
}
