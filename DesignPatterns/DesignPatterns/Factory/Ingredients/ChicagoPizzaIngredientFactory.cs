namespace DesignPatterns.Factory
{
    class ChicagoPizzaIngredientFactory:IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IVeggie[] CreateVeggies()
        {
            return new IVeggie[] { new EggPlant(),new Spinach(),new BlackOlives() };
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClam CreateClam()
        {
            return new FrozenClam();
        }
    }
}