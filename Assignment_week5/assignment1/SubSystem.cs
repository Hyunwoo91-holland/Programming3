namespace assignment1
{
    public class SubSystem
    {
        private Logger logger;

        public SubSystem()
        {
            logger = Logger.GetInstance();
            DoSomeWork();
            DoSomeMoreWork();
        }

        private void DoSomeWork()
        {
            logger.Log("SubSystem", "doing some work");
        }

        private void DoSomeMoreWork()
        {
            logger.Log("SubSystem", "doing some more work");
        }
    }
}
