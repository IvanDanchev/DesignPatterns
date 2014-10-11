namespace FactoryDesignPattern
{
    using System;

    /// <summary>
    /// A 'Concrete Product' class
    /// </summary>
    public class JetFighter : IFactory
    {
        public void Fly(int kilometers)
        {
            Console.WriteLine("Jet fighter aircraft has flown: " + kilometers.ToString() + "km");
        }
    }
}
