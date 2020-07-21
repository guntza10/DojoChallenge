using System;
using System.Collections.Generic;
using System.Linq;

namespace GcdAndLcm
{
    public class GreaterCommonDivisor
    {
        public int input1 { get; set; }
        public int input2 { get; set; }

        public int FindGreaterCommonDivisor()
        {
            var listDevided1 = FindListDivided(input1);
            var listDevided2 = FindListDivided(input2);
            var listBothDevided = listDevided1.Intersect(listDevided2);
            var GDC = listBothDevided.Max();
            return GDC;
        }

        private List<int> FindListDivided(int value)
        {
            var listDevide = new List<int>();
            for (int i = 1; i <= value; i++)
            {
                if (Divided(value, i)) listDevide.Add(i);
            }
            return listDevide;
        }

        private bool Divided(int value1, int value2)
        {
            return value1 % value2 == 0;
        }
    }
}