// Övningar
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

// En lista med namn
List<string> namnLista = ["Anna", "Björn", "Cecilia"];

// Skriv ut listan
Console.WriteLine($"Listan är {string.Join(", ", namnLista)}");

// Skapa en meny
while (true)
{
    // Be användaren göra ett val
    Console.WriteLine("""
    1. Lägg till ett namn
    2. Ta bort ett namn
    3. Sök efter namn
    4. Sortera listan
    5. Töm listan
    6. Visa antal namn
    7. Avsluta

    """);
    string val = Console.ReadLine();
    if ("1" == val)
    {
        Console.Clear();
        // Be användaren lägga till ett namn
        Console.Write("Lägg till ett namn: ");
        string namnAttLäggaTill = Console.ReadLine();

        // Kollar ifall namnet redan finns i listan
        if (namnLista.Contains(namnAttLäggaTill))
        {
            Console.WriteLine("Fel: namnet finns redan med i listan");
        }
        else
        {
            // Lägger till namnet i listan
            namnLista.Add(namnAttLäggaTill);

            // Skriver ut listan med ett extra namn
            Console.WriteLine($"Listan efter tilläg är {string.Join(", ", namnLista)}");
        }

    }
    else if ("2" == val)
    {
        Console.Clear();
        // Loopar tills ett namn är borttaget
        while (true)
        {
            // Be användaren om ett namn som ska bort
            Console.Write("Ange ett namn att ta bort: ");
            string namnAttTaBort = Console.ReadLine();

            // Kollar om namnet är med i listan
            if (namnLista.Contains(namnAttTaBort))
            {
                namnLista.Remove(namnAttTaBort);
                break;
            }
            else
            {
                Console.WriteLine($"Fel: {namnAttTaBort} finns inte med i listan.");
            }
        }

        // Skriv ut listan efter borttagning
        Console.WriteLine($"Listan efter borttagning: {string.Join(", ", namnLista)}");
    }
    else if ("3" == val)
    {
        Console.Clear();
        // Fråga användaren om ett namn att söka efter
        Console.Write("Ange ett namn att söka efter: ");
        string söktaNamn = Console.ReadLine();
        // Leta efter namnet i listan
        if (namnLista.Contains(söktaNamn))
        {
            Console.WriteLine($"{söktaNamn} finns i listan.");
        }
        else
        {
            Console.WriteLine($"{söktaNamn} finns inte i listan.");
        }
    }
    else if ("4" == val)
    {
        Console.Clear();
        // Sortera listan
        namnLista.Sort();
        Console.WriteLine($"Listan sorterad i alfabetisk ordning: {string.Join(", ", namnLista)}");
    }
    else if ("5" == val)
    {
        Console.Clear();
        // Tömmer listan
        namnLista.Clear();
        Console.WriteLine("Listan är tömd");
    }
    else if ("6" == val)
    {
        Console.Clear();
        // Visar antal namn i listan
        Console.WriteLine($"Det finns {namnLista.Count} namn i listan.");
    }
    else if ("7" == val)
    {
        break;
    }
}