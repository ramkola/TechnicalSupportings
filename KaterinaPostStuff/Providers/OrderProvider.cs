using KaterinaPostStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaterinaPostStuff.Providers
{
    public class OrderProvider
    {
        IEnumerable<Order> SourceData = new[]
        {
            new Order { Id = 1, DossierCode = "First", ConfDelDate = DateTime.Now, DelAddrCode = "Code" },
            new Order { Id = 2, DossierCode = "Second", ConfDelDate = DateTime.Now.AddDays(-2), DelAddrCode = "Code" },
        };

        public IEnumerable<Order> GetAllOrders()
        {
            return SourceData;
        }

        public Order GetOrderById(int id)
        {
            return SourceData.FirstOrDefault(m => m.Id == id);
        }
    }
}
