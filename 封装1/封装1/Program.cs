﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 封装1
{
    /*
    class Rectangle
    {
        public double length;
        public double width;
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度：{0}", length);
            Console.WriteLine("宽度：{0}", width);
            Console.WriteLine("面积：{0}", GetArea());
        }
    }
    class Executerectangle
        {
        static void Main(string[] args)
        {
        Rectangle r = new Rectangle();
        r.length = 4.5;
        r.width = 3.5;
        r.Display();
        Console.WriteLine();
        }
        

    }
    */
    /*
    class Rectangle
    {
        private double length;
        private double width;
        public void Acceptdetails()
        {
            Console.WriteLine("请输入长度：");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入宽度：");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度：{0}", length);
            Console.WriteLine("宽度：{0}", width);
            Console.WriteLine("面积:{0}", GetArea());
        }
    }//end class Rectangle

    class ExecuteRetangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
    */
    class Rectangle
    {
        internal double length;
        internal double width;
        double GetArea()
        {
            return length*width;
        }
        public void Display()
        {
            Console.WriteLine("长度：{0}", length);
            Console.WriteLine("宽度：{0}", width);
            Console.Write("面积：{0}", GetArea());

        }

    }//end class Rectangle
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
        

    }


}
