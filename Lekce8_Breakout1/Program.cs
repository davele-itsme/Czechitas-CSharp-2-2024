using System;
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
        
        PohadkovaBytost princezna = new Princezna();
        PohadkovaBytost rytir = new Rytir();
        PohadkovaBytost carodejnice = new Carodejnice();
        
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
    }
}