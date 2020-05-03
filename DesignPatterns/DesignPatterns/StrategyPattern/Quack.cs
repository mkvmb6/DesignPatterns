using System;

namespace DesignPatterns.StrategyPattern
{
    internal class Quack : IQuackBehaviour
    {
        public void DoQuack()
        {
            Console.WriteLine("Quack");
        }
    }
}