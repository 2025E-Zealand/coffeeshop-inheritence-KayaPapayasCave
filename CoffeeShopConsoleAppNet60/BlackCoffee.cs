using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class BlackCoffee : Coffee
    {
        public override void Strength()
        {
            Console.WriteLine("The Black Coffee is strong");
        }
    }
}
