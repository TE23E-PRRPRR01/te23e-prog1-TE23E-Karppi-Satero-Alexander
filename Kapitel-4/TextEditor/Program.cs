// Program för att ändra text filer
Console.Clear();
Console.WriteLine("Program för att ändra text filer");

// Variabel för val
string val = "";

// Loopar programmet tills användaren väljer Avsluta
while (true)
{
    // Visar en meny och läser in användarens val
    Console.Write("""
    1. Skriv till fil
    2. Läs från fil
    3. Avsluta programmet 
    Välj ett av alternativen (1-3): 
    """);
    val = Console.ReadLine();
    
    // Hantera användarens val
    if (val == "1")
    {
        // Skriv text till filen
        Console.Clear();
        Console.Write("Skriv in en text som du vill spara: ");
        File.WriteAllText("filnamn.txt", Console.ReadLine());
        Console.WriteLine("Texten har sparats");

    }
    else if (val == "2")
    {
        // Läs in text från fil
        Console.Clear();
        if (File.Exists("filnamn.txt"))
        {
        string text = File.ReadAllText("filnamn.txt");
        Console.WriteLine($"Texten i filen är: {text}");
            
        }
        else
        {
           Console.WriteLine("Filen finns inte, kan inte läsa text"); 
        }
    }
    else if (val == "3")
    {
        // Avslutar programmet
        Console.Clear();
        Console.WriteLine("Avslutar...");
        break;
    }
    else 
    {
        Console.Clear();
        Console.WriteLine("Ogiltigt alternativ, försök igen");
    }
}
