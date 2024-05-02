

namespace Lekce4_Breakout2
{
    internal class TelefonniSeznam
    {
        private Dictionary<string, int> telefonniSeznam;


        public TelefonniSeznam() 
        { 
            telefonniSeznam = new Dictionary<string, int>
            {
                { "David", 123123123 },
                { "Tomas", 234234234 },
                { "Alena", 456456456 }
            };
        }

        public void NovyZaznam(string jmeno, int telefonniCislo)
        {
            telefonniSeznam.Add(jmeno, telefonniCislo);
        }

        public int VratTelefonniCislo(string jmeno)
        {
            bool nasloSe = telefonniSeznam.TryGetValue(jmeno, out int telefonniCislo);
            if (nasloSe)
            {
                return telefonniCislo;
            }

            return 0;
        }

        public void VypisVse()
        {
            /*foreach(var par in telefonniSeznam)
            {
                string jmeno = par.Key;
                int telefonniCislo = par.Value;
            }*/

            //stejny zapis, ale s "deconstruction": https://www.interact-sw.co.uk/iangblog/2018/04/12/deconstruct-keyvaluepair
            foreach (var (jmeno, telefonniCislo) in telefonniSeznam)
            {
                Console.WriteLine($"{jmeno}: {telefonniCislo}");
            }
            
        }
    }
}
