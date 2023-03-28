using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class OrderService    //所有订单
    {
        public List<Order> order = new List<Order>();
        public OrderService() { }
        //显示订单信息
        public void Show()
        {
            foreach (Order temp in this.order)
            {
                Console.WriteLine("订单号:" + temp.ID + " 客户:" + temp.Customer + " 日期:" + temp.Date + " 总金额:" + temp.Sum);
                temp.showOrder();
            }
        }
        //增加订单
        public void add()         
        {
            try
            {
                //输入订单内容
                Console.WriteLine("请输入订单编号：");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入客户名称：");
                string customer = Console.ReadLine();
                Console.WriteLine("请输入订购时间：");
                string date = Console.ReadLine();
                Order temp = new Order(id, customer, date);
                Console.WriteLine();

                //输入订单详细内容
                Console.WriteLine("继续输入订单详细内容：");
                bool judge = true;
                bool same = false;
                foreach (Order order in this.order)
                {
                    if (order.Equals(temp)) same = true;
                }
                if (same) Console.WriteLine("订单号重复");
                else
                {
                    while (judge && !same)
                    {
                        Console.WriteLine("请输入物品名称：");
                        string name = Console.ReadLine();
                        Console.WriteLine("请输入购买数量：");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("请输入单价：");
                        double price = Convert.ToDouble(Console.ReadLine());
                        temp.addOrder(name, number, price);
                        Console.WriteLine("是否继续添加订单详细内容（1代表是，0代表否）：");
                        int x = Convert.ToInt32(Console.ReadLine());
                        if (x == 0) judge = false;
                        else if (x == 1) continue;
                        else if (x != 0 && x != 1)
                        {
                            Exception e = new Exception();
                            throw e;
                        }
                    }
                    order.Add(temp);
                    temp.getSum();
                    Console.WriteLine("添加成功");
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("输入错误");
            }

        }
        //删除订单
        public void remove()           
        {
            try
            {
                Console.WriteLine("请输入要删除的订单号：");
                int id = Convert.ToInt32(Console.ReadLine());
                int index = 0;
                foreach (Order temp in this.order)
                {
                    if (temp.ID == id) index = this.order.IndexOf(temp);
                }
                Console.WriteLine("是否删除订单（1代表删除订单，0代表不删除订单）");

                while (true)
                {
                    int choose = Convert.ToInt32(Console.ReadLine());
                    if (choose == 1)
                    {
                        this.order.RemoveAt(index);
                        Console.WriteLine("删除成功");
                        Console.WriteLine();
                    }
                    else if (choose == 0)
                    {
                        this.order[index].showOrder();
                        this.order[index].RemoveOrder();
                    }
                    else
                    {
                        Console.WriteLine("输入错误，请重新输入");
                        Console.WriteLine("是否删除订单（1代表删除订单，0代表不删除订单,仅删除明细）");
                    }
                }
            }
            catch
            {
                Console.WriteLine("出现错误");
            }

        }
        //查询订单
        public void search()  
        {
            Console.WriteLine("输入1根据订单号查询订单，输入2根据客户名查询订单");
            int i = Convert.ToInt32(Console.ReadLine());
            try
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("请输入订单号");
                        int orderID = Convert.ToInt32(Console.ReadLine());
                        var query1 = from s1 in order
                                     where s1.ID == orderID
                                     orderby s1.Sum
                                     select s1;
                        List<Order> list1 = new List<Order>();

                        foreach (Order temp1 in list1)
                        {
                            Console.WriteLine("订单号:" + temp1.ID + " 客户:" + temp1.Customer + " 日期:" + temp1.Date + " 总金额:" + temp1.Sum);
                            temp1.showOrder();
                        }
                        break;
                    case 2:

                        Console.WriteLine("输入客户名称：");
                        string name1 = Console.ReadLine();

                        var query2 = from s2 in order
                                     where s2.Customer == name1
                                     orderby s2.Sum
                                     select s2;
                        List<Order> list2 = query2.ToList();

                        foreach (Order temp2 in list2)
                        {
                            Console.WriteLine("订单号:" + temp2.ID + " 客户:" + temp2.Customer + " 日期:" + temp2.Date + " 总金额:" + temp2.Sum);
                            temp2.showOrder();
                        }
                        break;
                    default:
                        Console.WriteLine("输入错误");
                        Console.WriteLine();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("输入错误");
            }
        }
    }
}
