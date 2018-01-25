
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    /*
   class Shape
    {
        public void setWidth(int w)
        {
             width = w;
        }
        public void setHeight(int h)
        {
            height = h;

        }
        protected int width;
        protected int height;
    }

    //派生类
    class Rectangle:Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }
    class RectangleTester
    {
        static void Main(String[] args)
        {
            Rectangle Rect = new Rectangle();
            Rect.setHeight(5);
            Rect.setWidth(6);


            Console.WriteLine("总面积：{0}", Rect.getArea());
            Console.ReadKey();
        }
    }
    */
    class Rectangle
    {
        //成员变量
        protected double length;
        protected double width;
        public Rectangle(double l,double w)   //构造函数
        {
            length = l;
            width = w;
        }
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

    class Tabletop:Rectangle
    {
        private double cost;
        public Tabletop(double l,double w):base(1,w)  //派生类构造函数base
            //理解构造函数：可以在类上赋值
        {

        }
        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }
        public void Display()
        {
            base.Display(); //基类的Display方法调用。
            Console.WriteLine("成本：{0}", GetCost());

        }
    }
    class ExecuteRectangle
    {
        static void Main(String[] args)
        {
            Tabletop t = new Tabletop(4.5, 7.5); //类可以赋值，因为构造了构造函数。
            t.Display();
            Console.ReadLine();
        }
    }
}
