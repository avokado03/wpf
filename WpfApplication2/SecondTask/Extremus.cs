
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.SecondTask
{
    public class Extremus
    {
        private SecondTaskModel model;
        private double PHI;

        public Extremus(SecondTaskModel model) {
            this.model = model;
            PHI = (1 + Math.Sqrt(5)) / 2;
        }

        private double GetMin(double a, double b) {
            double x1, x2;
            while (true)
            {
                x1 = b - (b - a) / PHI;
                x2 = a + (b - a) / PHI;
                if (model.function.Invoke(x1) >= model.function.Invoke(x2))
                    a = x1;
                else
                    b = x2;
                if (Math.Abs(b - a) < model.Step)
                    break;
            }
            return Math.Round((a + b) / 2, 3);
        }

        private double GetMax(double a, double b) {
            double x1, x2;
            while (true)
            {
                x1 = b - (b - a) / PHI;
                x2 = a + (b - a) / PHI;
                if (model.function.Invoke(x1) <= model.function.Invoke(x2))
                    a = x1;
                else
                    b = x2;
                if (Math.Abs(b - a) < model.Step)
                    break;
            }
            return Math.Round((a + b) / 2,3);
        }

        public string GetExstremus() {
            double a = model.Start;
            double b = model.End;
            return "Max = "+GetMax(a,b)+", min = "+GetMin(a,b);
        }
    }
}
