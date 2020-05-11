using System;

namespace DesignPatterns.Factory
{
    class VeggiePizza : Pizza
    {
        private readonly IPizzaIngredientFactory myPizzaIngredientFactory;

        public VeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            myPizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = myPizzaIngredientFactory.CreateDough();
            Sauce = myPizzaIngredientFactory.CreateSauce();
            Cheese = myPizzaIngredientFactory.CreateCheese();
            Veggies = myPizzaIngredientFactory.CreateVeggies();
        }
    }
}