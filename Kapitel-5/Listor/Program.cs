/* // Använda listor för skapa/hantera samlingar
Console.Clear();

// Lista på trevliga frukter, t.ex "äpple", "apelsin", "annanas"
List<string> frukter = ["äpple", "apelsin", "annanas"];

Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// Ändra i listan:
frukter[0] = "banan";
Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// Gå igenom listan = loopa igenom = från första till sista 
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
} */



List<int> nummer = [1, 2, 3, 4];

// Gå igenom listan = loopa igenom = från första till sista 
foreach (var numret in nummer)
{
    Console.Write($"{numret} ");
}
for (int i = 0; i < nummer.Count; i++)
{

    Console.Write($"{nummer[i]}");
}

Console.Clear();

// Skapa ett register
// En tom lista 
List<string> namnlista = [];

// Läs in flera namn while-loop
while (true)
{
    Console.Write("Ange ett namn: ");
    namnlista.Add(Console.ReadLine());

    // Skriv ut hela listan på en rad
    foreach (var namn in namnlista)
    {
        Console.Write($"{namn}, ");
    }
    Console.WriteLine();
}


