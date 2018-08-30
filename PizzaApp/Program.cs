using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;

namespace PizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            (new App(new Repository())).GetPopularPizzas();
            Console.ReadLine();
        }
    }
}