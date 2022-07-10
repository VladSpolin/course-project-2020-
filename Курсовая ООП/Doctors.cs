using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_ООП
{
    class Doctors: Person
    {

        public double price;
        public Doctors(string name, string surname, string otchestvo, double price): base(name, surname, otchestvo)
        {
            this.price = price;
        }
        public double GetPrice()
        {
            return price;
        }
        public string InfoDoctor()
        {
            string x= base.Info()+$"\nСтоимость услуги - {price}р";
            return x;
        }
    }
}
