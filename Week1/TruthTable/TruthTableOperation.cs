using System;
using System.Linq;
using System.Collections.Generic;

namespace TruthTable
{
    public class TruthTableOperation
    {
        public bool Result { get; private set; }

        public TruthTableOperation(string operation, List<string> inputs)
        {
            var OP = operation.ToUpper();
            var result = OP switch
            {
                "AND" => AND(inputs),
                "OR" => OR(inputs),
                "XOR" => XOR(inputs),
                _ => throw new Exception("Operation Not Found"),
            };
            Result = result;
        }

        private bool AND(List<string> inputs)
        {
            var checkFalse = inputs.Select(it => it.ToUpper()).Any(it => it == "F");
            var result = checkFalse ? false : true;
            return result;
        }

        private bool OR(List<string> inputs)
        {
            var checkTrue = inputs.Select(it => it.ToUpper()).Any(it => it == "T");
            var result = checkTrue ? true : false;
            return result;
        }

        private bool XOR(List<string> inputs)
        {
            var listInput = inputs.Select(it => it.ToUpper());
            var keeper = listInput.Skip(0).Take(1).FirstOrDefault();
            var listInp = listInput.Skip(1);
            foreach (var input in listInp)
            {
                keeper = IsXOR(keeper, input) ? "T" : "F";
            }
            return (keeper == "T") ? true : false;
        }

        private bool IsXOR(string input1, string input2)
        {
            return (input1 == input2) ? false : true;
        }
    }
}