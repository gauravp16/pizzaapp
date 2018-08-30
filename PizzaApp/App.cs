using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PizzaApp
{
    public class App
    {
        private IRepository _repository;

        public App(IRepository repository)
        {
            _repository = repository;
        }

        public async void GetPopularPizzas()
        {
            var orders = await (new Repository()).GetAllOrders();

            var ranking = new Dictionary<Topping, int>();

            foreach (var order in orders)
            {
                if (ranking.ContainsKey(order.Topping))
                    ranking[order.Topping] += 1;
                else
                    ranking.Add(order.Topping, 1);
            }

            Console.WriteLine(string.Format("Rank: {0} Name:", "\t"));

            int rank = 1;
            foreach(var pair in ranking.OrderByDescending(x => x.Value))
            {
                if (rank > 20)
                    return;
                Console.WriteLine(string.Format("{0} {1} {2}", rank, "\t", pair.Key));
                rank++;
            }
        }
    }
}
