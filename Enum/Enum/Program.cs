using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    /*
    class Program
    {
        enum Days
        {
            Sun,Mon,Tue,Wed,Thu,Fri,Sat
        };
        static void Main(string[] args)
        {
            int WeekdayStart = (int)Days.Fri;
            int WeekdayEnd = (int)Days.Mon;
            Console.WriteLine("Monday:{0}", WeekdayStart);
            Console.WriteLine("Friday:{0}", WeekdayEnd);
            Console.ReadLine();
        }
    }
    */
    /*
    class test01
    {
        enum Day1
        {
            Mon=71,
            Tue=61,
            Wed=56,
            Thu=58,
            Fri=20,
            Sat=69,
            Sun=80                        
        }
        static void Main(string[] args)
        {
            int c = (int)Day1.Fri;
            int d = (int)Day1.Mon;
            Console.WriteLine("Friday:{0}", c);
            Console.WriteLine("Friday:{0}", d);
            Console.ReadKey();


        }
    }
    */
    class test2
    {
        enum Day2
        {
            length,
            width,
            height

        }
        static void Main(string[] args)
        {
            int[] parameter = new int[3] { 1, 5, 8 };
            Console.WriteLine("length:{0}", parameter[(int)Day2.height]);
            Console.WriteLine("width:{0}", parameter[(int)Day2.width]);
            Console.WriteLine("height:{0}", parameter[(int)Day2.height]);
            Console.ReadKey();



        }
    }
}
