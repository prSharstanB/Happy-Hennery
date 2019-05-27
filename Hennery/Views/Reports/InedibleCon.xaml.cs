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

namespace Hennery.Views.Reports
{
    /// <summary>
    /// Interaction logic for InedibleCon.xaml
    /// </summary>
    public partial class InedibleCon : UserControl
    {
        HenneryDb Context = new HenneryDb();
        public InedibleCon()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var query = Context.select_all_stores();
            ComStoreName.ItemsSource = query;
            var query1 = Context.select_expiration_date_of_item();
            DgvIndibleItems.ItemsSource = query1;
        }
        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {
           
        }

        private void ButtonShow_OnClick(object sender, RoutedEventArgs e)
        {
           
        }

        private void ButtonDelete_OnClick(object sender, RoutedEventArgs e)
        {
           
        }

       

        private void ToggleButton_OnChecked(object sender, RoutedEventArgs e)
        {
            DgvIndibleItems.ItemsSource = null;
            var query = Context.select_expiration_date_of_item();
            DgvIndibleItems.ItemsSource = query;
        }

        private void ComStoreName_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DgvIndibleItems.ItemsSource = null;
            var query = Context.select_expiration_date_of_item_forStore(Convert.ToInt32(ComStoreName.SelectedValue));
            DgvIndibleItems.ItemsSource = query;
        }
    }
}
