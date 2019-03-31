using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.FifthTask
{
    public class FifthTaskModel
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public List<List<int>> Matrix { get; private set; }
        private Random random;

        private class Result {
            public int result { get; set; }
            public bool hasResult { get; set; }
        }

        public FifthTaskModel(int width, int height) {
            Width = width;
            Height = height;
            Matrix = new List<List<int>>();
            random = new Random();
        }

        public void Fill() {
            for (int i = 0; i < Height; i++) {
                var l = new List<int>();
                for (int j = 0; j < Width; j++) {
                    l.Add(random.Next(0,75)-50);
                }
                Matrix.Add(l);
            }      
        }

        public string Multiply()
        {
            int mul = 1;
            bool hasNegotive = false;
            bool hasOdd = false;
            foreach (var item in Matrix)
            {
                foreach (int i in item)
                {
                    if (i < 0)
                    {
                        hasNegotive = true;
                        if (i % 2 != 0)
                        {
                            mul *= i;
                            hasOdd = true;
                        }
                    }
                }
            }
            if (!hasNegotive) return "Нет отрицательных чисел";
            if (!hasOdd) return "Нет нечетных чисел";
            return mul.ToString();
        }


        // описание алгоритма на пальцах:
        // https://ru.coursera.org/lecture/algoritmizacija-vychislenij/diaghonali-v-priamoughol-noi-matritsie-dsNLO
        // упрощено и адаптировано под c#
        public string AbsBySum()
        {
            int k = (Height < Width) ? Height : Width;
            bool hasMulOfFive = false;
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                if (Matrix[i][Width - i-1] % 5 == 0)
                {
                    sum += Matrix[i][Width - i - 1];
                    hasMulOfFive = true;
                }
            }
            return (!hasMulOfFive) ? "Кратных 5 на побочной диагонали нет"
                                   : Math.Abs(sum).ToString();
        }

        public string DiffSubstr()
        {
            if (Width == 4 && Height == 4)
            {
                Result firstRes = FindMulForThirdRow();
                Result secondRes = FindMulForFirstCell();
                if (!secondRes.hasResult) return "В 1 столбце нет отрицательных чисел";
                if (!firstRes.hasResult) return "В 3 строке нет нечетных чисел";
                return (firstRes.result - secondRes.result).ToString();
            }
            return "Матрица должна быть размером 4x4";
        }

        private Result FindMulForFirstCell() {
            Result result = new Result();
            result.result = 1;
            result.hasResult = false;
            for (int i = 0; i < Height; i++) {
                if (Matrix[i][0] < 0)
                {
                    result.result *= Matrix[i][0];
                    result.hasResult = true;
                }
            }
            return result;
        }

        private Result FindMulForThirdRow()
        {
            Result result = new Result();
            result.result = 1;
            result.hasResult = false;
            for (int i = 0; i < Width; i++)
            {
                if (Matrix[2][i]%2!=0)
                {
                    result.result *= Matrix[2][i];
                    result.hasResult = true;
                }
            }
            return result;
        }
    }
}
