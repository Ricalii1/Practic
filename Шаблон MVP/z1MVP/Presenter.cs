using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1MVP
{
    class Presenter
    {
        private Model model = null;
        private MainWindow mainWin = null;

        public Presenter(MainWindow MainWin)
        {
            this.mainWin = MainWin;
            this.model = new Model();

            this.mainWin.StartEvent += new EventHandler(mainWin_StartEvent);
            this.mainWin.StopEvent += new EventHandler(mainWin_StopEvent);
            this.mainWin.ResetEvent += new EventHandler(mainWin_ResetEvent);

            model.dispatcherTimer.Tick += timer_Tick;

        }

        void mainWin_StartEvent(object sender, System.EventArgs e)
        {
            model.StartTimer();
        }

        void mainWin_StopEvent(object sender, System.EventArgs e)
        {
            model.StopTimer();
        }

        void mainWin_ResetEvent(object sender, System.EventArgs e)
        {
            model.ResetTimer();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            mainWin.tb1.Text = model.nowTime;
        }
    }
}
