using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
   
    class Box
    {
        public double length;
        public double width;
        public double height;

    }
    class Test
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(); //声明box1 为Box
            Box box2 = new Box();

            box1.length = 1.2;
            box1.width = 2.2;
            box1.height = 3.2;

            box2.length = 2.1;
            box2.width = 3.3;
            box2.height = 4.2;

            Console.WriteLine("box1的面积为:{0}", box1.height * box1.length * box1.width);
            Console.WriteLine("box2的面积为:{0}", box2.height * box2.length * box2.width);

        }
    }
   
    class Line
    {
        private double length;
        public Line(); //构造函数
        {
          console.writeLine("对象已创建");
   


    }
   
}
