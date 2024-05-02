using System;
using System.Collections.Generic;

public class Program
{
    static public void Main()
    {
        List<double> cisla = new List<double>
        {
            0.046939913,
            0.295866297,
            0.852489925,
            0.84994766,
            0.96925183,
            0.946275497,
            0.688903175,
            0.553463564,
            0.59628254,
            0.645816929
        };

        // Vypis vsechna cisla na konzoli (nachystej si pro to funkci)
        Vypis(cisla);

        // Vypis na konzoli pocet cisel v seznamu
        VypisPocet(cisla);
        Console.WriteLine("-----------------------------------");

        // Pridej cislo 0.5 do seznamu
        cisla.Add(0.5);

        // vypis prvni cislo ze seznamu, ktere je vetsi nez 0.8
        double hledaneCislo = cisla.Find(cislo => cislo > 0.8);
        Console.WriteLine(hledaneCislo);

        // najdi nejvetsi cislo v seznamu, vypis, ktere to je, a odstran ho ze seznamu
        cisla.Sort();
        double nejvetsiCislo = cisla.Last();
        Console.WriteLine(nejvetsiCislo);
        cisla.Remove(nejvetsiCislo);

        Console.WriteLine("-----------------------------------");
        // vypis opet vsechna cisla a jejich pocet
        Vypis(cisla);
        VypisPocet(cisla);

        static void Vypis(List<double> listCisel)
        {
            foreach (double cislo in listCisel)
            {
                Console.WriteLine(cislo);
            }
        }

        static void VypisPocet(List<double> listCisel)
        {
            Console.WriteLine(listCisel.Count());
        }
    }
}