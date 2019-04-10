using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.FourthTask
{
    public class FourthTaskModel
    {
        public int ArrSize { get; private set; }
        public Random random { get; private set; }
        public List<int> Array { get; set; }

        public FourthTaskModel(int arrSize) {
            ArrSize = arrSize;
            random = new Random();
            Array = new List<int>();
        }

        public void Fill() {
            for (int i = 0; i <= ArrSize; i++)
                Array.Add(random.Next(0, 120) - 50);
        }

        public string ArrToString() {
            string arr = "";
            foreach (int i in Array)
                arr += i.ToString() + " ";
            return arr;
        }

        private int GetMin() {
            int min = Array.Min();
            return min;
        }

        private int GetMax() {
            int max = Array.Max();
            return max;
        }

        public string GetAvgFromMinAndMax() {
            int min = GetMin();
            int max = GetMax();
            List<int> minMax = new List<int> { min, max };
            var avg = minMax.Average();
            return avg.ToString();
        }

        public string GetMinFromAbs() {
            int min = Math.Abs(Array.First());
            foreach (int i in Array)
            {
                int itemAbs = Math.Abs(i);
                if (itemAbs < min) min = itemAbs;
            }
            return min.ToString();
        }

        public string GetSum() {
            bool hasInPeriod = false; 
            int sum = 0;
            foreach (int i in Array)
            {
                if (i >= 0 && i <= 10)
                {
                    sum += i;
                    hasInPeriod = true;
                }
            }
            return (!hasInPeriod) ? "Нет чисел от 0 до 10"
                                  :  sum.ToString();
        }
    }
}
