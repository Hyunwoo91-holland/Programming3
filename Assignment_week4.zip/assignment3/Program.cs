using System;
using System.Collections.Generic;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            // create a tank (and assign a driver)
            Tank tank = new Tank();
            tank.AssignDriver("Frank");

            // create a robot 
            Robot robot = new Robot();
            robot.MoveByPerson("Mark");
            RobotAdapter attackerRobot = new RobotAdapter(robot);

            // create attackers list, and add tank and robot
            List<IAttacker> attackers = new List<IAttacker>();
            attackers.Add(tank);
            attackers.Add(attackerRobot);

            // process all attackers
            foreach (IAttacker attacker in attackers)
            {
                Console.WriteLine($"\nDriver of attacker: {attacker.Driver}");
                attacker.DriveForward();
                attacker.UseWeapon();
            }
        }
    }
}
