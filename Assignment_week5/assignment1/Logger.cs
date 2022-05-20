using System;
namespace assignment1
{
    public class Logger
    {
        private static int numberOfLines;
        private static Logger uniqueInstance;

        private Logger()
        {
            numberOfLines = 0;
        }

        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Logger();
            //else
            //    numberOfLines++;
            return uniqueInstance;
        }

        public void Log(string place,string process)
        {
            numberOfLines++;
            Console.WriteLine($"{numberOfLines} - [{place}] {process}");
        }
    }
}
