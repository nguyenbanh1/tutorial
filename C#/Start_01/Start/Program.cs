using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    public class Program
    {


        String namePrograme;
        int age;

        public Program(String namePrograme, int age)
        {
            this.namePrograme = namePrograme;
            this.age = age;

        }

        public override string ToString()
        {
            return "name : " + this.namePrograme + " , age : " + this.age;
        }




        static void Main(string[] args)
        {

            Console.WriteLine("Tang khanh nguyen");
            Student s = new Student("nguyen",15);
           
            s.display();

            Program p = new Program("C#", 30);
            Console.WriteLine(p.ToString());

            Retangle retangle = new Retangle(10, 11);
            Console.WriteLine(retangle.ToString());




            Console.Write("Enter a key to exit ");
            Console.ReadKey();
        }
    }

    class Student
    {
        private String name;
        private int age;
        public Student(String name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public void display()
        {
            Console.WriteLine("name : {0}, age : {1}", this.name, this.age);
        }



    }



}
