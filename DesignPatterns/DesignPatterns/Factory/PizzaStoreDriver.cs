using System;

namespace DesignPatterns.Factory
{
    internal static class PizzaStoreDriver
    {
        static void Main()
        {
            PizzaStore pizzaStore = new NyPizzaStore();
            var pizza = pizzaStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine(pizza);
            Console.WriteLine();
            pizzaStore = new ChicagoPizzaStore();
            pizza = pizzaStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine(pizza);
        }
    }
}