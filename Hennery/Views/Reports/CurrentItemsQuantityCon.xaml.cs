using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for CurrentItemsQuantityCon.xaml
    /// </summary>
    public partial class CurrentItemsQuantityCon : UserControl
    {
        HenneryDb  Context= new HenneryDb();
        public CurrentItemsQuantityCon()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var query = Context.select_StoreInfo();
            DgvStoreInfo.ItemsSource = query;
        }
    
        
        private void ButtonShow_OnClick(object sender, RoutedEventArgs e)
        {
            DgvItemStore.ItemsSource = null;
            select_StoreInfo_Result classObj = DgvStoreInfo.SelectedItem as select_StoreInfo_Result;
            int id = classObj.ID_store;
            
            var query1 = Context.select_StoreItems(id);
            DgvItemStore.ItemsSource = query1;

        }

      
    }
}
