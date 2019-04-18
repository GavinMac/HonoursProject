using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

//////////////////////
// Gavin Macleod    //
//////////////////////
// S1715408         //
// Honours Project  //
// BSc Computing    //
//////////////////////
namespace Prototype1
{
    /// <summary>
    /// This class allows any method created in it to be run once, then wait 5 seconds before it can be run again.
    /// </summary>
    class RunOnce
    {
        private static Timer timer;
        private static bool hasBeenCalled = false;

        public RunOnce()
        {
            hasBeenCalled = false;
        }

        /// <summary>
        /// Checks the volume that is input and adds to player scores based on loudness
        /// </summary>
        /// <param name="player"></param>
        /// <param name="volume"></param>
        public static void CheckVolumesOnce(Player player, float volume)
        {
            //Checks if hasBeenCalled is false, if it is, the function can run
            if (hasBeenCalled == false)
            {
                Console.WriteLine("CheckVolumeOnce started");
                if (volume >= 50)
                {
                    player.ShoutScore = player.ShoutScore + 2;
                    player.QuietScore = player.QuietScore - 1;
                }
                else if (volume >= 5 && volume < 50)
                {
                    player.QuietScore = player.QuietScore + 2;
                    player.ShoutScore = player.ShoutScore - 2;
                }

                hasBeenCalled = true;
                timer.Start();
            }         
        }

        /// <summary>
        /// Timer waits for 5 seconds then executes timer_tick()
        /// </summary>
        public static void SetTimer()
        {
            timer = new Timer(5000);
            timer.Elapsed += timer_Tick;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        /// <summary>
        /// Sets hasBeenCalled to true and stops the timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void timer_Tick(object sender, EventArgs e)
        {
            hasBeenCalled = false;
            timer.Stop();
        }

    }
}
