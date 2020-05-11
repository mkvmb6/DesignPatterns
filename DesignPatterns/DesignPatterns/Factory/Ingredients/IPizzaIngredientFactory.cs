namespace DesignPatterns.Factory
{
    interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IVeggie[] CreateVeggies();
        IPepperoni CreatePepperoni();
        IClam CreateClam();
    }
}