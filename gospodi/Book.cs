using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Printabler;

namespace Printabler
{
    public class Book:Printable
    {
        private string name;

        public Book(string name)
        {
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine("Добавить книгу " + name);
        }

        public static void PrintBooks(Printable[] printables)
        {
            for (int i = 0; i < printables.Length; i++)
            {
                if (printables[i] is Magazine)
                {
                    printables[i].Print();
                }
            }
        }
    }
}
