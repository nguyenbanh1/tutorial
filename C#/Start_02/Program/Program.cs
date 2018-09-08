using System;
using System.IO;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Retangle(1, 2, 3);
            //s.Width = 3;
            //s.Height = 3;

            //Console.WriteLine(s.ToString());



            //Animal a = new Dog("dog", 13);
            //a.Display();

            try
            {
                Console.WriteLine("value : " + divide(3, 0));
            }catch(Exception ex)
            {
                Console.WriteLine("error " + ex);
            }
            finally
            {
                Console.WriteLine("value : 0");
            }

            FileStream fileStream = new FileStream("test.txt", FileMode.Open, FileAccess.Read);

            

            //for(int i = 0;i < 20; i++)
            //{
            //    filestream.writebyte((byte)i);
            //}



            //fileStream.Position = 0;

            if (fileStream.CanRead)
            {
                Console.WriteLine("this file can read.");
                for(int i = 0;i< 20; i++)
                {
                
                    Console.Write((char)fileStream.ReadByte());
                }
                


            }
            fileStream.Close();


            Console.ReadKey();

        }

        public static float divide(int a, int b)
        {
            if(b == 0)
            {
                throw new MyFirstException("error dang nhap mau bang 0");
            }
            return a / b;
        
        }
    }


}
