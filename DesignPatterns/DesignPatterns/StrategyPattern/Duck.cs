using System;

namespace DesignPatterns.StrategyPattern
{
    public abstract class Duck
    {
        public IFlyingBehaviour FlyingBehaviour { get; set; }
        public IQuackBehaviour QuackBehaviour { get; set; }

        protected Duck()
        {
            FlyingBehaviour = new FlyWithWings();
            QuackBehaviour = new Quack();
        }

        public abstract void Display();

        public void PerformFly()
        {
            FlyingBehaviour.Fly();
        }

        public void PerformQuack()
        {
            QuackBehaviour.DoQuack();
        }

        public void Swim()
        {
            Console.WriteLine("I swim, so do the all other ducks. Even the plactic ones.");
        }

        public void SetFlyingBehaviour(IFlyingBehaviour flyingBehaviour)
        {
            FlyingBehaviour = flyingBehaviour;
        }

        public void SetQuackBehaviour(IQuackBehaviour quackBehaviour)
        {
            QuackBehaviour = quackBehaviour;
        }
    }
}