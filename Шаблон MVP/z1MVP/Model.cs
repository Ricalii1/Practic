using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace z1MVP
{
    class Model
    {
        public DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public Stopwatch stopWatch = new Stopwatch();
        public string nowTime = string.Empty;

        public Model()
        {
            dispatcherTimer.Tick += new EventHandler(Timer);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
        }

        public void Timer(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                TimeSpan ts = stopWatch.Elapsed;
                nowTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            }
        }

        public void StartTimer()
        {
            stopWatch.Start();
            dispatcherTimer.Start();
        }

        public void StopTimer()
        {
            if (stopWatch.IsRunning)
            {
                stopWatch.Stop();
            }
        }

        public void ResetTimer()
        {
            stopWatch.Reset();
            nowTime = "00:00:00";
        }
    }
}
