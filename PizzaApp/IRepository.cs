using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public interface IRepository
    {
        Task<IList<Order>> GetAllOrders();
    }
}
