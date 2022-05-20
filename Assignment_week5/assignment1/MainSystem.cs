namespace assignment1
{
    public class MainSystem
    {
        private SubSystem subSystem;
        private Logger logger;

        public MainSystem()
        {
            logger = Logger.GetInstance();
            DoSomeMainWork();
        }

        private void DoSomeMainWork()
        {
            logger.Log("MainSystem", "doing some main work");
            subSystem = new SubSystem();
        }
    }
}
