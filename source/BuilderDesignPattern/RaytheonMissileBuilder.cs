namespace BuilderDesignPattern
{
    using System;

    // Note: Raytheon is a large US defense company
    public class RaytheonMissileBuilder : MissileBuilder
    {
        private CruiseMissile missile = new CruiseMissile();

        public override void SetManufacturer() { missile.Manufacturer = "Raytheon"; }
        public override void SetModel() { missile.Model = "BGM-109 Tomahawk"; }
        public override void SetLength() { missile.Length = 5.56; }
        public override void SetWarheadSize() { missile.WarheadSize = 450; }
        public override void SetRange() { missile.Range = 1300; }
        public override CruiseMissile BuildMissile() { return missile; }
    }
}
