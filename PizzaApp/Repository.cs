using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PizzaApp
{
    public class Repository : IRepository
    {
        public async Task<IList<Order>> GetAllOrders()
        {
            var response = await(new HttpClient()).GetAsync("http://files.olo.com/pizzas.json");

            if (!response.IsSuccessStatusCode)
            {
                //log the remote error returned here.
                throw new Exception("Error while getting the list of orders");
            }

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IList<Order>>(body);
        }
    }
}

