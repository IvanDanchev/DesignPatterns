namespace DecoratorPattern
{
    using System;

    /// <summary>
    /// A 'Concrete Product' class
    /// </summary>
    public class SteyrAugRifle : AssaultRifle
    {
        public override string Make
        {
            get { return "Steyr"; }
        }

        public override string Model
        {
            get { return "Aug"; }
        }

        public override double Price
        {
            get { return 2000; }
        }

        public override double Weight
        {
            get { return 3.3; }
        }
    }
}