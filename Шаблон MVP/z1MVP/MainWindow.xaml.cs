using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace z1MVP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler StartEvent = null;
        public event EventHandler StopEvent = null;
        public event EventHandler ResetEvent = null;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StartEvent.Invoke(sender, e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StopEvent.Invoke(sender, e);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ResetEvent.Invoke(sender, e);
        }
    }
}
