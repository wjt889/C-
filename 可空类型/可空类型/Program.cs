﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 可空类型
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;
            bool? boolval = new bool?();

            //显示值
            Console.WriteLine("显示可空类型值：{0},{1},{2},{3}", num1, num2, num3, num4);
            Console.WriteLine("一个可空的布尔值：{0}", boolval);
            Console.ReadLine();
            */
            double? num1 = null;
            double? num2 = 3.14157;
            double num3;
            num3 = num1 ?? 5.34;
            Console.WriteLine("num3的值是：{0}", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine("num3的值：{0}", num3);
            Console.ReadLine();


        }
    }
}
