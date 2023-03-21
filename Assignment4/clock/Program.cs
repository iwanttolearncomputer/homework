using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock
{
    internal class Program
    {
        class Clock
        {
            DateTime alarmTime = DateTime.Now;
            public delegate void AlarmControl(object sender, DateTime args);
            public delegate void TickControl(object sender, DateTime args);

            public void Tick(object sender, DateTime time)
            {
                Console.Write("Tick! The time now is ：");
                Console.WriteLine(time);
            }
            public void Alarm(object sender, DateTime time)
            {
             
                Console.Write("The alarm starts working now,the time is ：");
                Console.WriteLine(time);
            }

            public event AlarmControl OnAlarm;
            public event TickControl OnTick;
            public Clock()
            {
                OnAlarm += Alarm;
                OnTick += Tick;
            }
            public void Start()
            {
                Console.WriteLine("The clock starts working");
                while (true)
                {
                    DateTime nowtime = DateTime.Now;
                    OnTick(this, nowtime);
                    if (nowtime.ToString() == alarmTime.ToString())
                    {
                        OnAlarm(this, alarmTime);
                        break;
                    }
                    System.Threading.Thread.Sleep(1000);
                }
                Console.Read();
            }
            public void SetalarmTime(DateTime alarm)
            {
                Console.WriteLine("Set time to ：" + alarm);
                alarmTime = alarm;
            }
        }
        static void Main(string[] args)
        {
            Clock clock = new Clock();

            DateTime nowtime = new DateTime();
            nowtime = DateTime.Now;
            clock.Tick(clock, nowtime);

            DateTime alarmtime = new DateTime();
            //将闹钟设置为当前时间的十秒钟后
            alarmtime = DateTime.Now.AddSeconds(10);
            Console.WriteLine("The alarm will be ringing after 10 seconds.");
            clock.SetalarmTime(alarmtime);
            clock.Start();
        }
    }
}
