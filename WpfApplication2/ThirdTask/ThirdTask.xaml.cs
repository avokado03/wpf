using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
            try
            {
                model.aValue = Convert.ToDouble(xValue.Text);
                model.xValue = Convert.ToDouble(aValue.Text);
                model.Step = Convert.ToDouble(xbValue.Text);
                model.Start = Convert.ToDouble(xnValue.Text);
                model.End = Convert.ToDouble(xhValue.Text);
                if (model.Start >= model.End)
                    throw new Exception("Указан неверный промежуток");
                var points = model.GetPoints();
                SeriesCollection = new SeriesCollection
                  {
                      new LineSeries
                      {
                          Title = "Y=",
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
