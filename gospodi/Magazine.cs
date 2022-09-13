using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printabler
{
    public class Magazine : Printable
    {
        private string name;
        public  Magazine(string name)
        {
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine("Добавить журнал " + name);
        }

        public static void PrintMagazine(Printable[] printables)
        {
            for (int i = 0; i < printables.Length; i++)
            {
                if (printables[i] is Book)
                {
                    printables[i].Print();
                }
            }
        }
    }
}
