Console.Clear();
Console.WriteLine("Allt om listor");

// Skapa en tom lista
List<string> listaNamn = [];

// Infoga i en lista 
listaNamn.Add("Alex");
listaNamn.Add("Alexander");
Console.WriteLine(listaNamn.Count);

// Skriv ut lista 
foreach (var namn in listaNamn)
{
    Console.WriteLine($"- {namn}");
}

// skriv ut första elementet i listan 
Console.WriteLine($"Första elementet: {listaNamn[0]}");

// Skriv ut två namn ur listan

for (var i = 0; i < 2; i++)
{
    Console.WriteLine($"Första elementet: {listaNamn[i]}");
}

// Skriv ut all namn i listan med for-loop
for (var i = 0; i < listaNamn.Count; i++)
{
    Console.WriteLine($"{i}: {listaNamn[i]}");
}