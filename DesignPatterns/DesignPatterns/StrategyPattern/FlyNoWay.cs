using System;

namespace DesignPatterns.StrategyPattern
{
    class FlyNoWay : IFlyingBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Cannot fly");
        }
    }
}