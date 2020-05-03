using System;

namespace DesignPatterns.StrategyPattern
{
    internal class FlyWithWings : IFlyingBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flying with wings.");
        }
    }
}