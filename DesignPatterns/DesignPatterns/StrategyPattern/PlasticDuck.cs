using System;

namespace DesignPatterns.StrategyPattern
{
    public class PlasticDuck : Duck
    {
        public PlasticDuck()
        {
            FlyingBehaviour = new FlyNoWay();
            QuackBehaviour = new MuteQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Plastic duck");
        }
    }
}