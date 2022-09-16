using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoDot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Number ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            Console.ReadLine();
        }
    }
}
