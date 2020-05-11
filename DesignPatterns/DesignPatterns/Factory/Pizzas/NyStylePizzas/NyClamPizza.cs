using System;

namespace DesignPatterns.Factory
{
    class NyClamPizza : Pizza
    {
        private readonly IPizzaIngredientFactory myPizzaIngredientFactory;

        public NyClamPizza(IPizzaIngredientFactory pizzaIngredientFactory)
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