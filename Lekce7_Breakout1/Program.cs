using System;
using Lekce7_Breakout1.ZoologickaZahrada;

public class Program
{
    //navrhnete vhodnou strukturu trid, ktera umozni v programu (v Mainu) vytvorit seznam zviratek v zoo koutku (List), 
    //ktery pak muzeme jednoduse projit cyklem (foreach) a zadat kazdemu z nich prikaz VydavejZvuk
    //pritom kazde zviratko bude vydavat jiny zvuk (vypise na konzoli Haf, haf nebo Mnau, mnau)
    //v ramci cyklu nechci resit, jake konkretni zviratko to je
    //vytvorte alespon 3 ruzna zviratka
    //hint: budete potrebovat vhodnou bazovou tridu a virtual/abstract a override
    
    //3 pilire OOP (object oriented programming)
    //1 - zapouzdreni
    //2 - dedicnost
    //3 - polymorfismus
    public static void Main()
    {
        Zirafa zirafa = new Zirafa(5, "Zirafa", 4);
        Kun kun = new Kun(10, "Kun", 50);

        Zvire zvire = zirafa;
        //Nelze priradit jakykoliv datovy typ
        //Zvire zvire2 = "";
        //Zvire zvire3 = 5;
        
        ZoologickaZahrada olomouckeZoo = new ZoologickaZahrada();
        olomouckeZoo.PridejZvire(zirafa);
        olomouckeZoo.PridejZvire(kun);
        
        olomouckeZoo.VypisVsechnyZvirata();
    }
}