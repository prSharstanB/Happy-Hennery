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
    /// Interaction logic for MachineCon.xaml
    /// </summary>
    public partial class MachineCon : UserControl
    {
        HenneryDb Context = new HenneryDb();
        public MachineCon()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var query = Context.select_all_stores();
            ComStoreName.ItemsSource = query;
           
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

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
