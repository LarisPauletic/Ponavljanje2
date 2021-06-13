using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiZadatakk
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaD MainObjekt = new KlasaD();
            bool Uvjet = MainObjekt.Suprotno(true);
            int Broj = MainObjekt.Suprotno(50);
            Console.WriteLine("Suprotno od True je =  " + Uvjet);
            Console.WriteLine("Suprotno od 50 je =  " + Broj);

            Console.ReadKey();
        }
    }
}
