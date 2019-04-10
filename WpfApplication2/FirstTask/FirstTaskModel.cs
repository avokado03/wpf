using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.FirstTask
{
    public class FirstTaskModel
    {
        public double xValue { get; set; }
        public double aValue { get; set; }
        public Func<double> function
        {
            get {
                if (xValue <= 0) return f1;
                if (xValue > 0 && xValue <= aValue) return f2;
                if (xValue > aValue) return f3;
                return function;
            }
        }

        private double f1() => Math.Pow((Math.Pow(xValue, 2) + xValue + 1), 0.2);
        private double f2() => Math.Pow(Math.Log(Math.Abs(Math.Sqrt(xValue + 5))), 2);
        private double f3() => Math.Sin(Math.Pow(xValue, 2)) + Math.Pow(xValue, 0.25);
    }
}
