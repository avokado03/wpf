﻿using System;
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
            int min = Array.First();
            foreach (int i in Array)
                if (Math.Abs(i) < min) min = i;
            return min.ToString();
        }

        public string GetSum() {
            if (ArrSize >= 10)
            {
               int sum = 0;
               for (int i = 0; i <= 10; i++)
                    sum += Array[i];
                return sum.ToString();
            }
            return "Длина массива меньше 10";
        }
    }
}
