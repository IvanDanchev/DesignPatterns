namespace DecoratorPattern
{
    using System;

    /// <summary>
    /// 'Concrete Decorator 1' class
    /// </summary>
    public class CustomAssaultRifleOffer : AssaultRifleDecorator
    {
        public CustomAssaultRifleOffer(AssaultRifle rifle) : base(rifle) { }

        public double AttachmentsPrice { get; set; }
        public double AttachmentsWeight { get; set; }

        public override double Price
        {
            get
            {
                return base.Price + AttachmentsPrice;
            }
        }

        public override double Weight
        {
            get
            {
                return base.Weight + AttachmentsWeight;
            }
        }
    }
}
