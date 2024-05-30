namespace Lekce8_Breakout2;

public class Kruh : IUmimPocitatObvod, IUmimPocitatObsah
{
    private double _polomer;
    
    public Kruh(double polomer)
    {
        _polomer = polomer;
    }
    
    public double SpocitejObvod()
    {
        return 2 * Math.PI * _polomer;
    }

    public double SpocitejObsah()
    {
        return Math.PI * _polomer * _polomer;
    }
}