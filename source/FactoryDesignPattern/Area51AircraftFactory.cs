namespace FactoryDesignPattern
{
    using System;

    /// <summary>
    /// A 'Concrete Creator' class
    /// </summary>
    public class Area51AircraftFactory : AircraftFactory
    {
        public override IFactory GetAircraft(string aircraft)
        {
            switch (aircraft)
            {
                case "PropellerAircraft":
                    return new PropellerAircraft();
                case "JetFighter":
                    return new JetFighter();
                default:
                    throw new ArgumentException(string.Format("Aircraft '{0}' cannot be created in this factory.", aircraft));
            }
        }

    }
}
