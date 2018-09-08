using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Book
{
    public String name;
    public String author;
    public String categories;
    public String code;

    public override String ToString()
    {

        return "";
    }
}
enum Days { Sun,EE,EEe}
namespace Animal
{
    class Program
    {
        

        static void Main(string[] args)
        {

            string a = "tang khanh nguyen";

            foreach(char i in a)
            {
                Console.WriteLine(i);
            }
            Book book;
            book.name = "Dac nhan tam";
            book.author = "Dar";

            
            
           




            Console.ReadKey();

        }

        static void changeBook(Book book1)
        {
            book1.name = "change book";
        }

        static void change(int[] arr)
        {
            arr[0] = 1;
        }

        static void Listparams(params Object[] arr)
        {

            if(arr.Length >= 2)
            {
                if (arr[0] is String)
                {
                    Console.WriteLine("a[0] is String");
                }
                if (arr[1] is float)
                {
                    Console.WriteLine("a[1] is int");
                }
            }
            
        }
    }
}
