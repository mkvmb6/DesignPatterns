namespace DesignPatterns.Factory
{
    class NyPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType pizzaType)
        {

            Pizza pizza = null;
            var pizzaIngredientFactory = new NyPizzaIngredientFactory();
            switch (pizzaType)
            {
                case PizzaType.Cheese:
                    pizza = new NyCheezePizza(pizzaIngredientFactory);
                    break;
                case PizzaType.Pepperoni:
                    pizza = new NyPepperoniPizza(pizzaIngredientFactory);
                    break;
                case PizzaType.Clam:
                    pizza = new NyClamPizza(pizzaIngredientFactory);
                    break;
                case PizzaType.Veggie:
                    pizza = new NyVeggiePizza(pizzaIngredientFactory);
                    break;
            }

            return pizza;
        }
    }
}