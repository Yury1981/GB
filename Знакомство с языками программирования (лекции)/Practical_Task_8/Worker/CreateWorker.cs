using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class CreateWorker
    {
        private string? secondname;
        private string? name;
        private string? patronymic;
        private string? profession;
        private byte age;

        public void SetValues(string _secondname, string _name, string _patronymic, string _profession, byte _age)
        {
            secondname = _secondname;
            name = _name;
            patronymic = _patronymic;
            profession = _profession;
            age = _age;
        }
        public void PrintValues()
        {
            Console.WriteLine(secondname + " " + name + " " + patronymic + ", Profession: " + profession + ", Vozrast: " + age);
        }
    }
}
