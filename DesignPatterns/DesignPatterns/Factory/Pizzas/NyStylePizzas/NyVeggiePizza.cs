using System;

namespace DesignPatterns.Factory
{
    class NyVeggiePizza : Pizza
    {
        private readonly NyPizzaIngredientFactory myPizzaIngredientFactory;

        public NyVeggiePizza(NyPizzaIngredientFactory pizzaIngredientFactory)
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