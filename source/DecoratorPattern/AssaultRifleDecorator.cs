namespace DecoratorPattern
{
    using System;

    public abstract class AssaultRifleDecorator : AssaultRifle
    {
        private AssaultRifle assaultRifle;

        public AssaultRifleDecorator(AssaultRifle rifle)
        {
            assaultRifle = rifle;
        }

        public override string Make
        {
            get { return assaultRifle.Make; }
        }

        public override string Model
        {
            get { return assaultRifle.Model; }
        }

        public override double Price
        {
            get { return assaultRifle.Price; }
        }

        public override double Weight
        {
            get { return assaultRifle.Weight; }
        }
    }
}
