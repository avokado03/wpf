using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.SecondTask
{
    public class SecondTaskModel
    {
        public double xValue { get; set; }
        public double aValue { get; set; }
        public double Step { get; set; }
        public Func<double,double> function
        {
            get
            {
                if (xValue <= 0) return f1;
                if (xValue > 0 && xValue <= aValue) return f2;
                if (xValue > aValue) return f3;
                return function;
            }
        }

        private double f1(double xValue) => Math.Pow(xValue,3)+4*Math.Pow(xValue,2);
        private double f2(double xValue) => Math.Pow(xValue-1, 3)+Math.Cos(Math.Pow(xValue,3));
        private double f3(double xValue) => Math.Sqrt(Math.Pow(Math.Abs(xValue),3))*Math.Sqrt(Math.Pow(xValue,3));
    }
}
