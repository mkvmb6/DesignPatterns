using System;

namespace DesignPatterns.Factory
{
    class ChicagoPepperoniPizza : Pizza
    {
        private readonly ChicagoPizzaIngredientFactory myPizzaIngredientFactory;

        public ChicagoPepperoniPizza(ChicagoPizzaIngredientFactory pizzaIngredientFactory)
        {
            myPizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = myPizzaIngredientFactory.CreateDough();
            Sauce = myPizzaIngredientFactory.CreateSauce();
            Cheese = myPizzaIngredientFactory.CreateCheese();
            Pepperoni = myPizzaIngredientFactory.CreatePepperoni();
        }
    }
}