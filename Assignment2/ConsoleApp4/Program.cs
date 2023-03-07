using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static bool flag = true;
        static void isToplitz(int[,] arr,int x,int y)//arr是待求证的矩阵,x是行元素，y是列元素，用递归实现
        {
            int m=arr.GetLength(0);
            int n=arr.GetLength(1);
            if (x <m-1 && y < n-1)
            {
                if (arr[x, y] != arr[x+1 , y+1])
                {
                    flag = false;
                }
            }
            else
            {
                return;
            }
            isToplitz(arr,x+1,y);//沿行递归
            isToplitz(arr, x,y+1);//沿列递归
        }
        static void Main(string[] args)
        {
            int[,] arr = new int[3,4] { {1,2,3,4 },{5,1,2,3 },{9,5,1,2 } };
            isToplitz(arr,0,0);
            Console.WriteLine(flag);
            Console.ReadLine();
        }
    }
}
