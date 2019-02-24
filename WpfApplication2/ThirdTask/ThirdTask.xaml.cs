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
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace WpfApplication2.ThirdTask
{
    /// <summary>
    /// Логика взаимодействия для ThirdTask.xaml
    /// </summary>
    public partial class ThirdTask : Window
    {
        public SeriesCollection SeriesCollection { get; set; }

        public ThirdTask()
        {
            InitializeComponent();
        }

        private void SetGraphBtn_Click(object sender, RoutedEventArgs e)
        {
            DataContext = null;
            ThirdTaskModel model = new ThirdTaskModel();
            double x,a,step;
            try
            {
                x = Convert.ToDouble(xValue.Text);
                a = Convert.ToDouble(aValue.Text);
                step = Convert.ToDouble(xbValue.Text);
                if (x >= a)
                    throw new Exception("Указан неверный промежуток, х<a");
                model.aValue = a;
                model.xValue = x;
                model.Step = step;
                var points = model.GetPoints();
                SeriesCollection = new SeriesCollection
                  {
                      new LineSeries
                      {
                          Title = "Грaфик функции",
                          Values = points
                      }
                  };
                DataContext = this;
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка! \n"+ex.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
