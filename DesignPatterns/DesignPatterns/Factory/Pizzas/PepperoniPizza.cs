using System;

namespace DesignPatterns.Factory
{
    class PepperoniPizza : Pizza
    {
        private readonly IPizzaIngredientFactory myPizzaIngredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            myPizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = myPizzaIngredientFactory.CreateDough();
            Sauce = myPizzaIngredientFactory.CreateSauce();
            Pepperoni = myPizzaIngredientFactory.CreatePepperoni();
        }
    }
}