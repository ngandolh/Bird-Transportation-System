using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ITransportRepo
    {
        List<Transport> GetAllTransport();
        Transport GetTransportbyID(int id);
        void AddTransport(Transport fr);
        void UpdateTransport(Transport fr);
        void Remove(int id);

    }
}
