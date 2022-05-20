using System;

namespace assignment3
{
    public interface IAttacker
    {
        public string Driver { get; set; }

        public void AssignDriver(string driver);
        public void DriveForward();
        public void UseWeapon();
    }
}
