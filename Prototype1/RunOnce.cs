using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace Prototype1
{
    class RunOnce
    {
        private static Timer timer;
        private static bool hasBeenCalled = false;

        public RunOnce()
        {
            hasBeenCalled = false;
        }

        public static void CheckVolumesOnce(Player player, float volume)
        {
            
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

        public static void SetTimer()
        {
            timer = new Timer(5000);
            timer.Elapsed += timer_Tick;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private static void timer_Tick(object sender, EventArgs e)
        {
            hasBeenCalled = false;
            timer.Stop();
        }

    }
}
