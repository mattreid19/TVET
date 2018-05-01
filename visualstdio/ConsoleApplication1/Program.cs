using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Color
    {
        public float r, g, b;
    }

    class Dog
    {
        public string name;
        public int age;
        public string breed;
        public Color color;
        public void Speak()
        {
            Console.WriteLine(name + "is speakng:BARK!");
        }
        public void walk()
        {
            Console.WriteLine(name + "is walking");
        }
        public void sit()
        {
            Console.WriteLine(name + " is sitting");
        }
        public void WagTail()
        {
            Console.WriteLine(name = "is wagging it's tail");
        }





    }

    class Program
    {
        static void Main(string[] args)
        {
            Color red = new Color();
            red.r = 1;
            red.g = 0;
            red.b = 0;


            Dog dog1 = new Dog();
            dog1.name = "Lassie";
            dog1.breed = "poodle";
            dog1.age = 1;
            dog1. = .color;


            dog1.GetInfo();

            dog1.Speak();
            dog1.walk();

            Console.ReadLine();
        }
    }
}
