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

namespace WpfApplication2.FourthTask
{
    /// <summary>
    /// Логика взаимодействия для FourthTask.xaml
    /// </summary>
    public partial class FourthTask : Window
    {
        private FourthTaskModel model;
        public FourthTask()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, RoutedEventArgs e)
        {
            int size;
            try
            {
                size = Convert.ToInt32(arraySize.Text);
                model = new FourthTaskModel(size);
                model.Fill();
                array.Text = model.ArrToString();
                minMaxAverage.Text = model.GetAvgFromMinAndMax();
                minAbs.Text = model.GetMinFromAbs();
                intervalSum.Text = model.GetSum();
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка! \n" + ex.Message + "\n Проверьте вводимые данные", "Exception", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
