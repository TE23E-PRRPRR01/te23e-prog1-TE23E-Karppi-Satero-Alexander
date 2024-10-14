// Ett litet namnregister
Console.Clear();
Console.WriteLine("Ett litet namnregister");

// Skapa en tom lista
List<string> namnlista = [];

// Programloopen
while (true)
{
    // Visa en meny
    Console.Write("""
1. Registrera namn
2. Skriva ut namnregistret
3. Avsluta 
Ange ditt val (1/2/3): 
""");
    string val = Console.ReadLine();
    Console.Clear();

    if (val == "1")
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Ange ett namn tills du skriver stop: ");
            string namn = Console.ReadLine();
            
            if ( namn == "stop")
            {
                break;
            }
            else
            {
                namnlista.Add(namn);
            }
        }
    }
    else if (val == "2")
    {
        foreach (var namn in namnlista)
        {
            Console.Write($"{namn}, ");
        }
        Console.WriteLine();
    }
    else if (val == "3")
    {
        break;
    }

}