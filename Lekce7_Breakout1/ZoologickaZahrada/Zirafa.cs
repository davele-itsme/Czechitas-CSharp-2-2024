namespace Lekce7_Breakout1.ZoologickaZahrada;

public class Zirafa : Zvire
{
    public int PocetNohou { get; private set; }
    
    public Zirafa(int vek, string druh, int pocetNohou) : base(vek, druh)
    {
        PocetNohou = pocetNohou;
    }

    public override void VydavejZvuk()
    {
        Console.WriteLine("zif zif");
    }
}