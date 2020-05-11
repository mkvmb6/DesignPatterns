using System;

namespace DesignPatterns.Factory
{
    class CheezePizza : Pizza
    {
        private readonly IPizzaIngredientFactory myPizzaIngredientFactory;

        public CheezePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            myPizzaIngredientFactory = pizzaIngredientFactory;
            Console.WriteLine("CheezePizza ctor");
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