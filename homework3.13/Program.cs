using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HomeWork3._13
{

    using System;
    using System.Timers;

    class Program
    {
        private static Timer timer;
        private static DateTime alarmTime;

        static void Main(string[] args)
        {
            Console.WriteLine("Alarm Clock Program");
            GetAlarmInput();

            SetupTimer();

           
            while (true)
            {
                
            }
        }

        private static void SetupTimer()
        {
            timer = new Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Start();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"Current Time: {DateTime.Now:HH:mm:ss}"); 
            if (DateTime.Now.Hour == alarmTime.Hour &&
                DateTime.Now.Minute == alarmTime.Minute &&
                DateTime.Now.Second == alarmTime.Second) 
            {
                TriggerAlarm(); 
                GetAlarmInput();
            }
        }

        private static void GetAlarmInput()
        {
            Console.Write("Enter alarm time (HH:mm:ss): ");
            string input = Console.ReadLine();
            alarmTime = DateTime.Today + DateTime.Parse(input).TimeOfDay; 
            Console.WriteLine($"Alarm set for {alarmTime:HH:mm:ss}.");
        }

        private static void TriggerAlarm()
        {
            Console.WriteLine("Alarm! Time's up!");
            Console.WriteLine("Please set a new alarm time.");
        }
    }
}