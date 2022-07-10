using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_ООП
{
    class Person
    {
        string name;
        string surname;
        string otchestvo;
        public Person(string name, string otchestvo, string surname)
        {
            this.name = name;
            this.surname = surname;
            this.otchestvo = otchestvo;
        }
        public string Info()
        {
            string x = $"{name} {otchestvo} {surname}";
            return x;
        }
    }
}
