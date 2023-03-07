using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static int average(int []arr)
        {
            int temp = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                temp+=arr[i];
            }
            return temp;
        }//平均值
        static int maxarr(int[] arr)
        {
            int temp = 0;
            for(var i = 0; i < arr.Length; i++)
            {
                if(arr[i] > temp) { temp = arr[i]; }
            }
            return (int)temp;
        }
        static int minarr(int[] arr)
        {
            int temp = 0;
            for( var i = 0; i < arr.Length; i++)
            {
                if( arr[i] < temp) { temp = arr[i]; }
            }
            return(int)temp;
        }
        static int sum(int[] arr)
        {
            int sum = 0;
            foreach( var item in arr)
            {
                sum+=arr[item];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] test = new int[] { 8,7,6,9,2,5,4,0,1,3};//作为测试数据
            int ave = average(test);
            int max=maxarr(test);
            int min=minarr(test);
            int su=sum(test);
            Console.WriteLine("数组平均值为：" + ave);
            Console.WriteLine("数组最大值为："+max);
            Console.WriteLine("数组最小值："+min);     
            Console.WriteLine("数组元素和为："+su);
            Console.Read();
        }
    }
}
