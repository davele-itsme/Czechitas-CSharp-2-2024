using System;
					
public class Program
{
    public static void Main()
    {

        //Ukol - Obratte poradi stringu
        string palindrom = "Kuna nese nanuk"; //15 charakteru
        string obracenyString = "";
        for (int i = palindrom.Length; i > 0; i--)
        {
            //Console.WriteLine(palindrom[i - 1]);
            obracenyString += palindrom[i - 1];
        }

        Console.WriteLine(obracenyString);

        int[] pole = new[] { 4, 5, 6 };
        int soucet = 0;
        for (int i = 0; i < pole.Length; i++)
        {
            soucet += pole[i];
            //index zacina nulou
        }

        //Ukol - Napiste funkci, ktera umi detekovat, ze se jedna o palindrom (zatim jen u slov) a pak z pole vypiste jen palindromy
        string[] slova = new string[] { "kajak", "program", "rotor", "Czechitas", "madam", "Jarda", "radar", "nepotopen" };

        static bool JePalindrom(string slovo)
        {
            return true;
        }


        for (int i = 0; i < slova.Length; i++)
        {
            
        }




        //Ukol - opravte v tomto textu omylem zapnuty Caps Lock
        string capsLock = "jAK mICROSOFT wORD POZNA ZAPNUTY cAPSLOCK";

        //Ukol - rozsifrujte tuto zpravu - text byl zasifrovan tak, ze jsme kazde pismeno posunuli o jedno doprava: 'a' -> 'b'. 
        string sifra = "Wzcpsob!qsbdf!.!hsbuvmvkj!b!ktfn!ob!Ufcf!qztoz";

    }
}