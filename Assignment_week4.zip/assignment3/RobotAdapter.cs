namespace assignment3
{
    class RobotAdapter : IAttacker
    {
        public string Driver { get { return robot.Person; } set { robot.Person = value; } }
        public Robot robot;

        public RobotAdapter(Robot robot)
        {
            this.robot = robot;
        }

        void IAttacker.AssignDriver(string person)
        {
            robot.MoveByPerson(person);
        }

        void IAttacker.DriveForward()
        {
            robot.WalkForward();
        }

        void IAttacker.UseWeapon()
        {
            robot.BashWithHands();
        }
    }
}
