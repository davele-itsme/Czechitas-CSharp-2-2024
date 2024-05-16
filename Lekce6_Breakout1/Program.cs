namespace Lekce6_Breakout;

public class Program
{
    public static void Main()
    {
        // BREAKOUT ROOM 1
        //  Vytvoř třídu Obdelnik (tak, aby byla v samostatnem souboru Obdelnik.cs), která bude mít dva fieldy: Sirka a Vyska.
        //  Vytvoř konstruktor třídy Obdelnik s parametry sirka a vyska.
        //  Přidej do třídy ještě jeden typ konstruktoru pro speciální případ obdelníku(čtverec) s jedním parametrem, který bude volat první konstruktor.
        //  Obdelniku vytvorte funkci Vypis informace, ktery vypise vysku a sirku.
        //  Vytvoř několik instancí třídy Obdelnik (například 2) a vypiš jejich vlastnosti pomoci metody VypisParameteryObdelniku.

        Obdelnik obdelnik1 = new Obdelnik(4, 6);
        Obdelnik ctverec = new Obdelnik(5);
        obdelnik1.VypisParameteryObdelniku();
        ctverec.VypisParameteryObdelniku();
    }
}