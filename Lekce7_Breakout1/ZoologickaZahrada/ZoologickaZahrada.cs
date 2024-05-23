namespace Lekce7_Breakout1.ZoologickaZahrada;

public class ZoologickaZahrada
{
    public List<Zvire> Zvirata { get; init; }

    public ZoologickaZahrada()
    {
        Zvirata = new List<Zvire>();
    }
    
    public void PridejZvire(Zvire zvire)
    {
        Zvirata.Add(zvire);
    }
    
    public void VypisVsechnyZvirata()
    {
        foreach (var zvire in Zvirata)
        {
            Console.WriteLine($"{zvire.Druh} {zvire.Vek} let");
        }
    }
    
    public void OdeberZvire(Zvire zvire)
    {
        Zvirata.Remove(zvire);
    }
}