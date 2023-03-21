using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }
        public T Sum
        {
            get; set;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<Node<T>> ac)
        {
            Node<T> t = head;
            while (t != null)
            {
                ac(t);
                t = t.Next;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int max = 0;
            int min = 0x7fffffff;
            GenericList<int> Glist = new GenericList<int>();
            Random rand = new Random();
            for(int n = 0; n < 10; n++)
            {
                Glist.Add(rand.Next(100));
            }

            //逐个输出链表元素
            Console.Write("链表的元素为：");
            Glist.ForEach(n => Console.Write(n.Data + "  "));
            Console.WriteLine();

            //计算链表元素之和并输出
            Glist.ForEach(n => sum += n.Data);
            Console.WriteLine("链表的元素的和为：" + sum);

            //计算链表元素的最大值并输出
            Glist.ForEach(n => max = max < n.Data ? n.Data : max);
            Console.WriteLine("链表元素的最大值为：" + max);

            //计算链表元素的最小值并输出
            Glist.ForEach(n => min = min < n.Data ? min : n.Data);
            Console.WriteLine("链表元素的最小值为：" + min);

            Console.Read();
        }
    }
}
