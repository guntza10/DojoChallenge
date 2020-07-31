using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorPassword
{
    public class GeneratorPassword
    {
        private readonly string upperLetters;
        private readonly string lowerLetters;
        private readonly string numberLetters;

        public GeneratorPassword()
        {
            upperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            lowerLetters = "abcdefghijklmnopqrstuvwxyz";
            numberLetters = "1234567890";
        }

        public void GeneratePassword()
        {
            var randomCase = randomFunction(1, 4);
            var password = randomCase switch
            {
                1 => case1(),
                2 => case2(),
                3 => case3(),
                _ => "can't be generated."
            };
            Console.WriteLine($"password : {password}");
        }

        private string case1()
        {
            var ratioPassword = generateRatioPassword(1, 1, 1);
            var amountUpper = ratioPassword[0];
            var amountLower = ratioPassword[1];
            var amountNumber = ratioPassword[2];

            var upperCase = upperGenerate(amountUpper);
            var lowerCase = lowerGenerate(amountLower);
            var numberCase = numberGenerate(amountNumber);

            var sb = new StringBuilder();
            var passwordGenerateDone = sb.Append(upperCase).Append(lowerCase).Append(numberCase).ToString();
            var shufflePass = shuffleString(passwordGenerateDone);

            Console.WriteLine($"Case 1");
            Console.WriteLine($"upperCase : {upperCase}");
            Console.WriteLine($"lowerCase : {lowerCase}");
            Console.WriteLine($"numberCase : {numberCase}");
            return shufflePass;
        }

        private string case2()
        {
            var ratioPassword = generateRatioPassword(1, 0, 1);
            var amountUpper = ratioPassword[0];
            var amountNumber = ratioPassword[2];

            var upperCase = upperGenerate(amountUpper);
            var numberCase = numberGenerate(amountNumber);

            var sb = new StringBuilder();
            var passwordGenerateDone = sb.Append(upperCase).Append(numberCase).ToString();
            var shufflePass = shuffleString(passwordGenerateDone);

            Console.WriteLine($"Case 2");
            Console.WriteLine($"upperCase : {upperCase}");
            Console.WriteLine($"numberCase : {numberCase}");
            return shufflePass;
        }

        private string case3()
        {
            var ratioPassword = generateRatioPassword(0, 1, 1);
            var amountLower = ratioPassword[1];
            var amountNumber = ratioPassword[2];

            var lowerCase = lowerGenerate(amountLower);
            var numberCase = numberGenerate(amountNumber);

            var sb = new StringBuilder();
            var passwordGenerateDone = sb.Append(lowerCase).Append(numberCase).ToString();
            var shufflePass = shuffleString(passwordGenerateDone);

            Console.WriteLine($"Case 3");
            Console.WriteLine($"lowerCase : {lowerCase}");
            Console.WriteLine($"numberCase : {numberCase}");
            return shufflePass;
        }

        private List<int> generateRatioPassword(int upper, int lower, int number)
        {
            var amountUpper = upper;
            var amountLower = lower;
            var amountNumber = number;

            var amountPassword = 8;
            var maxUpper = 3;
            var maxLower = 3;
            var maxNumber = 5;

            var caseGeneratRatio = (upper != 0 && lower != 0) ? 1 : 2;

            var IsRatio = false;
            while (IsRatio == false)
            {
                if (caseGeneratRatio == 1)
                {
                    amountUpper = randomFunction(1, maxUpper + 1);
                    amountLower = randomFunction(1, maxLower + 1);
                }
                else
                {
                    amountUpper = (upper != 0) ? randomFunction(1, maxUpper + 1) : 0;
                    amountLower = (lower != 0) ? randomFunction(1, maxLower + 1) : 0;
                    maxNumber = 6;
                }

                amountNumber = amountPassword - (amountUpper + amountLower);
                if (amountNumber <= maxNumber) IsRatio = true;
            }
            return new List<int> { amountUpper, amountLower, amountNumber };
        }

        private string shuffleString(string str)
        {
            var strKeep = new StringBuilder(str);
            var strShuffle = new StringBuilder(str);
            for (int i = 0; i < str.Length; i++)
            {
                var index = randomFunction(0, strKeep.Length);
                strShuffle[i] = strKeep[index];
                strKeep.Remove(index, 1);
            }
            return strShuffle.ToString();
        }

        private string upperGenerate(int amount)
        {
            var sb = new StringBuilder();
            var upperKeep = upperLetters;

            for (int i = 0; i < amount; i++)
            {
                var index = randomFunction(0, upperKeep.Length);
                var upperRandom = upperKeep[index].ToString();
                sb.Append(upperRandom);
                upperKeep = upperKeep.Remove(index, 1);
            }
            return sb.ToString();
        }

        private string lowerGenerate(int amount)
        {
            var sb = new StringBuilder();
            var lowerKeep = lowerLetters;

            for (int i = 0; i < amount; i++)
            {
                var index = randomFunction(0, lowerKeep.Length);
                var lowerRandom = lowerKeep[index].ToString();
                sb.Append(lowerRandom);
                lowerKeep = lowerKeep.Remove(index, 1);
            }
            return sb.ToString();
        }

        private string numberGenerate(int amount)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < amount; i++)
            {
                var index = randomFunction(0, 10);
                sb.Append(numberLetters[index].ToString());
            }
            return sb.ToString();
        }

        private int randomFunction(int min, int max)
        {
            var rnd = new Random();
            return rnd.Next(min, max);
        }
    }
}