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

namespace Hennery.Views.Stores
{
    /// <summary>
    /// Interaction logic for HengarCon.xaml
    /// </summary>
    public partial class HengarCon : UserControl
    {
        HenneryDb Context =new HenneryDb();
        private int IdEdit , f = 0;
        public HengarCon()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var query = Context.select_all_hengar();
        
            DgvHengarInfo.ItemsSource = query;
        }
        private void ButtonShow_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {
            f = 1;
          select_all_hengar_Result classObj = DgvHengarInfo.SelectedItem as select_all_hengar_Result;
            TxtHengarName.Text = classObj.hengar_name;
            TxtHengarArea.Text = classObj.hengar_space;
            ComHengarType.Text = classObj.kind;
            IdEdit = classObj.ID_hengar;
            BtnAdd.Content = "تعديل";
        }

        private void ButtonDelete_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("هل أنت متأكد من إجراء هذه العملية", "تنبيه ", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                select_all_hengar_Result classObj = DgvHengarInfo.SelectedItem as select_all_hengar_Result;
                int id = classObj.ID_hengar;
                Context.delete_hengar(id);
                LoadData();
            }
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            if (f == 0)
            {
                Context.insert_hengar(TxtHengarArea.Text, ComHengarType.Text, TxtHengarName.Text);
                LoadData();
            }
            else
            {
                Context.update_hengar(IdEdit, TxtHengarArea.Text, ComHengarType.Text, TxtHengarName.Text);
                LoadData();
                f = 0;
                BtnAdd.Content = "إضافة";

            }

            TxtHengarName.Text = " ";
            TxtHengarArea.Text = " ";
            ComHengarType.Text = " ";

        }
    }
}
