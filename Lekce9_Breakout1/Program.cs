using System;
using System.Collections.Generic;

public class Clovek
{
    public string Jmeno {get; set;}
    public string Prijmeni {get; set;}
    public int TelCislo {get; set;}
	
    public Clovek(string jmeno, string prijmeni, int telCislo)
    {
        Jmeno = jmeno;
        Prijmeni = prijmeni;
        TelCislo = telCislo;
    }
    
    public override string ToString()
    {
        return $"{Jmeno},{Prijmeni},{TelCislo}";
    }
}

public class Program
{
    public static void Main()
    {
        List<Clovek> telefonniSeznam = new List<Clovek>
        {
            new Clovek("Jarda", "Kadlec", 777123456),
            new Clovek("Honza", "Kratochvila", 777987654),
            new Clovek("Petr", "Novak", 778111222)
        };
		
        //1. Vytvorte slozku TelefonniSeznam v adresari Appdata pro konkretniho uzivatele
        string cestaKApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string cestaKTelefonnimuSeznamu = Path.Combine(cestaKApplicationData, "TelefonniSeznam");
        if (!Directory.Exists(cestaKTelefonnimuSeznamu))
        {
            Directory.CreateDirectory(cestaKTelefonnimuSeznamu);
        }

        //2. Do souboru telefonniSeznam.csv ulozte obsah seznamu telefonniSeznam tak,
        //   ze kazdy zaznam bude na jednom radku a oddelene budou carkami
        
        //Predelat si datovy typ cloveka do stringu
        List<string> obsah = telefonniSeznam.Select(c => c.ToString()).ToList();
        //Vytvor soubor
        string cestaKCsvSouboru = Path.Combine(cestaKTelefonnimuSeznamu, "telefonniSeznam.csv");
        File.WriteAllLines(cestaKCsvSouboru, obsah);

        //3. Napiste cyklus, ktery soubor precte a zpatky ho ulozi do noveho seznamu
        List<Clovek> novySeznam = new List<Clovek>();

        string[] prectenyLines = File.ReadAllLines(cestaKCsvSouboru);
        foreach (var linka in prectenyLines)
        {
            Console.WriteLine(linka);
        }

        //Preti mi ze souboru telefonniSeznam.csv a vytvor novy seznam ktery bude slozen z objektu Clovek
    }
}