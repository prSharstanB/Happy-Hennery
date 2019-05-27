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

namespace Hennery.Views.ItemWin
{
    /// <summary>
    /// Interaction logic for ProductCon.xaml
    /// </summary>
    public partial class ProductCon : UserControl
    {
        HenneryDb Context  =new HenneryDb();
        public ProductCon()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var quary = Context.select_all_stores();
            ComStoreName.ItemsSource = quary;
            var query1 = Context.select_all_items();
            ComItemType.ItemsSource = query1;
            var query2 = Context.select_all_troop();
            TroopNum.ItemsSource = query2;

        }
        private void ButtonShow_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {
           
        }

        private void ButtonDelete_OnClick(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
