using CoffeeShopConsoleAppNet60;

BlackCoffee Coffee1 = new();
Cortado Coffee2 = new();
Latte Coffee3 = new();

List<Coffee> Coffees = new List<Coffee>();
Coffees.Add(Coffee1);
Coffees.Add(Coffee2);
Coffees.Add(Coffee3);

foreach (var coffee in Coffees)
{
    Console.WriteLine($"The price for a {coffee} is: {coffee.ReturnPriceOfCoffee()} and the strength is: {coffee.Strength()}.");
}