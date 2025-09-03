using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee
    {
        public override int ReturnPriceOfCoffee()
        {
            return 25;
        }

        public override void Strength()
        {
            Console.WriteLine("The Cortado is medium");
        }
    }
}
