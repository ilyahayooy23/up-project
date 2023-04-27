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

namespace WpfApp2
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Table1Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page1();
        }


        private void Table2Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page2();
        }

        private void Table3Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page3();
        }
    }
}
