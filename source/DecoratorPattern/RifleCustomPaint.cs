namespace DecoratorPattern
{
    using System;

    /// <summary>
    /// 'Concrete Decorator 2' class
    /// </summary>
    public class RifleCustomPaint : AssaultRifleDecorator
    {
        public RifleCustomPaint(AssaultRifle rifle) : base(rifle) { }

        //Adds a custom paint without changing any of the parameters of the base object
        public void AddCustomPaint(string paintColor)
        {
            Console.WriteLine("{0} {1} painted in {2} costs {3:c}, weighs {4} kg."
                , Make, Model, paintColor, Price, Weight);
        }
    }
}
