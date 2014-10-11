namespace BuilderDesignPattern
{
    using System;

    // Note: Lockheed Martin is a large US defense company
    public class LockheedMartinMissileBuilder : MissileBuilder
    {
        private CruiseMissile missile = new CruiseMissile();

        public override void SetManufacturer() { missile.Manufacturer = "Lockheed Martin"; }
        public override void SetModel() { missile.Model = "AGM-158 JASSM"; }
        public override void SetLength() { missile.Length = 4.72; }
        public override void SetWarheadSize() { missile.WarheadSize = 450; }
        public override void SetRange() { missile.Range = 370; }
        public override CruiseMissile BuildMissile() { return missile; }
    }
}
