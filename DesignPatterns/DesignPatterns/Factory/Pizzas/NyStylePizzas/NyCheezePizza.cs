using System;

namespace DesignPatterns.Factory
{
    class NyCheezePizza : Pizza
    {
        private readonly IPizzaIngredientFactory myPizzaIngredientFactory;

        public NyCheezePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            myPizzaIngredientFactory = pizzaIngredientFactory;
            Name = "NyCheeze Pizza";
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