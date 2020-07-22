using System;
using System.Linq;
using System.Collections.Generic;

namespace TruthTable
{
    public class CreateTable
    {
        public void CreateTruthTable(int amountInput)
        {
            var inputsPossible = new List<string>
            {
                "T",
                "F"
            };

            // 3
            var generateInput = Enumerable.Repeat(inputsPossible, amountInput).ToList();
            var totalInput = new List<List<string>>();

            for (int i = 0; i < 2; i++)
            {
                var input1 = generateInput[0][i];
                for (int j = 0; j < 2; j++)
                {
                    var input2 = generateInput[1][j];
                    for (int k = 0; k < 2; k++)
                    {
                        var input3 = generateInput[2][k];
                        var final = new List<string>
                        {
                            input1,
                            input2,
                            input3
                        };

                        totalInput.Add(final);
                    }
                }
            }

            //2
            var totalInput2 = new List<List<string>>();
            var g2 = Enumerable.Repeat(inputsPossible, 2).ToList();
            for (int i = 0; i < 2; i++)
            {
                var input1 = g2[0][i];
                for (int j = 0; j < 2; j++)
                {
                    var input2 = g2[1][j];
                    var final = new List<string>
                        {
                            input1,
                            input2
                        };
                    totalInput2.Add(final);
                }
            }
        }

        public void GenerateTable(List<List<string>> inputPossible,int amountInput)
        {
            for (int i = 0; i < 2; i++)
            {
                var input = inputPossible[amountInput][];
            }
        }
    }

}
