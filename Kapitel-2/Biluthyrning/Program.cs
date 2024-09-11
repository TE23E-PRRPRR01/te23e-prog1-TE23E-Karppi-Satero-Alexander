// Program för att räkna ut kostnaden för biluthyrning
Console.Clear();
Console.WriteLine("Program för att räkna ut kostnaden för biluthyrning");

// Läsa in antal mil och antal dagar
Console.Write("Hur många mil ska du hyra för? ");
double mil = double.Parse(Console.ReadLine());

Console.Write("Hur många dagar ska du hyra för? ");
double dagar = double.Parse(Console.ReadLine());

// Räkna ut totala pris
double kostnad = 500 + (mil * 5) + (dagar * 100);

// Skriva ut resultatet
Console.WriteLine($"Totala kostnaden blir {kostnad}");