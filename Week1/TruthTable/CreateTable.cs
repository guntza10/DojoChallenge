using System;
using System.Linq;
using System.Collections.Generic;

namespace TruthTable
{
    public class CreateTable
    {
        public List<List<string>> CreateTruthTable(int amountInput)
        {
            var listInput = new List<string>();
            for (int i = 0; i < Math.Pow(2, amountInput); i++)
            {
                var binary = Convert.ToString(i, 2).PadLeft(amountInput, '0');
                listInput.Add(binary);
            }

            var result = listInput.Select(it =>
            {
                var resultBool = ConvertBinaryToBoolean(it).Select(it => it.ToString()).ToList();
                return resultBool;
            }).ToList();

            return result;
        }

        public string ConvertBinaryToBoolean(string binary)
        {
            var convert1 = binary.Replace('0', 'F');
            var convert2 = convert1.Replace('1', 'T');
            return convert2;
        }
    }
}
