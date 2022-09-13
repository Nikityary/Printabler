using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printabler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printable[] printables = new Printable[6];
            printables[0] = new Book("1984");
            printables[1] = new Magazine("Класный журнал");
            printables[2] = new Book("Портрет Дориана Грея");
            printables[3] = new Magazine("Дневник гадалки");
            printables[4] = new Book("Преступление и наказание");
            printables[5] = new Magazine("Саратовские будни");

            foreach (Printable printable in printables)
            {
                printable.Print();
            }
            Console.WriteLine("\nЖурналы:\n");
            Book.PrintBooks(printables);
            Console.WriteLine("\nКниги:\n");
            Magazine.PrintMagazine(printables);

            Console.ReadKey();
        }
        
    }
}
