using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Ehrlich(int n)
        {
            if(n == 0 || n == 1)
            {
                return;
            }
            for(int i = 0; i < n; i++)
            {
                int j = 2;
                while (j <= i)
                {
                    if (j == i)
                    {
                        Console.Write(i + " ");
                    }
                    else if (i % j == 0) {
                        break;
                    }
                    j++;
                }
            }
        }
        static void Main(string[] args)
        {
            int n = 100;
            Ehrlich(n);
            Console.Read();
        }
    }
}
