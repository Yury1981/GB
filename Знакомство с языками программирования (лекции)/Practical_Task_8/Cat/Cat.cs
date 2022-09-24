using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats
{
    class Cat
    {
        private string? name;
        private string? breed;
        private float weight;
        private byte age;

        public void SetValues(string _name, string _breed, float _weight, byte _age)
        {
            name = _name;
            breed = _breed;
            weight = _weight;
            age = _age;
        }
        public void PrintValues()
        {
            Console.WriteLine(name + ", " + breed + ", weight: " + weight + ", age: " + age);
        }
    }
}