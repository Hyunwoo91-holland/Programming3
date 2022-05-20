using System;
namespace assignment1
{
    public class Logger
    {
        private static int numberOfLines;
        private static Logger uniqueInstance;

        private Logger()
        {
            numberOfLines = 1;
        }

        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Logger();
            else
                numberOfLines++;
            return uniqueInstance;
        }

        public void Log(string place,string process)
        {
            Console.WriteLine($"{numberOfLines} - [{place}] {process}");
        }
    }
}
