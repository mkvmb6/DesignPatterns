using System;

namespace DesignPatterns.StrategyPattern
{
    class DuckDriver
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.SetFlyingBehaviour(new FlyWithRocket());
            mallardDuck.PerformFly();
            Console.WriteLine();
            Console.WriteLine();

            Duck plasticDuck = new PlasticDuck();
            plasticDuck.Display();
            plasticDuck.PerformFly();
            plasticDuck.PerformQuack();

        }
    }
}