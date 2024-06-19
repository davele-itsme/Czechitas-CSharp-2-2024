using System;
using System.Xml.Serialization;
using Lekce8_Breakout1.PohadkoveBytosti;

public class Program
{
    public static void Main()
    {
        // Vytvořte abstraktní třídu PohadkovaBytost a v ní abstraktní metodu NapisJakTravisVolnyCas
        // Vytvorte tridy Princezna, Rytir, Carodenice, ktere dedi PohadkovouBytost
        // Naimplementujte metodu NapisJakTravisVolnyCas - vypsanemu textu na konzoli se meze nekladou
        // Vytvorte instance od kazde tridy a vypiste informace o trávení volného času.
        // Ulozit do kolekce.
        
        PohadkovaBytost princezna = new Princezna
        {
            BarvaObleceni = "Ruzova",
            Jmeno = "Princezna",
            Vek = 20,
            VelikostBoty = 38
        };
        PohadkovaBytost rytir = new Rytir
        {
            BarvaObleceni = "Striborna",
            Jmeno = "Rytir",
            Vek = 30,
            VelikostMece = 100
        };
        PohadkovaBytost carodejnice = new Carodejnice
        {
            BarvaObleceni = "Cerna",
            Jmeno = "Carodejnice",
            Vek = 50,
            VelikostKotle = 200
        };
        
        List<PohadkovaBytost> pohadkoveBytosti = new List<PohadkovaBytost>
        {
            princezna,
            rytir,
            carodejnice
        };
        
        // Ulozit do kolekce
        /*pohadkoveBytosti.Add(princezna);
        pohadkoveBytosti.Add(rytir);
        pohadkoveBytosti.Add(carodejnice);*/
        
        foreach (PohadkovaBytost pohadkovaBytost in pohadkoveBytosti)
        {
            pohadkovaBytost.NapisJakTravisVolnyCas();
        }
        
        XmlSerializer serializer = new XmlSerializer(typeof(List<PohadkovaBytost>));

        string cestaKApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        string cestaKPohadkoveBytosti = Path.Combine(cestaKApplicationData, "PohadkoveBytosti");
        if (!Path.Exists(cestaKPohadkoveBytosti))
        {
            Directory.CreateDirectory(cestaKPohadkoveBytosti);
        }
        
        string cestaKXmlSouboru = Path.Combine(cestaKPohadkoveBytosti, "pohadkoveBytosti.xml");

        using (StreamWriter streamWriter = new StreamWriter(cestaKXmlSouboru))
        {
            serializer.Serialize(streamWriter, pohadkoveBytosti);
        }
        
        using (StreamReader streamReader = new StreamReader(cestaKXmlSouboru))
        {
            List<PohadkovaBytost> pohadkoveBytostiDeserializovane = (List<PohadkovaBytost>)serializer.Deserialize(streamReader);
            foreach (PohadkovaBytost pohadkovaBytost in pohadkoveBytostiDeserializovane)
            {
                pohadkovaBytost.NapisJakTravisVolnyCas();
            }
        }
    }
}