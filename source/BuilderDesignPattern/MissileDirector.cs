namespace BuilderDesignPattern
{
    using System;

    public class MissileDirector
    {
        public void CreateMissile(MissileBuilder missileBuilder)
        {
            missileBuilder.SetManufacturer();
            missileBuilder.SetModel();
            missileBuilder.SetLength();
            missileBuilder.SetWarheadSize();
            missileBuilder.SetRange();
        }
    }
}
