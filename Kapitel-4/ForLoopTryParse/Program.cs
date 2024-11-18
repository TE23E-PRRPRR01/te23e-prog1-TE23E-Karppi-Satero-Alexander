// Övningar
Console.Clear();
Console.WriteLine("Diverse program");

bool lyckades = false;

// Programloop
while (true)
{
    // Återställer variabeln
    lyckades = false;

    // Användaren får välja vilket program
    Console.WriteLine("""

    Välj program:
    1. Loopa ditt namn x antal gånger
    2. Matte
    3. Avsluta 
    """);
    string val = Console.ReadLine();

    Console.Clear();

    // Kollar efter vilket val
    if (val == "1")
    {
        // Frågar och sparar användarens namn
        Console.Write("Ange ditt namn: ");
        string namn = Console.ReadLine();

        // Loopar tills TryParse ger ett värde
        while (lyckades == false)
        {

            Console.Write("Hur många loopar ska köras? ");
            lyckades = int.TryParse(Console.ReadLine(), out int antal);

            // Skriver felmeddelande ifall TryParse misslyckas - inget gilitg värde
            if (lyckades == false)
            {
                Console.WriteLine("Du måste ange ett tal");
            }

            // Skriver ut namnet antalet gånger som specifierades
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine($"{i} {namn}");
            }
        }
    }
    else if (val == "2")
    {

        // Loopar tills TryParse ger ett värde
        while (lyckades == false)
        {
            Console.Write("Ange ett tal: ");
            lyckades = int.TryParse(Console.ReadLine(), out int tal);

            // Skriver felmeddelande ifall inget värde ges
            if (lyckades == false)
            {
                Console.WriteLine("Du måste ange ett tal");
            }
            else
            {
                Console.WriteLine($"""
                Multiplicerat med 2: {tal * 2}
                Dividerat med 2: {tal / 2}
                Adderat med 2: {tal + 2}
                Subtraherat med 2: {tal - 2}
                Roten ur: {Math.Sqrt(tal)}
                Upphöjt till 2: {Math.Pow(tal, 2)}
                """);
            }
        }

    }
    else if (val == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("Du måste ange antingen 1, 2 eller 3");
    }
}

