namespace Lekce8_Breakout1.PohadkoveBytosti;

public class Carodejnice : PohadkovaBytost
{
    public int VelikostKotle { get; set; }
    public override void NapisJakTravisVolnyCas()
    {
        Console.WriteLine("Varim lektvary.");
    }
}