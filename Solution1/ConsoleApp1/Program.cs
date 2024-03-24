// See https://aka.ms/new-console-template for more information


using ConsoleApp1;
using System;

//Console.WriteLine("satf");

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kontener k = new KontenerNaPlyny(1, 1, 1, 1, false);
            Kontener c = new KontenerNaPlyny(1, 1, 1, 1, false);
            Kontener gass = new KontenerNaGaz(700, 1, 1, 5000, 3);
            Kontener gaz = new KontenerNaGaz(800, 1, 1, 5000, 3);

            Kontenerowiec KK = new Kontenerowiec(100, 100);
            
            gass.zaladowanie(300);
            gass.zaladowanie(300);
            gass.oproznienie();
            
            KK.ListaKontenerow.Add(k);
            KK.ListaKontenerow.Add(c);
            KK.ListaKontenerow.Add(gass);
            Console.WriteLine("listakontenerow");
            
            foreach (Kontener el in KK.ListaKontenerow)
            {
                Console.WriteLine(el);
            }
            
            KK.zaladujKontener(gaz);
        }
    }
}




