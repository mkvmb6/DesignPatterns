using System;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory
{
    public abstract class Pizza
    {
        public IDough Dough { get; set; }
        public string Name { get; set; }
        public ISauce Sauce { get; set; }
        public IVeggie[] Veggies { get; set; }
        public ICheese Cheese { get; set; }
        public IClam Clam { get; set; }
        public IPepperoni Pepperoni { get; set; }

        /*public void Prepare()
        {
            
             Console.WriteLine($"Preparing {name}");
            Console.WriteLine($"Tossing {dough}");
            Console.WriteLine($"Adding Sauce {sauce}");
            Console.WriteLine($"Adding toppings: ");
            foreach (var topping in toppings)
            {
                Console.WriteLine($"\t{topping}");
            }

        }*/

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Baking the pizza");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza");
        }

        public void Box()
        {
            Console.WriteLine("Boxing the pizza");
        }

        public override string ToString()
        {
            return $" {Dough},  {Name},  {Sauce},{Veggies}, {Cheese}, {Clam}, {Pepperoni}";
        }
    }
}
