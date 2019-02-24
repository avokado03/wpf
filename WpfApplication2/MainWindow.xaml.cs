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

namespace WpfApplication2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FifthTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow(new FifthTask.FifthTask());
        }

        private void SecondTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow(new SecondTask.SecondTask());
        }

        private void FirstTaskBtn_Click(object sender, EventArgs e)
        {
            ShowWindow(new FirstTask.FirstTask());
        }

        private void FourthTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow(new FourthTask.FourthTask());
        }

        private void ThirdTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow(new ThirdTask.ThirdTask());
        }

        private void ShowWindow(Window window) {
            window.Owner = this;
            window.Show();
        }
    }
}
