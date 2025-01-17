﻿using System;

namespace assignment3
{
    class Tank : IAttacker
    {
        public string Driver { get; set; }

        public void AssignDriver(string driver)
        {
            Driver = driver;
            Console.WriteLine($"{Driver} is steering the tank");
        }
        public void DriveForward()
        {
            Console.WriteLine("Tank moves forward");
        }
        public void UseWeapon()
        {
            Console.WriteLine("Tank causes damage with weapon");
        }
    }
}