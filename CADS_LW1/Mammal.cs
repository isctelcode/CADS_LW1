using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADS_LW1
{
    //наследование от класса Animal
    internal class Mammal : Animal
    {
        //конструкторы
        public Mammal(string name, string gender, int age)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }

        public Mammal()
        {
            this.name = "Unknown";
            this.gender = "Unknown";
            this.age = 0;
        }
    }
}
