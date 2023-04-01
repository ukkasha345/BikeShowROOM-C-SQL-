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
using System.Timers;
using System.Windows.Threading;

namespace BikeShowRoom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer obj;
        public MainWindow()
        {
            InitializeComponent();
            obj = new DispatcherTimer();
            obj.Interval = new TimeSpan(0, 0, 0, 0, 10);
            obj.Tick += dtTicker;
                
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Branches b1 = new Branches();
            b1.Show();
            Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Employees e1 = new Employees();
            e1.Show();
            Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Bikes b1 = new Bikes();
            b1.Show();
            Close();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Buyers b1 = new Buyers();
            b1.Show();
            Close();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            PaymentType p1 = new PaymentType();
            p1.Show();
            Close();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Deliveries d1 = new Deliveries();
            d1.Show();
            Close();
        }


        private void dtTicker(object sender, EventArgs e)
        {
            bool hidden = true;
            if (hidden)
            {
                SCROLLER.Width += 1;
                if (SCROLLER.Width >= 500)
                {
                    obj.Stop();
                    hidden = false;
                }

            }
            else
            {
                SCROLLER.Width = SCROLLER.Width - 1;
                if (SCROLLER.Width <= 50)
                {
                    obj.Stop();
                    hidden = false;
                }
            }
        }

        private void Scroller_click(object sender, RoutedEventArgs e)
        {
            obj.Start();
        }

        
    }
}
