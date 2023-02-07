using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03_20024
{
    public class Cow : IAnimal
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("Moo");
        }
    }
}
