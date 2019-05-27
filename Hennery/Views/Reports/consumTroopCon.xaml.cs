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
    /// Interaction logic for TroopInfoCon.xaml
    /// </summary>
    public partial class consumTroopCon : UserControl
    {
        HenneryDb Context = new HenneryDb();
        private int? id , id1;
        private bool test= false;
        public consumTroopCon()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var query = Context.select_daeth_troop();
            DgvTroopInfo.ItemsSource = query;
        }
        private void TroopProduce_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonShow_OnClick(object sender, RoutedEventArgs e)
        {
            if (test == false)
            {
                DgvTroopConsums.ItemsSource = null;
                select_daeth_troop_Result classObj = DgvTroopInfo.SelectedItem as select_daeth_troop_Result;
                id = classObj.TroopNum;
                var query1 = Context.selectTroopCunsums(id);
                DgvTroopConsums.ItemsSource = query1;
           
            }
            else
            {
                DgvTroopConsums.ItemsSource = null;
                select_Current_troop_Result classObj = DgvTroopInfo.SelectedItem as select_Current_troop_Result;
                id = classObj.TroopNum;
                var query1 = Context.selectTroopCunsums(id);
                DgvTroopConsums.ItemsSource = query1;
               
            }
        }

        private void BtnCunsum_OnClick(object sender, RoutedEventArgs e)
        {
            DgvTroopConsumItems.ItemsSource = null;
            selectTroopCunsums_Result classObj = DgvTroopConsums.SelectedItem as selectTroopCunsums_Result;
             id1 = classObj.ConsumId;
            var query1 = Context.select_troopConsumItems(id,id1);
            DgvTroopConsumItems.ItemsSource = query1;
        }

        private void ToggleButton_OnChecked(object sender, RoutedEventArgs e)
        {
         
           
        }

        private void ToggleButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (test == false)
            {
                DgvTroopInfo.ItemsSource = null;
                var query = Context.select_Current_troop();

                DgvTroopInfo.ItemsSource = query;
                test = true;

            }
            else
            {
                DgvTroopInfo.ItemsSource = null;
                var query = Context.select_daeth_troop();

                DgvTroopInfo.ItemsSource = query;
                test = false;

            }
        }
    }
}
