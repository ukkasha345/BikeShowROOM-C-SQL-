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
    /// Interaction logic for Branches.xaml
    /// </summary>
    public partial class Branches : Window
    {
        public Branches()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m1 = new MainWindow();
            m1.Show();
            Close();
        }
    }
}
