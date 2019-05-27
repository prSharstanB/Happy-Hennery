using LiveCharts;
using LiveCharts.Wpf;
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
    /// Interaction logic for ItemsCon.xaml
    /// </summary>
    public partial class ItemsCon : UserControl
    {
        HenneryDb Context = new HenneryDb();
        public ItemsCon()
        {
            InitializeComponent();


            SeriesCollection = new SeriesCollection
            {
               
                new LineSeries
                {
                    Title = "معدل الانتاج",
                    Values = new ChartValues<double> {1 ,8,3,12,11,2,7,8,9,10,5,4 },
                    PointGeometry = null
                },
                
            };
            Labels = new[] { "كانون الثاني", "شباط", "آذار", "نيسان", "ايار",
                "حزيران",
                "تموز",
                "أب",
                "أيلول",
                "تشرين الاول",
                "تشرين الثاني",
                "كانون الاول" };
           
         

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

    }

    
}
