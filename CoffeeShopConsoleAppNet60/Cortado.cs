using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee, IMilk
    {
        public override int ReturnPriceOfCoffee()
        {
            return 25;
        }

        public override string Strength()
        {
            return "Medium";
        }

        public void mlMilk()
        {
            Console.WriteLine("The Cortado contains 40 ml milk.");
        }
    }
}
