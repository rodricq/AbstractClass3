using System;

namespace AbstractClass3
{
   abstract class Animal
    {
        protected string name;
       //abstract method
       public abstract string Name
        {
            get;
            set;
        }
    }

    //inheriting from abstract class
    class Dog : Animal
    {
        //provide implimantation of abstract method
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string [] args)
        {
            //create an object of Dog class
            Dog obj = new Dog();
            obj.Name = "Tom";
            Console.WriteLine("Name: " + obj.Name);

            Console.ReadLine();
        }
    }
}
