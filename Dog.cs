using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03_20024
{
    public class Dog : IAnimal
    {
        public int Id;

        public string Name { get; set; }
        public int Age { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("Bark");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age {Age}";
        }

    }
}
