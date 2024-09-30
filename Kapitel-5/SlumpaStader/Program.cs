// Slumpa två av tio städer
Console.Clear();
Console.WriteLine("Slumpa två av tio städer!");

// En lista städer
List<string> städer = ["Stockholm", "Malmö", "Göteborg", "Helsingborg", "Kiruna", "Luxembourg", "London", "Paris", "Linköping", "Visby"];

int antal = 2;
while (antal > 0 )
{
    // Slumpa index 0-12
    int index = Random.Shared.Next(0, 10);

    // Plocka ut den slumpade staden
    string stad = städer[index];

    // Skriv ut kortet
    Console.WriteLine($"Den slumpade staden är {stad}");

    // Räkna ned
    antal--;
}
