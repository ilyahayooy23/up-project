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
    
    public partial class Page2 : Page
    {
        BrandsTableAdapter Brands = new BrandsTableAdapter();
        public Page2()
        {
            InitializeComponent();
            DataGrid.ItemsSource = Brands.GetData();

        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {


            Brands.InsertQueryBrands(NameTbx.Text);
            DataGrid.ItemsSource = Brands.GetData();
            NameTbx.Text = null;

        }
    }
}
