namespace Lekce8_Breakout2;

public class Obdelnik : IUmimPocitatObsah, IUmimPocitatObvod
{
    private double _vyska;
    private double _sirka;
    
    public Obdelnik(double vyska, double sirka)
    {
        _vyska = vyska;
        _sirka = sirka;
    }
    
    public double SpocitejObsah()
    {
        double obsah = _vyska * _sirka;
        if (obsah < 0)
        {
            throw new Exception("Obsah nemuze byt zaporny.");
        }
        return obsah;
    }

    public double SpocitejObvod()
    {
        return 2 * (_vyska + _sirka);
    }
}