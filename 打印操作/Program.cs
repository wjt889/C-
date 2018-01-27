using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 打印操作
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        void Print(Document doc)
        {
            doc.Init(); 
            doc.SetParameters();
            doc.Print();
        }
    }
    abstract class Document
    {
        public abstract void Init();
        public abstract void SetParameters();
        public abstract void Print();

    }
    class PDF:Document
    {
        public override void Init()
        {
            Console.WriteLine("PDF打印初始化中...");
        }

        public override void SetParameters()
        {
            Console.WriteLine("PDF参数设定中...");
        }

        public override void Print()
        {
            Console.WriteLine("正在打印PDF...");
        }
    }
    class BMP:Document
    {
        public override void Init()
        {
            Console.WriteLine("BMP打印初始化中...");
        }

        public override void SetParameters()
        {
            Console.WriteLine("BMP参数设定中...");
        }

        public override void Print()
        {
            Console.WriteLine("正在打印BMP文件");
        }
    }
}
