using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class01
{
    /*
    class Program
    {
        private double length;
        public Program()
        {
            Console.WriteLine("对象已创建");
        }
        ~Program()  //创建析构函数
        {
            Console.WriteLine("对象已删除");
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
        static void Main(string[] args)
        {
            Program line=new Program ();
            line.setLength(3.0);
            Console.WriteLine("线条的长度:{0}", line.getLength());
        }
    }
    */
    class StaticVar
    {
        public static int num;
        public void count()
        {
            num++;
        } 
        public int getNum()
        {
            return num;
        }
    }
    class StaticTester
    {
        static void Main(String [] args)
        {
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            s1.count();
            s1.count();
            s1.count();
            s2.count();
            s2.count();
            s2.count();
            Console.WriteLine("s1的变量 num:{0}", s1.getNum());
            Console.WriteLine("s2的变量 num:{0}", s2.getNum());


        }
    }
}
