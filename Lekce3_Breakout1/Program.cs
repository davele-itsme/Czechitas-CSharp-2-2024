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
            // cyklus by se mohl optimalizovat tak, ze bychom meli jen polovicni cislo cyklu -> slovo.Length/2
            for(int i = 0; i < slovo.Length; i++)
            {
                if (slovo[i] != slovo[slovo.Length - 1 -i])
                {
                    //pokud prvni a posledni charakter ve stringu se nerovna, tak uz vime ze to neni palindrom
                    //tim padem pokud vratime return false, tak se for loop cyklus uz predcasne ukonci a nebude dal pokracovat v dalsich cyklech
                    return false;
                }
            }
            //Tim ze for cyklus dobehl jsme si jisti ze slovo je palindrom

            return true;
        }

        for (int i = 0; i < slova.Length; i++)
        {
            bool jeSlovoPalindrom = JePalindrom(slova[i]);
            if (jeSlovoPalindrom)
            {
                Console.WriteLine(slova[i]);
            }
        }




        //Ukol - opravte v tomto textu omylem zapnuty Caps Lock
        string capsLock = "jAK mICROSOFT wORD POZNA ZAPNUTY cAPSLOCK";

        //Ukol - rozsifrujte tuto zpravu - text byl zasifrovan tak, ze jsme kazde pismeno posunuli o jedno doprava: 'a' -> 'b'. 
        string sifra = "Wzcpsob!qsbdf!.!hsbuvmvkj!b!ktfn!ob!Ufcf!qztoz";

    }
}