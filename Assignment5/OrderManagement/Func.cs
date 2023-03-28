
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    internal class Func
    {
        public Func(OrderService orderService)
        {
            bool judge_ = true;
            while (judge_)
            {
                Console.WriteLine("输入1增加订单，输入2删除订单，输入3查询订单，输入4显示所有订单，输入5根据订单号为订单排序,输入6退出程序");
                string choose1 = Console.ReadLine();
                switch (choose1)
                {
                    case "1": orderService.add(); break;
                    case "2": orderService.remove(); break;
                    case "3": orderService.search(); break;
                    case "4": orderService.Show(); break;
                    case "5": orderService.order.Sort(); break;
                    case "6": judge_ = false; break;
                    default:
                        Console.WriteLine("输入错误");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
