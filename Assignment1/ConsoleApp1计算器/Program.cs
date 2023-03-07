using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double n1 = 0;
            double n2 = 0;
            Console.Write("Please enter a number ");
            s = Console.ReadLine();
            n1=double.Parse(s);
            Console.Write("Please enter another number ");
            s=Console.ReadLine();
            n2=double.Parse(s);
            Console.Write("Please enter an operating character ");
            s= Console.ReadLine();
            switch (s)
            {
                case "*":
                    Console.WriteLine(n2 * n1);
                    break;
                case "+":
                    Console.WriteLine(n2 + n1);
                    break;
                case "-":
                    Console.WriteLine(n2 -n1);
                    break;
                case "/":
                    Console.WriteLine(n2 / n1);
                    break;
            }
            Console.ReadLine();
        }
    }
}
