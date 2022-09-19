using System;
using System.Linq;
using System.Text;
using System.Net.Http;
using CatMaster;

namespace Cat
{
    class Program
    {
        static public void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.WriteLine(args[0]);
            Console.ReadKey();
        }
    }
}