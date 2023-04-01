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
using System.Windows.Shapes;

namespace BikeShowRoom
{
    /// <summary>
    /// Interaction logic for Bikes.xaml
    /// </summary>
    public partial class Bikes : Window
    {
        public Bikes()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m3 = new MainWindow();
            m3.Show();
            Close();
        }

       
       
    }
}
