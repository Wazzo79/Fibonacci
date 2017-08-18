using System;

namespace Fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Fibo number to solve?");
            var val = Console.ReadLine();
            Console.WriteLine(Fibo(Convert.ToInt32(val)));
            Console.Read();
        }

        static string Fibo(int val)
        {
            var val1 = 0;
            var val2 = 1;

            for (var i = 0; i < val; i++)
            {
                var temp = val1;
                val1 = val2;
                val2 = temp + val2;
            }
            return val1.ToString();
        }
    }
}
