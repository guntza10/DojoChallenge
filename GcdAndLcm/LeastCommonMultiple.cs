using System;
using System.Linq;
using System.Collections.Generic;

namespace GcdAndLcm
{
    public class LeastCommonMultiple
    {
        public int input1 { get; set; }
        public int input2 { get; set; }

        public int FindLeastCommonMultiple()
        {
            var listMultiple1 = FindListMultiplied(input1);
            var listMultiple2 = FindListMultiplied(input2);
            var listBothMultiplied = listMultiple1.Intersect(listMultiple2);
            var LCM = listBothMultiplied.Any() ? listBothMultiplied.Min() : input1 * input2;
            return LCM;
        }

        private List<int> FindListMultiplied(int value)
        {
            var listMultiplied = new List<int>();

            for (int i = 1; i <= value; i++)
            {
                listMultiplied.Add(value * i);
            }

            return listMultiplied;
        }
    }
}