using System;

namespace DesignPatterns.Factory
{
    class ChicagoClamPizza : Pizza
    {
        private readonly ChicagoPizzaIngredientFactory myPizzaIngredientFactory;

        public ChicagoClamPizza(ChicagoPizzaIngredientFactory pizzaIngredientFactory)
        {
            myPizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = myPizzaIngredientFactory.CreateDough();
            Sauce = myPizzaIngredientFactory.CreateSauce();
            Cheese = myPizzaIngredientFactory.CreateCheese();
            Clam = myPizzaIngredientFactory.CreateClam();
        }
    }
}