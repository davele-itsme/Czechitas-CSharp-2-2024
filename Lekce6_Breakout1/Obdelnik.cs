namespace Lekce6_Breakout;

public class Obdelnik
{
    public double Sirka;
    public double Vyska;
    
    public Obdelnik(double sirka, double vyska)
    {
        if (sirka <= 0)
        {
            throw new ArgumentException("Sirka musi byt vetsi nez 0");
        }
        
        if (vyska <= 0)
        {
            throw new ArgumentException("Vyska musi byt vetsi nez 0");
        }
        
        Sirka = sirka;
        Vyska = vyska;
    }

    //5
    public Obdelnik(double strana) : this(strana, strana)
    {
        //Ctverec
    }

    public void VypisParameteryObdelniku()
    {
        Console.WriteLine($"Sirka: {Sirka}, Vyska: {Vyska}");
    }
}