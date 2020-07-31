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
            var ratioPassword = generateRatioPassword();
            var amountUpper = ratioPassword[0];
            var amountLower = ratioPassword[1];
            var amountNumber = ratioPassword[2];

            var upperCase = upperGenerate(amountUpper);
            var lowerCase = lowerGenerate(amountLower);
            var numberCase = numberGenerate(amountNumber);

            var sb = new StringBuilder();
            var passwordGenerateDone = sb.Append(upperCase).Append(lowerCase).Append(numberCase).ToString();
            var shufflePass = shuffleString(passwordGenerateDone);

            Console.WriteLine($"upperCase : {upperCase}");
            Console.WriteLine($"lowerCase : {lowerCase}");
            Console.WriteLine($"numberCase : {numberCase}");
            Console.WriteLine($"password : {shufflePass}");
        }

        private List<int> generateRatioPassword()
        {
            var amountUpper = 0;
            var amountLower = 0;
            var amountNumber = 0;
            var IsRatio = false;
            while (IsRatio == false)
            {
                var amountPassword = 8;
                var maxNumber = 5;

                amountUpper = randomFunction(1, 4);
                amountLower = randomFunction(1, 4);
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