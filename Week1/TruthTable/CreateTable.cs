using System;
using System.Linq;
using System.Collections.Generic;

namespace TruthTable
{
    public class CreateTable
    {
        public void CreateTruthTable(int amountInput, string operation)
        {
            var inputsPossible = new List<string>
            {
                "T",
                "F"
            };

            var listInput = new List<List<string>>();
            inputsPossible.ForEach(it =>
            {
                for (int i = 0; i <= amountInput; i++)
                {
                    if (i == 0)
                    {
                        var listsameInput = new List<string>();
                        var sameInput = Enumerable.Repeat(it, amountInput).ToList();
                        sameInput.ForEach(inp =>
                        {
                            listsameInput.Add(inp);
                        });
                        listInput.Add(listsameInput);
                    }
                    else
                    {
                        var listInputPossible = new List<string>();
                        var repeatInput = Enumerable.Repeat(it, amountInput).ToList();
                        repeatInput.ForEach(inp =>
                        {
                            listInputPossible.Add(inp);
                        });
                    }

                }
            });
        }

        public List<string> Rearrange(List<string> list, int amount)
        {
            var listKeeper = list;
            var keeper = listKeeper[0];
            for (int i = 0; i < amount - 1; i++)
            {
                for (int j = 0; j < amount; j++)
                {
                    listKeeper[j] = (j == amount - 1) ? list[i] : list[j + 1];
                }
            }
            return new List<string>();
        }
    }

}

//  0
//                     var input2 = inputsPossible[j];
//                     listInput.Add(input2);
//                     var truthTableOp = new TruthTableOperation(operation, listInput);
//                     var result = truthTableOp.Result;
//                     Console.WriteLine($"{input1}\t{input2}\t=>\t{result}");