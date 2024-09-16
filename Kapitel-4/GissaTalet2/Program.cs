// Spelet - gissa ett slumptal 
Console.Clear();
Console.WriteLine("Spelet - gissa ett slumptal ");

// En variabel för att hålla koll på antal gissningar 
int antal = 0;

// Ange min och max värde
Console.Write("Ange ett minimum värde: ");
int minVärde = int.Parse(Console.ReadLine());

Console.Write("Ange ett maximum värde: ");
int maxVärde = int.Parse(Console.ReadLine());

// Slumpar ett tal mellan 1-100
int slumptal = Random.Shared.Next(minVärde, maxVärde + 1);


// Upprepning - loop
while (true)
{  
    // Ställ fråga till användaren
    Console.Write($"Gissa ett tal ({minVärde}-{maxVärde}): ");
    int gissning = int.Parse(Console.ReadLine());

    // Räkna upp antal med 1
    antal++;

    // Kontrollera om gissning är rätt
    if (gissning == slumptal)
    {
        Console.WriteLine($"Rätt gissat på {antal} gissning(ar)!");
        break;
    }
    else if (gissning > slumptal)
    {
        Console.WriteLine("För högt");
    }
    else
    {
        Console.WriteLine("För lågt");
    }

    
    // Vill användaren gissa en gång till
    Console.Write("Vill du gissa en gång till? (j/n): ");
    if (Console.ReadLine() == "n")
    {
        break;
    }
    
}

// Slut på spelet 
Console.WriteLine("Tack för att du spelade!");