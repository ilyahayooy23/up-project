using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
using WpfApp2.testDataSet1TableAdapters;

namespace WpfApp2
{
    
    public partial class Page1 : Page
    {
        AccessoriesTableAdapter Accessories = new AccessoriesTableAdapter();
        public Page1()
        {
            InitializeComponent();
            DataGrid.ItemsSource = Accessories.GetData();
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            string[] text = NameTbx.Text.Split(' ');
            Accessories.InsertQueryAccessories(text[0], text[1], Convert.ToInt32(text[2]));
            DataGrid.ItemsSource = Accessories.GetData();
            NameTbx.Text = null;
        }
    }
}
