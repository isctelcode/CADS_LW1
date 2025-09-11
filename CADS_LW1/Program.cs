using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//иерархия классов
//животное:
//  птица
//  млекопитающее:
//      парнокопытное

namespace CADS_LW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //инициализация объектов классов Animal, Bird и Artiodactyl
            Animal entity1 = new Animal("tortoise", "male", 143);
            Animal entity2 = new Animal();
            Animal entity3 = new Animal("python", "female", 23);
            Animal entity4 = new Animal("tarantula", "male", 17);
            Animal entity5 = new Animal("jackal", "male", 20);
            Bird entity6 = new Bird("parrot", "female", 31);
            Bird entity7 = new Bird("phoenix", "male", 4236);
            Bird entity8 = new Bird("ostrich", "female", 13);
            Artiodactyl entity9 = new Artiodactyl("deer", "male", 32);
            Artiodactyl entity10 = new Artiodactyl("deer", "female", 27);
            Artiodactyl entity11 = new Artiodactyl("horse", "male", 21);
            Artiodactyl entity12 = new Artiodactyl("mule", "male", 9);
            //инициализация массивов объектов классов
            Animal[] zoo = { entity1, entity2, entity3, entity4, entity5};
            Bird[] poultry = { entity6, entity7, entity8};
            Artiodactyl[] stable = { entity9, entity10, entity11, entity12};

            //побег животных
            weWillLeaveTheZoo(zoo);
            weWillLeaveTheZoo(poultry);
            weWillLeaveTheZoo(stable);
        }

        //перегрузка функций для объектов разных классов
        internal static void weWillLeaveTheZoo(Animal[] zoo)
        {
            for (int i = 0; i < zoo.Length; i++)
            {
                zoo[i].getInformation();
                zoo[i] = new Animal();
            }
        }
        internal static void weWillLeaveTheZoo(Mammal[] zoo)
        {
            for (int i = 0; i < zoo.Length; i++)
            {
                zoo[i].getInformation();
                zoo[i] = new Mammal();
            }
        }
        internal static void weWillLeaveTheZoo(Bird[] zoo)
        {
            for (int i = 0; i < zoo.Length; i++)
            {
                zoo[i].getInformation();
                zoo[i] = new Bird();
            }
        }
        internal static void weWillLeaveTheZoo(Artiodactyl[] zoo)
        {
            for (int i = 0; i < zoo.Length; i++)
            {
                zoo[i].getInformation();
                zoo[i] = new Artiodactyl();
            }
        }
    }
}
