using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void outputPrim(int n)
        {
           if(n == 0 || n == 1)
            {
                Console.WriteLine("该数字不存在质因数");
            }
            else
            {
                Console.WriteLine(("质因数为："));
                for(int i = 2; i <= n;)
                {
                    if(n%i == 0)
                    {
                        n = n / i;
                        Console.Write(i+"  ");
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数");
            string s = "";
            s=Console.ReadLine();
            int n = Int32.Parse(s);
            outputPrim(n);
            Console.Read();
        }
    }
}
