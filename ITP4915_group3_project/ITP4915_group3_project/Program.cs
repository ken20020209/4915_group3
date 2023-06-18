using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Timer = System.Threading.Timer;

namespace ITP4915_group3_project
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // batch process on spcecific time

            TimeSpan interval = TimeSpan.FromMinutes(1); // Check every minute
/*            interval = TimeSpan.FromSeconds(1);*/
            Timer timer = new Timer(CheckSchedule, null, TimeSpan.Zero, interval);

            //goto login page

            Form login = new General.login.Login();
            /*Application.Run(new test());*/
            Application.Run(login);

            /*Application.Run(new Restaurant.stock.detail("0","0"));*/
            timer.Dispose();

        }

        private static void CheckSchedule(object state)
        {

            List<DateTime> scheduledTimes = new List<DateTime>
            {
                Properties.Settings.Default.matchTime1,  // First scheduled time
                Properties.Settings.Default.matchTime2, // Second scheduled time
                Properties.Settings.Default.matchTime3,  // Third scheduled time
            };
            DateTime now = DateTime.Now;
            foreach (DateTime scheduledTime in scheduledTimes)
            {
                if (now.Hour >= scheduledTime.Hour && now.Hour <= scheduledTime.Hour && now.Minute >= scheduledTime.Minute && now.Minute <= scheduledTime.AddMinutes(1).Minute)
                {
#if DEBUG
                    Console.WriteLine("excute batch process");
#endif
                    // Call method to do the work here
                    batchProcessing.requestMatch requestMatch = new batchProcessing.requestMatch();


                    /*requestMatch.process();*/

                }
            }
        }
    }
}
