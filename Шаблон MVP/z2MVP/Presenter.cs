using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace z2MVP
{
    class Presenter
    {
        private readonly Model model;
        private readonly MainWindow view;

        public Presenter(MainWindow v)
        {
            model = new Model();
            view = v;
            view.Equal += view_Equal;
        }

        void view_Equal(object sender, EventArgs e)
        {
            try
            {
                model.label1 = Convert.ToString(view.label1.Content);

                int a = Convert.ToInt32(view.tb1.Text);
                int b = Convert.ToInt32(view.tb2.Text);
                view.tb3.Text = model.Equal(a, b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
