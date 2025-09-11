﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADS_LW1
{
    internal class Animal
    {
        //поле данных
        protected string name;
        protected string gender;
        protected int age;

        //геттеры и сеттеры для поля данных с проверкой на корректность
        public string Name { get; set; }
        public string Gender
        {
            get
            { return gender; }
            set
            {
                while (true)
                {
                    if (value != "Male" || value != "Female") { Console.Write("Wrong gender, try again: "); }
                    else
                    {
                        gender = value;
                        break;
                    }
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                while (true)
                {
                    if (value < 0) { Console.Write("Wrong gender, try again: "); }
                    else
                    {
                        age = value;
                        break;
                    }
                }
            }
        }

        //конструкторы
        public Animal(string name, string gender, int age)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }

        public Animal()
        {
            this.name = "Unknown";
            this.gender = "Unknown";
            this.age = 0;
        }

        //метод для вывода данных объекта   
        public void getInformation()
        {
            Console.WriteLine("Наименование: {0}", name);
            Console.WriteLine("Пол: {0}", gender);
            Console.WriteLine("Возраст: {0}", age);
            Console.WriteLine();
        }
    }
}
