namespace assignment1
{
    class Program
    {
        private Logger logger;
        private MainSystem mainSystem;

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            logger = Logger.GetInstance();
            logger.Log("Program", "starting");
            mainSystem = new MainSystem();
            logger = Logger.GetInstance();
            logger.Log("Program", "finishing");

        }
    }
}
