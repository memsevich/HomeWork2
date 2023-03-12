using System;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class program
           {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name);
            Console.WriteLine("Очень приятно," + name + "Меня зовут Олег!")


        }
    }
}