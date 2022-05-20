using System;

namespace assignment3
{
    class Robot
    {
        public string Person { get; set; }
        
        public void BashWithHands()
        {
            Console.WriteLine("Robot causes damage with hands");
        }
        public void MoveByPerson(string person)
        {
            Person = person;
            Console.WriteLine($"Robot is moved by {Person}");
        }
        public void WalkForward()
        {
            Console.WriteLine("Robot walks forward");
        }
    }
}
