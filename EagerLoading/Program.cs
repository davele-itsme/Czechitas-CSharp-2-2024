List<string> ovoce = new List<string>() { "Merunka", "Jablko", "Pomeranc", "Meloun", "Malina", "Limetka" };

Console.WriteLine("Lazy evaluace");
Console.WriteLine("-----------------------------------");
LazyEvaluation(ovoce);

Console.WriteLine("");
Console.WriteLine("Eager evaluace");
Console.WriteLine("-----------------------------------");
EagerEvaluation(ovoce);


static void LazyEvaluation(List<string> ovoce)
{
    IEnumerable<string> lazyEvaluation = ovoce
        .Where(o =>
        {
            Console.WriteLine($"Program zprocesovava 1. Where element {o}");
            return o.StartsWith("M");
        })
        .Where(o =>
        {
            Console.WriteLine($"Program zprocesovava 2. Where element {o}");
            return o.EndsWith("a");
        });

    foreach (var o in lazyEvaluation)
    {
        Console.WriteLine("PRVNI");
        Console.WriteLine(o);
    }

    foreach (var o in lazyEvaluation)
    {
        Console.WriteLine("DRUHY");
        Console.WriteLine(o);
    }
}

static void EagerEvaluation(List<string> ovoce)
{
    List<string> lazyEvaluation = ovoce
        .Where(o =>
        {
            Console.WriteLine($"Program zprocesovava 1. Where element {o}");
            return o.StartsWith("M");
        })
        .Where(o =>
        {
            Console.WriteLine($"Program zprocesovava 2. Where element {o}");
            return o.EndsWith("a");
        }).ToList();

    foreach (var o in lazyEvaluation)
    {
        Console.WriteLine("PRVNI");
        Console.WriteLine(o);
    }

    foreach (var o in lazyEvaluation)
    {
        Console.WriteLine("DRUHY");
        Console.WriteLine(o);
    }
}


