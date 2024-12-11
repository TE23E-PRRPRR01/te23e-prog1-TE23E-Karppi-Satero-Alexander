Console.Clear();
Console.WriteLine("Filmregister");

// Lista för att lagra filmer
List<string> listaFilmer = [];

// Be användaren ange antal

Console.Write("Ange antal filmer per sida (3-5): ");
int antal = 0;

while (true)
{
    bool succes = int.TryParse(Console.ReadLine(), out antal);
    if (succes == true)
    {
        break;
    }
    else
    {
        Console.WriteLine("Fel!, var god mata in ett heltal");
    }
}

// Programloop
while (true)
{
    // Visa en meny
    Console.Write("""

    1. Lägg till filmer
    2. Lista alla filmer
    3. Sök en film  
    4. Avsluta  
    Välj ett alternativ:
    """);
    string val = Console.ReadLine();
    Console.WriteLine("");

    // Hanterar med valet
    if (val == "1")
    {
        // Lägg till filmer i listan
        for (var i = 0; i < antal; i++)
        {
            Console.Write("Ange filmer att lägga till: ");
            listaFilmer.Add(Console.ReadLine());
        }
    }
    else if (val == "2")
    {
        // Skriv ut alla filmer
        foreach (var filnamn in listaFilmer)
        {
            Console.WriteLine($"- {filnamn}");
        }
    }
    else if (val == "3")
    {
        // Sök en film
        Console.Write("Ange en film att söka efter (första bokstaven): ");
        string bokstav = Console.ReadLine();
        foreach (var filmnamn in listaFilmer)
        {
            // Kolla om varje film börjar med bokstaven
            if (filmnamn.StartsWith(bokstav))
            {
                Console.WriteLine($"- {filmnamn}");
            }
        }
    }
    else if (val == "4")
    {
        Console.WriteLine("... Avslutar ...");
        break;
    }
    else
    {
        Console.WriteLine("Fel val. Försök igen");
    }
}