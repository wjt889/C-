using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 10;
            if(a<20)
            {
                Console.WriteLine("a小于20");

            }
            Console.WriteLine("a的值是{0}",a);
            Console.ReadLine();
            */
            //if else 
            /*
            int a = 100;
            if(a<20)
            {
                Console.WriteLine("a小于20");

            }
            else
            {
                Console.WriteLine("a大于20");

            }
            Console.WriteLine("a的值是{0}", a);
            Console.ReadLine();
            */
            //if else 2
            /*
            int a = 100;
            if (a == 10)
            {
                Console.WriteLine("a的值是10");

            }
            else if (a == 20) 
            {
                Console.WriteLine("a的值是20");
            }
            else
            {
                Console.WriteLine("没有匹配");


            }
            Console.WriteLine("a的值是{0}", a);
            Console.ReadLine();
            */
            //嵌套if 语句
            /*
            int a = 100;
            int b = 200;
            if (a==200)
            {
                if(b==200)
                {
                    Console.WriteLine("a的值是100，且b的值是200");

                }

            }
            */
            //switch 语句
            /*
            char grade = 'B';
            switch(grade)
            {
                case 'A':
                    Console.WriteLine("很棒！");
                    break;
                case 'B':
                    Console.WriteLine("正确");
                    break;
                case 'C':
                    Console.WriteLine("做的很好");
                    break;
                case 'D':
                    Console.WriteLine("您通过了");
                    break;
                case 'E':
                    Console.WriteLine("您再试一下");
                    break;
                default:
                    Console.WriteLine("无效成绩");
                    break;

            }
            Console.WriteLine("您的成绩是{0}", grade);
            Console.ReadLine();
            */

            //嵌套switch语句
            /*
            int a = 100;
            int b = 200;
            switch(a)
            {
                case 100:
                    Console.WriteLine("这是外部switch的一部分");
                    switch(b)
                    {
                        case 200:
                            Console.WriteLine("这是内部的一部分");
                            break;
                    }
                    break;
            }
            */

            }
    }
}
