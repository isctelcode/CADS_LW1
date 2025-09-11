using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADS_LW1
{
    //наследование от класса Mammal
    internal class Artiodactyl : Mammal
    {
        //конструкторы
        public Artiodactyl(string name, string gender, int age)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }

        public Artiodactyl()
        {
            this.name = "Unknown";
            this.gender = "Unknown";
            this.age = 0;
        }
    }
}
