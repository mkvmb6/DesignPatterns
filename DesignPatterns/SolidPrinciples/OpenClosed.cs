using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidPrinciples
{
    enum Size
    {
        Small,
        Medium,
        Large,
        ExtraLarge
    }

    enum Color
    {
        Red,
        Green,
        Blue,
        Black
    }

    internal class Product
    {
        public string Name;
        public Size Size;
        public Color Color;

        public Product(string name, Color color, Size size)
        {
            Color = color;
            Size = size;
            Name = name;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Size)}: {Size}, {nameof(Color)}: {Color}";
        }
    }

    //A class should be open for extension and closed for modification. But below class needs modification every time a different type of filter is required. Which means it is not open for extension.
    internal class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            return products.Where(p => p.Size == size);
        }

        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            return products.Where(p => p.Color == color);
        }

        public IEnumerable<Product> FilterByColorAndSize(IEnumerable<Product> products, Color color, Size size)
        {
            return products.Where(p => p.Color == color && p.Size == size);
        }
    }

    //I will not change this class anymore.
    internal class BetterFilter<T> : IFilter<T>
    {
        public IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec)
        {
            return items.Where(spec.IsSatisfied);
        }
    }

    internal class ColorSpecification : ISpecification<Product>
    {
        private readonly Color myColor;

        public ColorSpecification(Color color)
        {
            myColor = color;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Color == myColor;
        }
    }

    internal class SizeSpecification : ISpecification<Product>
    {
        private readonly Size mySize;

        public SizeSpecification(Size size)
        {
            mySize = size;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Size == mySize;
        }
    }

    internal class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T>[] mySpecs;

        public AndSpecification(params ISpecification<T>[] specs)
        {
            if (specs == null) throw new ArgumentNullException(nameof(specs));
            foreach (var specification in specs)
            {
                if (specification==null)
                {
                    throw new ArgumentNullException(nameof(specification));
                }
            }
            mySpecs = specs;
        }

        public bool IsSatisfied(T item)
        {
            return mySpecs.All(spec => spec.IsSatisfied(item));
        }
    }

    internal interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
    }

    internal interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }

    internal class OpenClosed
    {
        static void Main()
        {
            var apple = new Product("Apple", Color.Red, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Red, Size.Large);

            var products = new[] {apple, tree, house};

            //Below usage is voilation of OpenClosed principle
            /*var filter = new ProductFilter();
            Console.WriteLine("All Large Products:");
            PrintProducts(filter.FilterBySize(products, Size.Large));

            Console.WriteLine("All Red Products:");
            PrintProducts(filter.FilterByColor(products, Color.Red));

            Console.WriteLine("All Red and Large Products:");
            PrintProducts(filter.FilterByColorAndSize(products, Color.Red, Size.Large));*/

            var filter = new BetterFilter<Product>();
            var colorSpec = new ColorSpecification(Color.Red);
            Console.WriteLine("All Red Products:");
            PrintProducts(filter.Filter(products, colorSpec));

            var sizeSpec = new SizeSpecification(Size.Large);
            Console.WriteLine("All Large Products:");
            PrintProducts(filter.Filter(products, sizeSpec));

            var andSpec = new AndSpecification<Product>(colorSpec, sizeSpec);
            Console.WriteLine("All Red and Large Products:");
            PrintProducts(filter.Filter(products, andSpec));
        }

        private static void PrintProducts(IEnumerable<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
            }
            Console.WriteLine();
        }
    }
}