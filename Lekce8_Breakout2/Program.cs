using System;
using Lekce8_Breakout2;

public class Program
{
    public static void Main()
    {
        //napiste dva ruzne interfacy: IUmiPocitatObsah, IUmiPocitatObvod
        //implementujte tridy obdelnik a kruh, ktere oba interfacy pouzivaji
        //vlozte jejich instance do seznamu a zavolejte na nich prislusne metody na vypocet obsahu a obvodu
        
        var kruh = new Kruh(5);
        var obdelnik = new Obdelnik(5, 10);
        IUmimPocitatObsah obsah = kruh;
        IUmimPocitatObsah obsah1 = obdelnik;
        
        IUmimPocitatObvod obvod = kruh;
        IUmimPocitatObvod obvod1 = obdelnik;
        
        List<IUmimPocitatObvod> obvody = new List<IUmimPocitatObvod>
        {
            obvod,
            obvod1
        };
        
        List<IUmimPocitatObsah> obsahy = new List<IUmimPocitatObsah>
        {
            obsah,
            obsah1
        };
        
        foreach (IUmimPocitatObvod o in obvody)
        {
            Console.WriteLine(o.SpocitejObvod());
        }
        
        foreach (IUmimPocitatObsah o in obsahy)
        {
            Console.WriteLine(o.SpocitejObsah());
        }
    }
}