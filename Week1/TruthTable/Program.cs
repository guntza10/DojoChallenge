using System;
using System.Collections.Generic;
using System.Text;

namespace TruthTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Truth Table");
            Console.Write("What Operation you use? : ");
            var operation = Console.ReadLine();
            Console.Write("How many input you want? : ");

            var amountInput = Console.ReadLine();
            var amount = Convert.ToInt32(amountInput);

            var createTable = new CreateTable();
            var table = createTable.CreateTruthTable(amount);

            var count = 0;
            table.ForEach(inputs =>
            {
                count++;
                var strBuilder = new StringBuilder();
                var truthTableOp = new TruthTableOperation(operation, inputs);
                inputs.ForEach(it =>
                {
                    strBuilder.Append($"{it}\t");
                });
                strBuilder.Append($"=>\t").AppendLine($"{truthTableOp.Result} [{count}]");

                Console.WriteLine(strBuilder);
            });
        }
    }
}
