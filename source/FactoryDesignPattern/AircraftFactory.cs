namespace FactoryDesignPattern
{
    using System;

    /// <summary>
    /// The 'Creator' abstract Class
    /// </summary>
    public abstract class AircraftFactory
    {
        public abstract IFactory GetAircraft(string aircraft);

    }
}
