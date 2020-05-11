namespace DesignPatterns.Factory
{
    abstract class PizzaStore
    {
        //private readonly SimplePizzaFactory mySimplePizzaFactory;

        //public PizzaStore(SimplePizzaFactory simplePizzaFactory)
        //{
        //    mySimplePizzaFactory = simplePizzaFactory;
        //}

        public Pizza OrderPizza(PizzaType pizzaType)
        {
            //var pizza = mySimplePizzaFactory.CreatePizza(pizzaType);
            var pizza = CreatePizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        protected abstract Pizza CreatePizza(PizzaType pizzaType);
    }
}