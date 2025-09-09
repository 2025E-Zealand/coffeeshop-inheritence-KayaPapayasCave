using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee
    {
        public override int ReturnPriceOfCoffee()
        {
            return 40;
        }

        public override string Strength()
        {
            return "Weak";
        }

        public override string mlMilk()
        {
            return "The Cortado contains 200 ml milk.";
        }
    }
}
