using System;

namespace DesignPatterns.StrategyPattern
{
    class MuteQuack : IQuackBehaviour
    {
        public void DoQuack()
        {
            Console.WriteLine("Cannot quack");
        }
    }
}