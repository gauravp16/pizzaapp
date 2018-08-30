using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PizzaApp
{
    public class Order
    {
        private Topping _topping;
        
        [JsonConstructor]
        public Order(string[] toppings)
        {
            _topping = new Topping(toppings);
        }

        public Topping Topping
        {
            get { return _topping; }
        }
    }
}
