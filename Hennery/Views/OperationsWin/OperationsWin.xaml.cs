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

namespace Hennery.Views.OperationsWin
{
    /// <summary>
    /// Interaction logic for OperationsWin.xaml
    /// </summary>
    public partial class OperationsWin : Window
    {
        private ConsumptionCon consumptionCon;
        private MixturesCon MixturesCon;
        private SupplyingCon SupplyingCon;
        public OperationsWin()
        {
            InitializeComponent();
            SupplyingCon = new SupplyingCon();
            MyGrid.Children.Add(SupplyingCon);
        }


        private void LabelConsumption_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            consumptionCon = new ConsumptionCon();
            MyGrid.Children.Add(consumptionCon);
        }

        private void LableMixing_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MixturesCon = new MixturesCon();
            MyGrid.Children.Add(MixturesCon);
        }

        private void LabelSupplying_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SupplyingCon=new SupplyingCon();
            MyGrid.Children.Add(SupplyingCon);
        }
    }
}
