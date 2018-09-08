using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    abstract class Animal
    {
        public string name;
        public int age;


        public abstract void Display();
        

    }


    class Dog : Animal
    {

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override void Display()
        {
            Console.WriteLine("Dog(name : {0}, age : {1})", this.name, this.age);
        }

    }
}
