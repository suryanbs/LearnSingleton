using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Logger
    {
        public static  int ObjectCounter=0;
        public static readonly object obj =new object();
        public static Logger? loggerInstance = null;
        public static Logger GetInstance
        {
            get
            {
                if(loggerInstance == null)
                {
                    lock (obj)
                    {
                        if (loggerInstance == null)
                            loggerInstance = new Logger();
                       
                    }
                }
                return loggerInstance;

            } 
        }
        private Logger()
        {
            ObjectCounter++;
        }
      
        public void PrintMyLogs(string logMessage)
        {
            Console.WriteLine("This is my message"+logMessage+" :"+ ObjectCounter);
        }
       
    }

    internal class Water
    {
        public Water()
        {

        }
        internal void PrintWater()
        {
            Logger.GetInstance.PrintMyLogs("I am water.");
        }
    }
    internal class Air
    {
        public Air()
        {

        }
        internal void PrintAir()
        {
            Logger.GetInstance.PrintMyLogs("I am Air.");
        }
    }
}
