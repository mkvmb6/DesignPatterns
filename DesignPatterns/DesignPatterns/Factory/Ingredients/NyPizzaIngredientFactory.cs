namespace DesignPatterns.Factory
{
    class NyPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IVeggie[] CreateVeggies()
        {
            return new IVeggie[] {new Garlic(), new Onion(), new Mushroom(), new RedPepper()};
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClam CreateClam()
        {
            return new FreshClam();
        }
    }
}