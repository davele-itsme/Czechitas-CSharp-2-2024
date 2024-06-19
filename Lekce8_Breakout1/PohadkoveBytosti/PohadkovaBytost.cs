using System.Xml.Serialization;

namespace Lekce8_Breakout1.PohadkoveBytosti;

[XmlInclude(typeof(Princezna))]
[XmlInclude(typeof(Carodejnice))]
[XmlInclude(typeof(Rytir))]
public abstract class PohadkovaBytost
{
    public string Jmeno { get; set; }
    public int Vek { get; set; }
    public string BarvaObleceni { get; set; }
    public abstract void NapisJakTravisVolnyCas();
}