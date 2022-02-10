using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_абстрактные_классы
{
    class Dog:Animal
    {
        public override string Name { get; set; }
        public Dog(string name) : base(name) { }
        public override void Say()
        {
            Console.WriteLine("гав");
        }
    }
}
