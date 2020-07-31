using System;

namespace GeneratorPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            var generatorPass = new GeneratorPassword();
            Console.Write("How many round to generate password? : ");
            var countRound = Convert.ToInt32(Console.ReadLine());
            var count = 0;
            while (count < countRound)
            {
                count++;
                Console.WriteLine($"Round : {count}");
                generatorPass.GeneratePassword();
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}
