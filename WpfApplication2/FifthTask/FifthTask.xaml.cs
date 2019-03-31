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

namespace WpfApplication2.FifthTask
{
    /// <summary>
    /// Логика взаимодействия для FifthTask.xaml
    /// </summary>
    public partial class FifthTask : Window
    {
        private FifthTaskModel model;
        public FifthTask()
        {
            InitializeComponent();
        }



        private void GenerateBtn_Click(object sender, RoutedEventArgs e)
        {
            list.Children.Clear();
            int w, h;
            try
            {
                w = Convert.ToInt32(cells.Text);
                h = Convert.ToInt32(rows.Text);
                model = new FifthTaskModel(w, h);
                model.Fill();
                list.Columns = model.Width;
                list.Rows = model.Height;
                for (int i = 0; i < model.Height; i++)
                {
                    for (int j = 0; j < model.Width; j++)
                    {
                        Button b = new Button();
                        b.IsEnabled = false;
                        b.Content = model.Matrix[i][j].ToString();
                        list.Children.Add(b);
                    }
                }
                multiplyOdd.Text = model.Multiply();
                abs.Text = model.AbsBySum();
                substr.Text = model.DiffSubstr();                     
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! \n" + ex.Message + "\n Проверьте вводимые данные", "Exception", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
