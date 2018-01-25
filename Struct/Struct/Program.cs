using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Books
    {
        private string title;
        private string author;
        private string subject;
        private string book_id;
        public void getValues(string t, string a, string s, string id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }
        public void display()
        {
            Console.WriteLine("Title:{0}", title);
            Console.WriteLine("Author:{0}", author);
            Console.WriteLine("Subject:{0}", subject);
            Console.WriteLine("Book_id:{0}", book_id);
        }
    };
    public class testStructure
    {
        public static void Main(string[] args)
        {
            Books Book1 = new Books();
            Books Book2 = new Books();

            Book1.getValues("C Programming", "Nuha Ali", "C Programming", "6495407");
            Book2.getValues("Telecom Billing", "Zara Ali", "Telecom Billing Tutorial", "64957000");

            Book1.display();
            Book2.display();


        }




        /*
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
        */
    }
}
