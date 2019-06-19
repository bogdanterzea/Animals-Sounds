using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Farm
    {
        string animal;
        string sound;
        public Farm(string nume, string sunet) {
            animal = nume;
            sound = sunet;
        }
        static void Main(string[] args)
        {
            Farm element = new Farm("Puiul", "PIU");
            Farm element1 = new Farm("Vaca", "MUU");
            Farm element2 = new Farm("Oaia", "BEE");
            Farm element3 = new Farm("Porcul", "GUIT");

            Console.WriteLine(element.animal + " scoate sunetul " + element.sound);
            Console.WriteLine(element1.animal + " scoate sunetul " + element1.sound);
            Console.WriteLine(element2.animal + " scoate sunetul " + element2.sound);
            Console.WriteLine(element3.animal + " scoate sunetul " + element3.sound);

            Console.ReadKey();
        }
    }
}
