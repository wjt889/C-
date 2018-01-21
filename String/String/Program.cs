using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //字符串,字符串连接
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            string fullname = fname + lname;
            Console.WriteLine("Full name:{0}", fullname);

            // 通过使用string 构造函数
            char[] sarray = { 'H', 'e', 'l', 'l', 'o' }; // 数组
            string greetings = new string(sarray);    //String 构造函数
            Console.WriteLine("Greetings:{0}", greetings);

            //方法返回字符串
            string[] letters = { "Hello", "From", "Tutorials", "Point" };
            string message = string.Join(" ", letters);  //" "空格
            Console.WriteLine("Message:{0}", message);

            //用于值转化的格式化方法
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = string.Format("Message sent at {0:t} on {0:D}",waiting); //{0:t} 代表的是时和分   {0:D}代表这年月日
            Console.WriteLine("Message:{0}", chat);
            Console.ReadLine();

            string str1 = "This is test";
            string str2 = "This is text";

            if (string.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + "and" + str2 + "are equal.");
            }
            else
            {
                Console.WriteLine(str1 + "and" + str2 + "are not equal.");
            }
            Console.ReadKey();

            //获取子字符串
            string str3 = "Last night I dreamt of San Pedro";
            Console.WriteLine(str3);
            string substr = str3.Substring(23);
            Console.WriteLine(substr);
            Console.ReadKey();
            
            //字符串包含字符串
            string str5 = "This is test";
            if(str5.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }
            Console.ReadKey();

            //
            string[] starray = new string[]
            {
             "Down the way night are dark",
             "I took a trip on trip"
            };

            string str = string.Join("\n", starray);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
