using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;

    };
    class Program
    {
        static void Main(string[] args)
        {
            Books Book1;
            Books Book2;

            Book1.title = "C Programming";
            Book1.author = "Nuha Ali";

            Book2.title = "ajjajaj";
            Book2.author = "123";

            Console.WriteLine(Book2.author);
            Console.WriteLine(Book1.author);


        }
    }
}
