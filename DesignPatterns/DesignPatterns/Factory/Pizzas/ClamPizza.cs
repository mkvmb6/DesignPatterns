using System;

namespace DesignPatterns.Factory
{
    class ClamPizza : Pizza
    {
        private readonly IPizzaIngredientFactory myPizzaIngredientFactory;

        public ClamPizza(IPizzaIngredientFactory pizzaIngredientFactory)
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