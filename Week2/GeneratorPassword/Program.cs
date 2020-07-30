using System;

namespace GeneratorPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            var generatorPass = new GeneratorPassword();
            var count = 0;
            while (true)
            {
                count++;
                Console.WriteLine($"{count}");
                generatorPass.GeneratePassword();
            }
        }
    }
}
