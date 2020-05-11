using System;

namespace DesignPatterns.Factory
{
    class ChicagoVeggiePizza : Pizza
    {
        private readonly ChicagoPizzaIngredientFactory myPizzaIngredientFactory;

        public ChicagoVeggiePizza(ChicagoPizzaIngredientFactory pizzaIngredientFactory)
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