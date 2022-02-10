using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _14_абстрактные_классы
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Укажите имя кота: ");
            string catname = ReadLine();
            Write("Укажите имя собаки: ");
            string dogname = ReadLine();
            Animal cat = new Cat(catname);
            Animal dog = new Dog(dogname);
            cat.ShowInfo();
            dog.ShowInfo();
            ReadKey();
        }
    }
}
