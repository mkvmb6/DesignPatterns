namespace DesignPatterns.Factory
{
    class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType pizzaType)
        {

            Pizza pizza = null;
            var pizzaIngredientFactory = new ChicagoPizzaIngredientFactory();

            switch (pizzaType)
            {
                case PizzaType.Cheese:
                    pizza = new ChicagoCheesePizza(pizzaIngredientFactory);
                    break;
                case PizzaType.Pepperoni:
                    pizza = new ChicagoPepperoniPizza(pizzaIngredientFactory);
                    break;
                case PizzaType.Clam:
                    pizza = new ChicagoClamPizza(pizzaIngredientFactory);
                    break;
                case PizzaType.Veggie:
                    pizza = new ChicagoVeggiePizza(pizzaIngredientFactory);
                    break;
            }

            return pizza;
        }
    }
}