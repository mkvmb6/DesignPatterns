using System;

namespace DesignPatterns.Factory
{
    class ChicagoCheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory myPizzaIngredientFactory;

        public ChicagoCheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            myPizzaIngredientFactory = pizzaIngredientFactory;
            Name = "Chicago Cheese Pizza";
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = myPizzaIngredientFactory.CreateDough();
            Sauce = myPizzaIngredientFactory.CreateSauce();
            Cheese = myPizzaIngredientFactory.CreateCheese();
        }
    }
}