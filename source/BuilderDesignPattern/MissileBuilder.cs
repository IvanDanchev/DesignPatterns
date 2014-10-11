namespace BuilderDesignPattern
{
    using System;

    public abstract class MissileBuilder
    {
        public abstract void SetManufacturer();
        public abstract void SetModel();
        public abstract void SetLength();
        public abstract void SetWarheadSize();
        public abstract void SetRange();
        public abstract CruiseMissile BuildMissile();
    }
}
