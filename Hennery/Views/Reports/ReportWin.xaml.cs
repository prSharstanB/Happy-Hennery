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

namespace Hennery.Views.Reports
{
    /// <summary>
    /// Interaction logic for ReportWin.xaml
    /// </summary>
    public partial class ReportWin : Window
    {
        private InedibleCon InedibleCon;
        private consumTroopCon TroopInfoCon;
        private EmptyHengars EmptyHengars;
        private ItemsCon ItemsCon;
        private CurrentItemsQuantityCon CurrentItemsQuantityCon;
        private ItemsQuantity ItemsQuantity;
        public ReportWin()
        {
            InitializeComponent();
            TroopInfoCon = new consumTroopCon();
            MyGrid.Children.Add(TroopInfoCon);
        }
       
       
        private void InedibleLable_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            InedibleCon = new InedibleCon();
            MyGrid.Children.Add(InedibleCon);
        }

       

        private void LabTroopInfo_OnPreviewMouseLeftButtonDown_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           TroopInfoCon = new consumTroopCon();
            MyGrid.Children.Add(TroopInfoCon);
        }

        private void LabEmptyHengar_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           EmptyHengars = new EmptyHengars();
            MyGrid.Children.Add(EmptyHengars);
        }

       

        private void DailyTroopConsum_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void LebcurrentItemQuantity_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CurrentItemsQuantityCon= new CurrentItemsQuantityCon();
            MyGrid.Children.Add(CurrentItemsQuantityCon);
        }

        private void BtnItemQuantity_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ItemsQuantity = new ItemsQuantity();
            MyGrid.Children.Add(ItemsQuantity);
        }

        private void BtnHealthy_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           ItemsCon = new ItemsCon();
            MyGrid.Children.Add(ItemsCon);
        }
    }
}
