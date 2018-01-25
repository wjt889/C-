using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 表盘
{
    abstract class Dashboard
    {
        public abstract void Render();
    }

    class 雇佣兵的Hp:Dashboard
    {
        public int Hp = 200;
        public override void Render()
        {
            Console.WriteLine("雇佣兵的Hp为{0}", Hp);
        }

    }
    class 主角的Hp:Dashboard
    {
        public int Hp = 100;
        public override void Render()
        {
            Console.WriteLine("主角的Hp为{0}", Hp);
        }
    }
    class 主角
    {
        public 主角的Hp HP = new 主角的Hp();
        public 雇佣兵 Helper = new 雇佣兵();
        
        
    }
    class 雇佣兵
    {
        public 雇佣兵的Hp HP = new 雇佣兵的Hp();  //has-p

    }

    class Program
    {
       
        static void 重绘(Dashboard dashboard)
        {
            dashboard.Render();

        }

        static void Main(string[] args)
        {
            主角 me = new 主角();
            重绘(me.HP);
            重绘(me.Helper.HP);
            Thread.Sleep(1000);


            me.HP.Hp -= 50;


            重绘(me.HP);
            重绘(me.Helper.HP);

            Console.Read();
        }
       
        /*
        static void 重绘(List<Dashboard> dashboards)
        {
            foreach(var dashboard in dashboards);
            dashboard.Render();

        }
        static void Main(string[] args)
        {
            主角 me = new 主角();
            List<Dashboard> dbs = new List<Dashboard>();
        }
        */
           

           

    }
}
