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
    /// Interaction logic for ItemsQuantity.xaml
    /// </summary>
    public partial class ItemsQuantity : UserControl
    {
        HenneryDb Context = new HenneryDb();
        public ItemsQuantity()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            var query = Context.select_itemQuantity();
            DgvItemQuantity.ItemsSource = query;

        }
    }
}
