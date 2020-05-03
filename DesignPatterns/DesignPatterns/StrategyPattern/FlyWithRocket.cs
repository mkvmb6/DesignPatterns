using System;

namespace DesignPatterns.StrategyPattern
{
    class FlyWithRocket : IFlyingBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flying with rockets");
        }
    }
}