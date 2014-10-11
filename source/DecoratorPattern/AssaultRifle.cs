namespace DecoratorPattern
{
    using System;

    public abstract class AssaultRifle
    {
        public abstract string Make { get; }
        public abstract string Model { get; }
        public abstract double Price { get; }
        public abstract double Weight { get; }
    }
}