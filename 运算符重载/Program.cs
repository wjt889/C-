using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 运算符重载
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;

        public double getVolume()
        {
            return length * breadth * height;
        }

        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }

        //重载＋运算符来把两个Box 对象相加

        public static Box operator+(Box b,Box c)
        {
            Box box = new Box();
            box.length = b.length;
            box.breadth = b.breadth;
            box.height = b.height;
            return box;
        }

        public static bool operator == (Box lhs,Box rhs)  //必须有!= 
        {
            bool status = false;
            if (lhs.length==rhs.length&&lhs.height==rhs.height&&lhs.breadth==rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator !=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length != rhs.length || lhs.height != rhs.height || lhs.breadth != rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator<(Box lhs,Box rhs)
        {
            bool status = false;
            if (lhs.length<rhs.length&&lhs.height<rhs.height&&lhs.breadth<rhs.breadth)
            {
             status = true;
            }
            return status;
        }

        public static bool operator>(Box lhs,Box rhs)
        {
            bool status = false;
            if (lhs.length >rhs.length || lhs.height > rhs.height || lhs.breadth > rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator <=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length <= rhs.length && lhs.height <= rhs.height && lhs.breadth <= rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator >=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length >= rhs.length || lhs.height >= rhs.height || lhs.breadth >= rhs.breadth)
            {
                status = true;
            }
            return status;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();
            Box box3 = new Box();

            double volume = 0.0;

            box1.setLength(12.0);
            box1.setBreadth(6.0);
            box1.setHeight(5.0);

            box2.setLength(12.0);
            box2.setBreadth(13.0);
            box2.setHeight(10.0);

            volume = box1.getVolume();
            Console.WriteLine("box1的体积：{0}", volume);


            volume = box2.getVolume();
            Console.WriteLine("box2的体积：{0}", volume);

            box3 = box1 + box2;　　//两个对象相加。

            volume = box3.getVolume();
            Console.WriteLine("Box3 的体积： {0}", volume);
            Console.ReadKey();

            if (box1 > box2)   //因为返回的值为bool所以用if 
                Console.WriteLine("box1 大于 box2");
            else
                Console.WriteLine("box1 不大于 box2");
            if (box1 < box2)
                Console.WriteLine("box1 小于 box2");
            else
                Console.WriteLine("box1 不小于 box2");
            if (box1 >= box2)
                Console.WriteLine("box1 大于等于 box2");
            else
                Console.WriteLine("box1 不大于等于 box2");
            if (box1 <= box2)
                Console.WriteLine("box1 小于等于 box2");
            else
                Console.WriteLine("box1 不小于等于 box2");
            if (box1 != box2)
                Console.WriteLine("box1 不等于 box2");
            else
                Console.WriteLine("box1 等于 box2");
           
            Console.ReadKey();
        }
    }
}
