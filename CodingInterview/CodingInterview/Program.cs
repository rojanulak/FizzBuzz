using FizzBuzzLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzzEngine = new FizzBuzz(int.MaxValue);
            fizzBuzzEngine.AddTestParm(3, "Fizz");
            fizzBuzzEngine.AddTestParm(5, "Buzz");

            Console.WriteLine(fizzBuzzEngine.GenerateFizzBuzzResult());
            Console.Read();
        }
    }
}
