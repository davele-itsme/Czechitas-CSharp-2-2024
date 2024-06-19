namespace Lekce8_Breakout1.PohadkoveBytosti;

public class Princezna : PohadkovaBytost
{
    public int VelikostBoty { get; set; }
    public override void NapisJakTravisVolnyCas()
    {
        Console.WriteLine("Cekam na prince.");
    }
}