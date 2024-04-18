
// Zbyvajici dny do dovolene
// Postupne se uzivatele zeptej na den, mesic a rok odjezdu na dovolenou. Pomoci DateTime a TimeSpan vypocitej pocet
// zbyvajicich dni do odjezdu na dovolenou a vypis je na konzoli.
// Pozn.: pro zjednoduseni staci pouzit int.Parse

Console.WriteLine("Zadej den");
string textDen = Console.ReadLine();
int den = int.Parse(textDen);

Console.WriteLine("Zadej mesic");
string textMesic = Console.ReadLine();
int mesic = int.Parse(textMesic);

Console.WriteLine("Zadej rok");
string textRok = Console.ReadLine();
int rok = int.Parse(textRok);

DateTime ted = DateTime.Now;
DateTime casDovoleny = new DateTime(rok, mesic, den);

TimeSpan casDoDovoleny = ted - casDovoleny;

Console.WriteLine($"Dny: {casDoDovoleny.Days}, Minuty: {casDoDovoleny.Minutes}");

Console.WriteLine(ted.ToString());
Console.WriteLine(ted.ToString("yyyy-MM-dd hh:mm:ss"));
Console.WriteLine(ted.ToString("dd MM yyyy hh:mm:ss"));
