using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法
{
    //同一个类中进行调用
    /*
    class NumberManipulator
    {
        public int FindMax(int num1,int num2)
        {
            int result;
            if (num1 > num2)
                result = num1;
            else
                result = num2;
            Console.WriteLine(result);
            return 0;
        }
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            int ret;
            NumberManipulator n = new
                NumberManipulator();
            n.FindMax(a, b);
            Console.ReadLine();
        }
    }
    */
    //另一个类中调用这个类
    /*
    class NumberManipulator
    {
        public int FindMax(int num1,int num2)
        {
            int result;
            if (num1 > num2)
                result = num1;
            else
                result=num2;
            return result;

        }

    }
    class Test
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            int ret;
            NumberManipulator n = new NumberManipulator(); //新的类
            ret=n.FindMax(a, b); //调用类的方法
            Console.WriteLine("最大值为：{0}", ret);
            Console.ReadLine();



                }
    }
    */
    //递归方法的调用
    /*
    class NumberManipulator
    {
        public int factorial(int num)
        {
            int result;
            if (num==1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            Console.WriteLine("6的阶乘是：{0}", n.factorial(6));
            Console.WriteLine("7的阶乘是：{0}", n.factorial(7));
            Console.WriteLine("8的阶乘是：{0}", n.factorial(8));
            Console.ReadLine();
        }
    }
    */
    //按值传递参数
    /*
    class Numbermanipulator
    {
        public void swap(int x,int y)
        {
            int temp;
            temp = x;
            x = y; //x作为形参
            y = temp;//y作为形参】
            //形参值发生变化后，不会影响实参的值。
        }
        static void Main(string[] args)
        {
            Numbermanipulator n = new Numbermanipulator();
            int a = 100;
            int b = 200;
            Console.WriteLine("在交换之前，a的值是：{0}", a);
            Console.WriteLine("在交换之前，b的值是：{0}", b);
            n.swap(a, b);
            Console.WriteLine("在交换之后，a的值是：{0}", a);
            Console.WriteLine("在交换之后，b的值是：{0}", b);

            Console.WriteLine();


        }

    }
    */
    //按引用传递参数
    /*
    class NumberManipulator
    {
        public void swap(ref int x,ref int y) //ref作为关键字引用参数
        {
            int temp;

            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a = 100;
            int b = 200;
            Console.WriteLine("在交换之前，a的值是：{0}", a);
            Console.WriteLine("在交换之前，b的值是：{0}", b);

            n.swap(ref a, ref b);
            Console.WriteLine("在交换之后，a的值是：{0}", a);
            Console.WriteLine("在交换之后，b的值是：{0}", b);
            Console.WriteLine();

        }
    }
    */
    //按输出传递参数
    /*
    class NumberManipulator
    {
        public void getValue( out int x) //out 是一个标识符

        {
            int temp = 5;
            x = temp;

        }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a = 100;
            Console.WriteLine("在方法调用之前，a的值是：{0}", a);

            n.getValue(out a);

            Console.WriteLine("在方法调用之前，a的值是：{0}", a);
            Console.ReadLine();


        }
    }
    */
    //特别
    class NumberManipulator
    {
        public void getValues( out int x,out int y)
        {
            Console.WriteLine("请输入第一个值:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个值：");
            y = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a, b;

            n.getValues(out a,out b);
            Console.WriteLine("在调用之后，a的值是：{0}", a);
            Console.WriteLine("在调用之后，b的值是：{0}", b);
            Console.ReadLine();

        }
    }


}
