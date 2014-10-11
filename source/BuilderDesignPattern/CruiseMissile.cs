namespace BuilderDesignPattern
{
    using System;

    public class CruiseMissile
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public double Length { get; set; }
        public int WarheadSize { get; set; }
        public int Range { get; set; }

        public override string ToString()
        {
            return string.Format("Manufacturer: {0}\nModel: {1}\nLength: {2}m\nWarheadSize: {3}kg\nRange: {4}km",
                Manufacturer, Model, Length, WarheadSize, Range);
        }
    }
}
