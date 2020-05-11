using System;

namespace DesignPatterns.Factory
{
    class NyPepperoniPizza : Pizza
    {
        private readonly IPizzaIngredientFactory myPizzaIngredientFactory;

        public NyPepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory)
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
            Pepperoni = myPizzaIngredientFactory.CreatePepperoni();

        }
    }
}