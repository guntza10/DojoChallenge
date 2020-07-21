using System;

namespace GcdAndLcm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Greater Common Divisor");
            Console.Write("input 1 : ");
            var inputGDC1 = Console.ReadLine();
            Console.Write("input 2 : ");
            var inputGDC2 = Console.ReadLine();

            var GdcOperator = new GreaterCommonDivisor();
            GdcOperator.input1 = Convert.ToInt32(inputGDC1);
            GdcOperator.input2 = Convert.ToInt32(inputGDC2);
            var GDC = GdcOperator.FindGreaterCommonDivisor();
            Console.WriteLine($"Greater Common Divisor : {GDC}");

            Console.WriteLine("==========================================");

            Console.WriteLine("Find Least Common Multiple");
            Console.Write("input 1 : ");
            var inputLCM1 = Console.ReadLine();
            Console.Write("input 2 : ");
            var inputLCM2 = Console.ReadLine();

            var LcmOperator = new LeastCommonMultiple();
            LcmOperator.input1 = Convert.ToInt32(inputLCM1);
            LcmOperator.input2 = Convert.ToInt32(inputLCM2);
            var LCM = LcmOperator.FindLeastCommonMultiple();
            Console.WriteLine($"Least Common Multiple : {LCM}");
        }
    }
}
