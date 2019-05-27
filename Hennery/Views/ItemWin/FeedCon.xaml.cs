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

namespace Hennery.Views.OperationsWin
{
    /// <summary>
    /// Interaction logic for FeedCon.xaml
    /// </summary>
    public partial class FeedCon : UserControl
    {

        HenneryDb Context = new HenneryDb();
        public FeedCon()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var query = Context.select_all_items();
            ComItemType.ItemsSource = query;
            var query2 = Context.select_all_stores();
            ComStoreName.ItemsSource = query2;
        }
        private void ButtonShow_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonDelete_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
