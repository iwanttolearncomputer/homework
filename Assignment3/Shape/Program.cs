using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Triangle //定义一个三角形
    {
        double x1, x2, angle;//定义一个角
        public
        Triangle(double x1,double x2,double angle)
        {
            this.x1 = x1;
            this.x2 = x2;   
            this.angle = angle;
        }
       public  Triangle() { }
       public bool isTriangle()
        {
            if (x1 > 0 && x2 > 0 && angle > 0 && angle < 180)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       public double getArea()
        {
            return x1*x2*Math.Sin(angle*Math.PI/180)/2;
        }
        public void setValue(double x1, double x2, double angle)
        {
                this.x1 = x1;
                this.x2=x2;
                this.angle = angle;
        }
        public double getX1()
        {
            return x1;
        }
        public double getX2()
        {
            return x2;
        }
        public double getAngle()
        {
            return angle;
        }
    }

    class Rectangle:Triangle
    {
        public Rectangle() { }
        public Rectangle(double width,double length)
        {
            setValue(width, length, 90);
        }

    }

    class Square : Rectangle
    {
        public Square() { }
        public Square(double length)
        {
            setValue(length, length, 90);
        }
    }

    class ShapeFactory
    {
        private Random rand = new Random();
        public double allArea(int n)//随机生成n个形状的面积
        {
            double sum = 0;   //面积总和
            int count = 1; //已经创建的形状总个数
            while (true)
            {
                int temp = rand.Next(3);
                switch (temp)
                {
                    case 0://创建三角形
                        Triangle triangle = new Triangle(rand.Next(1000) + rand.NextDouble(), rand.Next(1000) + rand.NextDouble(), rand.Next(0,180) + rand.NextDouble());
                        if (triangle.isTriangle())
                        {
                            Console.WriteLine("创建的第"+count+"个图形为一个三角形，两边及夹角为:"+triangle.getX1()+"、"+triangle.getX2()+"、"+triangle.getAngle());
                            count++;
                            sum+=triangle.getArea();
                        }
                        break;
                    case 1:
                        Rectangle rectangle = new Rectangle(rand.Next(1000)+rand.NextDouble(), rand.Next(1000) + rand.NextDouble());
                        if(rectangle.isTriangle())
                        {
                            Console.WriteLine("创建的第" + count + "个图形为一个长方形，两边为:" + rectangle.getX1() + "、" + rectangle.getX2());
                            count++;
                            sum+=rectangle.getArea();
                        }
                        break;
                    case 2:

                        Square square=new Square(rand.Next(1000)+rand.NextDouble());
                        if (square.isTriangle())
                        {
                            Console.WriteLine("创建的第" + count + "个图形为一个正方形，边长为:" + square.getX1());
                            count++;
                            sum+=square.getArea();
                        }
                        break;
                    default:
                        throw new Exception("随机数生成失败！");
                }
                if (count == n+1) break;
            }

            return sum;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            ShapeFactory sh=new ShapeFactory();
            string s = "";
            Console.Write("请输入创建图形的个数：");
            s=Console.ReadLine();
            int n =Int32.Parse(s);//创建图形个数
            Console.WriteLine("这"+n+"个图形的总面积为："+sh.allArea(n));
            Console.ReadLine();

        }
    }
}
