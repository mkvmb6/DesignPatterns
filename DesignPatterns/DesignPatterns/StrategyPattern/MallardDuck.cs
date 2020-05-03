using System;

namespace DesignPatterns.StrategyPattern
{
    public class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Mallard Duck");
        }
    }
}