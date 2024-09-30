// Hur man skapar och använder listor
Console.Clear();
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Slumpa kort ur en kortlek!");

// Skapa en lista kort 
List<string> kortlek = ["🂡", "🂢", "🂣", "🂤", "🂥", "🂦", "🂧", "🂨", "🂩", "🂪", "🂫", "🂭", "🂮"];

// Ett annat exempel- Lista på 3 årtal
// List<int> årtal = [1957, 1969, 1989];

int antal = 5;
while (antal > 0 )
{
    // Slumpa index 0-12
    int index = Random.Shared.Next(0, kortlek.Count);
    // Console.WriteLine($"Det slumpade index = {index}");

    // Plocka ut det slumpade kortet
    string kort = kortlek[index];

    // Ta bort kortet ur kortleken
    kortlek.RemoveAt(index);

    // Skriv ut kortet
    Console.WriteLine($"Det slumpade kortet är {kort}");

    // Räkna ned
    antal--;
}
