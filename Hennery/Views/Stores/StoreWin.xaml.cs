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

namespace Hennery.Views.Stores
{
    /// <summary>
    /// Interaction logic for StoreWin.xaml
    /// </summary>
    public partial class StoreWin : Window
    {
        private StoreCon StoreCon;
        private HengarCon HengarCon;

        public StoreWin()
        {
            InitializeComponent();
            StoreCon = new StoreCon();
            MyGrid.Children.Add(StoreCon);
        }
        private void ButtonDelete_OnClick(object sender, RoutedEventArgs e)
        {
           
        }

        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {
           
        }

        private void ButtonShow_OnClick(object sender, RoutedEventArgs e)
        {
           
        }

        private void LabStore_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           StoreCon = new StoreCon();
            MyGrid.Children.Add(StoreCon);
        }

        private void LebHengar_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           HengarCon = new HengarCon();
            MyGrid.Children.Add(HengarCon);
        }
    }
}
