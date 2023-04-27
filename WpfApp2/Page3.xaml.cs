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
using WpfApp2.testDataSet1TableAdapters;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        AccessoryBrandsTableAdapter AccessoryBrands = new AccessoryBrandsTableAdapter();
        public Page3()
        {
            InitializeComponent();
            DataGrid.ItemsSource = AccessoryBrands.GetData();
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {

            AccessoryBrands.InsertQueryAccessoryBrands(NameTbx.Text);
            DataGrid.ItemsSource = AccessoryBrands.GetData();
            NameTbx.Text = null;
        }
    }
}
