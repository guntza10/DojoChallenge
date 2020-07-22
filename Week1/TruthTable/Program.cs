using System;
using System.Collections.Generic;

namespace TruthTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Truth Table");
            // Console.Write("What Operation you use? : ");
            // var operation = Console.ReadLine();
            // Console.Write("How many input you want? : ");

            // var amountInput = Console.ReadLine();
            // var amount = Convert.ToInt32(amountInput);

            // var listInput = new List<string>();

            // for (int i = 0; i < amount; i++)
            // {
            //     Console.Write($"Input {i + 1} : ");
            //     var input = Console.ReadLine();
            //     listInput.Add(input);
            // }

            // var truthTable = new TruthTableOperation(operation, listInput);
            // var result = truthTable.Result;
            // Console.WriteLine($"Result Truth Table : {result}");
            var createTable = new CreateTable();
            createTable.CreateTruthTable(3);
        }
    }
}
