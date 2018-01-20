using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    
    class MyArray
    {
        /*
        double getAverage(int[] arr, int size)
        {
            int i;
            double avg;
            int sum = 0;
            for (i = 0; i < size; ++i)
            {
                sum += arr[i];

            }
            avg = (double)sum / size;
            return avg;
        }
        */
        static void Main(string[] args)
        {
            //访问数组元素
            /*
            int[] n = new int[10]; 
            int i, j;

            for (i=0;i<10;i++)
            {
                n[i] = i + 100;
            }

            for(j=0;j<10;j++)
            {
                Console.WriteLine("Element[{0}]={1}",j, n[j]);
            }
            Console.ReadLine();
            */
            //嵌套循环处理二维数组
            /*
            int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            int i, j;
            for(i=0;i<5;i++)
            {
                for(j=0;j<2;j++)
                {
                    Console.WriteLine("a[{0},{1}]={2}", i,j, a[i, j]);

                }
            }
            Console.ReadLine();
            */
            //交错数组
            /*
            int[][] a = new int[][] { new int[] { 0, 0 }, new int[] { 1, 2 }, new int[] { 2, 4 }, new int[] { 3, 6 }, new int[] { 3, 6 } };

            int i, j;

            for (i=0;i<5;i++)
            {
                for(j=0;j<2;j++)
                {
                    Console.WriteLine("a[{0}][{1}]={2}", i, j, a[i][j]);
                }
            }
            Console.ReadLine();
            */
            /*
            MyArray app = new MyArray();
            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            double avg;

            avg = app.getAverage(balance, 5);

            Console.WriteLine("平均值是：{0}", avg);
            Console.ReadLine();
            */
            


        }
        
    }
}
