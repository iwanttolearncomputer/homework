using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class Order //一个订单
    {
        public int ID { get; set; }
        public string Customer { get; set; }
        public double Sum { get; set; }
        public string Date { get; set; }
        public List<OrderDetails> orderDetailList = new List<OrderDetails>();
        public Order() { }
        public Order(int id, string customer, string date)
        {
            this.ID = id;
            this.Customer = customer;
            this.Date = date;
        }

        //利用订单号判断两个订单是否相同
        //重写equals函数，利用主码ID判断订单号是否重复
        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return this.ID == order.ID;
        }
        public override int GetHashCode()
        {
            return Convert.ToInt32(ID);
        }

        //该订单的总金额
        public void getSum()
        {
            double i = 0;
            foreach (OrderDetails orderDetail in orderDetailList)
            {
                i = i + orderDetail.totalPrice();
            }
            this.Sum = i;
        }

        //添加订单详细信息
        public void addOrder(string name, int number, double price)
        {
            OrderDetails a = new OrderDetails(name, number, price);
            this.orderDetailList.Add(a);
        }
        //删除某个订单详细信息
        public void RemoveOrder()
        {
            try
            {
                Console.WriteLine("请输入订单明细序号删除相应订单明细：");
                int a = Convert.ToInt32(Console.ReadLine());
                this.orderDetailList.RemoveAt(a);
                Console.WriteLine("删除成功");
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("输入序号错误");
            }
        }
        //展示订单详细信息
        public void showOrder()
        {
            foreach (OrderDetails a in this.orderDetailList)
            {
                Console.WriteLine("商品序号:" + this.orderDetailList.IndexOf(a) + " 名称:" + a.Name + " 数量:" + a.Amount + " 单价:" + a.Price);
                Console.WriteLine();
            }
        }
    }
}
