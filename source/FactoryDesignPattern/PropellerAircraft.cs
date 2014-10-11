namespace FactoryDesignPattern
{
    using System;

    /// <summary>
    /// A 'Concrete Product' class
    /// </summary>
    public class PropellerAircraft : IFactory
    {
        public void Fly(int kilometers)
        {
            Console.WriteLine("Propeller aircraft has flown: " + kilometers.ToString() + "km");
        }
    }
}
