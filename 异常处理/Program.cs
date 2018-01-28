using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 异常处理
{
    //class test
    //{
    //    static double SafeDivision(double x, double y)
    //    {
    //        if (y == 0)
    //            throw new System.DivideByZeroException();  //抛出异常，执行下面的代码。
    //        return x / y;
    //    }

    //    static void Main()
    //    {
    //        double a = 98, b = 1;
    //        double result = 0;

    //        try
    //        {
    //            result = SafeDivision(a, b);
    //            Console.WriteLine("{0} divided by{1}={2}", a, b, result);
    //        }

    //        catch
    //        {
    //            Console.WriteLine("Attempted divide by zero.");
    //        }
    //    }



    //}
    class test1
    {
        static void ExceptionTest()
        {
            Console.WriteLine("请输入一个整数，按回车结束");
            string input = Console.ReadLine();
            int intputNumber;

            try
            {
                intputNumber = Convert.ToInt32(input);   //1、激活代码，都执行。
                Console.WriteLine("123");
                Console.WriteLine("1234");


            }
            catch (Exception)
            {
                Console.WriteLine("ExceptionTest执行出现异常");
                throw new Exception("转换出现异常");

            }
            finally
            {
                Console.WriteLine("ExceptionTest程序在finally语句中执行");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                ExceptionTest();  //2、若抛出异常则下行不执行，立即执行CATCH
                Console.WriteLine("调用方法ExceptionTest成功");

            }
            catch(Exception e)
            {
                Console.WriteLine("调用方法ExceptionTest异常");
            }
            Console.ReadLine();
        }

    }
}
