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

namespace WpfApplication2.FirstTask
{
    /// <summary>
    /// Логика взаимодействия для FirstTask.xaml
    /// </summary>
    public partial class FirstTask : Window
    {
        public FirstTask()
        {
            InitializeComponent();
        }

        private void ResultBtn_Click(object sender, RoutedEventArgs e)
        {
            FirstTaskModel valueObject = new FirstTaskModel();
            try
            {
                valueObject.xValue = Convert.ToDouble(xValue.Text);
                valueObject.aValue = Convert.ToDouble(aValue.Text);
                Result.Text = valueObject.function.Invoke().ToString();
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка! \n"+ex.Message+"\n Проверьте вводимые данные", "Exception",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
