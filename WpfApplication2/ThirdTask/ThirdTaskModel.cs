using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using LiveCharts;
using LiveCharts.Defaults;

namespace WpfApplication2.ThirdTask
{
    public class ThirdTaskModel
    {
        public double xValue { get; set; }
        public double aValue { get; set; }
        public double Step { get; set; }
        public double Start { get; set; }
        public double End { get; set; }


        private double f(double x) 
            => Math.Pow(Math.E, -2*x)+Math.Pow(2*Math.Pow(x,4)+2*Math.Pow(x,2)+1,1/7);

        public ChartValues<ObservablePoint> GetPoints() {
            var points = new ChartValues<ObservablePoint>();
            for (double x=Start; x <= End; x += Step) {
                points.Add(new ObservablePoint(x, Math.Round(f(x),2)));
            }
            return points;
        }
    }
}
