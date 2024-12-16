Console.Clear();

// Skapa listor
List<string> listaActionSpel = [];
List<string> listaÄventyrsSpel = [];

while (true)
{
    Console.Write("""

    a. Visa alla action-spel
    b. Registrera ett action-spel
    c. Visa alla äventyrsspel
    d. Registrera tre äventyrsspel
    e. Avsluta
    Välj ett alternativ:
    """);

    string val = Console.ReadLine();
    if (val == "a")
    {
        // Visa alla actionspel
        Console.Clear();
        Console.WriteLine("Här är alla action-spel i listan:");
        foreach (var actionSpel in listaActionSpel)
        {
            Console.WriteLine($"- {actionSpel}");
        }
    }
    else if (val == "b")
    {
        // Registrera nytt actionspel
        Console.Clear();
        Console.Write("Ange ett action-spel: ");
        listaActionSpel.Add(Console.ReadLine());
    }
    else if (val == "c")
    {
        // Visa alla äventyrsspel
        Console.Clear();
        Console.WriteLine("Här är alla äventyrsspel i listan:");
        foreach (var äventyrsSpel in listaÄventyrsSpel)
        {
            Console.WriteLine($"- {äventyrsSpel}");
        }
    }
    else if (val == "d")
    {
        // Registera tre nya äventyrsspel
        Console.Clear();
        Console.WriteLine("Lägg till tre äventyrsspel");
        for (var i = 0; i < 3; i++)
        {   
        Console.Write("Ange ett äventyrsspel: ");
        listaÄventyrsSpel.Add(Console.ReadLine());
        }
    }
    else if (val == "e")
    {
        // Avsluta
        break;
    }
    else
    {
        // Felmeddelande vid ogilitig input
        Console.Clear();
        Console.WriteLine("Välj ett av alternativen");
    }
}
