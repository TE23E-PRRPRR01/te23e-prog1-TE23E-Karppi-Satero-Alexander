// Ett litet spel - gissa ett hemligt heltal
using System.Security.Cryptography;

Console.Clear();
Console.WriteLine("Ett litet spel - gissa ett hemligt heltal");

// Slumpa ett tal
int slumpTalet = Random.Shared.Next(1, 101); // 1-100
Console.WriteLine($"Slumptalet är {slumpTalet}");

Console.Write("Gissa ett tal 1-100 ");
// Läs in texten, t.ex. "100"
string gissningText = Console.ReadLine();
// Konvertera texten till ett heltal, blir 100
int gissning = int.Parse(gissningText);

if (gissning == slumpTalet)
{
    Console.WriteLine("Bra, du har gissat rätt!");
}
else if (gissning > slumpTalet)
{
    Console.WriteLine("Gissningen är för hög");    
}
else
{   
    Console.WriteLine("Gissningen är för låg");
}