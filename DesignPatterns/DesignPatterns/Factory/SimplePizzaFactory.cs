namespace DesignPatterns.Factory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = null;
            var pizzaIngredientFactory = new NyPizzaIngredientFactory();

            switch (pizzaType)
            {
                case PizzaType.Cheese:
                    pizza = new CheezePizza(pizzaIngredientFactory);
                    break;
                case PizzaType.Pepperoni:
                    pizza = new PepperoniPizza(pizzaIngredientFactory);
                    break;
                case PizzaType.Clam:
                    pizza = new ClamPizza(pizzaIngredientFactory);
                    break;
                case PizzaType.Veggie:
                    pizza = new VeggiePizza(pizzaIngredientFactory);
                    break;
            }

            return pizza;
        }
    }
}