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

namespace WpfApplication2.SecondTask
{
    /// <summary>
    /// Логика взаимодействия для SecondTask.xaml
    /// </summary>
    public partial class SecondTask : Window
    {
        public SecondTask()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SecondTaskModel model = new SecondTaskModel();
            try
            {
                model.xValue = Convert.ToDouble(xValue.Text);
                model.aValue = Convert.ToDouble(aValue.Text);
                model.Step = Convert.ToDouble(xbValue.Text);
                result.Text = model.function.Invoke(model.xValue).ToString();
                Extremus extr = new Extremus(model);
                extremum.Text = extr.GetExstremus();
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка! \n" + ex.Message + "\n Проверьте вводимые данные", "Exception", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
