using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;  //文件

namespace ConsoleApp1
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(File.Exists(@"E:\c#"));  //查看是否有文件
    //        Console.WriteLine(Directory.Exists(@"E:\c#"));  //查看是否有文件夹

    //        String path = "."; //获取当前路径

    //        DirectoryInfo dir = new DirectoryInfo(path);  //实例化一个类，初始化一个开始的类
    //        foreach (FileInfo b in dir.GetFiles("*.exe"))  //使用里面的
    //        {
    //            string name = b.Name;
    //            long size = b.Length;
    //            DateTime creationTime = b.CreationTime;
    //            Console.WriteLine("{0,-12:NO} {1,-20:g} {2}", size, creationTime, name);

    //        }
    //        Console.ReadLine();
             
    //    }
    //}


    //class test  //新建文件写入
    //{
    //    private const string FILE_NAME = "Test.txt";

    //    static void Main(string[] args)
    //    {
    //        if(File.Exists(FILE_NAME))
    //        {
    //            Console.Write("{0} already exists!", FILE_NAME);
    //            Console.ReadLine();
    //            return;

    //        }
    //        else
    //        {
    //            FileStream fs = new FileStream(FILE_NAME, FileMode.Create); // 文件流类 ，可含有15个参数
    //            //FileMode 指定文件打开方式——>create新建一个文件
    //            BinaryWriter w = new BinaryWriter(fs);  //实例化写入类
    //            for(int i=0;i<11;i++)
    //            {
    //                w.Write("s");
    //            }
    //            w.Close();
    //            fs.Close();

    //        }


    //    }

    //}

   //class test02 //原有文件写入
   // {
   //     static void Main(string [] args)
   //     {
   //         using (StreamWriter w = File.AppendText("Test.txt"))  //using 可以节省资源，连接数据库
   //         {
   //             Log("hehe", w);
   //             Log("Hello wujingtao", w);
   //             w.Close();
   //         }
   //     }

   //     public static void Log(string logMessage,TextWriter w)
   //     {
   //         w.Write("Entry:");
   //         w.WriteLine(" :{0}", logMessage);

   //         w.Flush();
   //     }
   // }
    

    class Test3
    {
        private const string FILE_NAME = "Test.txt";
        static void Main(string [] args)
        {
            if (!File.Exists(FILE_NAME))
            {
                Console.WriteLine("{0} does not exist", FILE_NAME);
                Console.ReadLine();
                return;
            }

            //FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
            //BinaryReader r = new BinaryReader(fs);
            //for(int i=0;i<11;i++)
            //{
            //    Console.WriteLine(r.ReadString());
            //}
            //r.Close();
            //fs.Close();

            //Console.ReadLine();
            using (StreamReader sr = File.OpenText(FILE_NAME))
            {
                string input;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
                sr.Close();
            }

        }
    }

}
