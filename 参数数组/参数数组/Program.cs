using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 参数数组
{
    class ParamArray
    {
        public int AddElement(params int[] arr)   //数组arr 作为参数
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }
    }
    class TestClass
    {
        
        static void Main(string[] args)
        {
            ParamArray app = new ParamArray();
            int sum = app.AddElement(512, 720, 250, 567, 889);
            Console.WriteLine("总和是：{0}", sum);
            Console.ReadLine();
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = list;

            Console.WriteLine("原始数组：");
            foreach (int i in list)
            {
                Console.WriteLine(i + " ");  //"文字+{0}",变量     变量+"文字"
            }
            Console.ReadLine();

            //逆数组
            Array.Reverse(temp);
            Console.WriteLine("逆转数组：");
            foreach(int i in temp)
            { 
                Console.WriteLine(i + " ");
            }
            Console.ReadLine();

            //排序数组
            Array.Sort(temp);
            Console.Write("排序数组：");
            foreach(int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }

}
