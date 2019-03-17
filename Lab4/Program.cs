using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using log4net;

namespace Lab4
{

    class Program
    {
        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static Hashtable dataTable=new Hashtable();
        




        static void Main(string[] args)
        {
           
            ImplementLoggingFuntion();
            dataTable.Add("ravivos21", "12345");
            dataTable.Add("shiraS", "22224");
            dataTable.Add("sharonM", "11111");

        }

        private static void ImplementLoggingFuntion()
        {
            /* We have 5 levels of log message. Let's test all.
             *  FATAL
                ERROR
                WARN
                INFO
                DEBUG
             */
            var secs = 3;
            Log.Fatal("Start log FATAL...");
            Console.WriteLine("Start log FATAL...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Error("Start log ERROR...");
            Console.WriteLine("Start log ERROR...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Warn("Start log WARN...");
            Console.WriteLine("Start log WARN...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Info("Start log INFO...");
            Console.WriteLine("Start log INFO...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Debug("Start log DEBUG...");
            Console.WriteLine("Start log DEBUG...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Console.WriteLine("Press any key to close the application");
            Console.ReadKey();
        }
        public static void login3Attempts()
        {
            int wrongInput=0;
            Boolean goodCombo = false;
            {
                while (wrongInput <= 2 & !goodCombo )
                    Console.WriteLine("enter a username");
                String userid = Console.ReadLine();
                Console.WriteLine("enter a password");
                String password = Console.ReadLine();
                if (userid.Equals("Ravivos21") & password.Equals("12345"))
                    goodCombo = true;
                if (!goodCombo)
                    wrongInput++;

            }
            if (!goodCombo)
                Console.WriteLine("not good combo");
            else
                Console.WriteLine("Hi Raviv");

        }



    }
}
