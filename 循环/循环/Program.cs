using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //while 循环
            /*
            int a = 10;
            while(a<20)
            {
                Console.WriteLine("a的值是{0}", a);
                    a++;
            }
            Console.ReadLine();
            */
            //for 循环
            /*
            for (int i=10;i<20;i++)
            {
                Console.WriteLine("a的值是{0}",i);

            }
            Console.ReadLine();
            */
            //do while 
            /*
            int a = 10;
            do
            {
                Console.WriteLine("a的值是{0}", a);
                a = a + 1;


            }
            while (a < 20);
            Console.ReadLine();
            */
            //嵌套循环
            /*
            int i, j;
            for (i = 2; i < 100; i++)
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0) break;
                if (j > (i / j))
                    Console.WriteLine("{0}是质数", i);
            }
            Console.ReadLine();
            */
            //break 语句
            /*
            int a = 10;
            while (a < 20)
            {
                Console.WriteLine("a的值是：{0}", a);
                a++;
                if (a > 15)
                {
                    break;
                }
            }
            Console.ReadLine();
            */
            /*
            int a = 10;
            do
            {
                if (a == 15)
                {
                    a = a + 1;
                    continue;
                }
                Console.Write("a的值是：{0}", a);
                a++;
            }
            while (a < 20);
            Console.ReadLine();
            */
            for(;;)
            {
                Console.WriteLine("Hey!I am Trapped");
            }

        }
    }
}
