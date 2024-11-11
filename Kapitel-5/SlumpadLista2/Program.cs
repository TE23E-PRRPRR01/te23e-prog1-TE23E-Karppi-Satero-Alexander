// Skapa lista med slumpade tal

/* ******************************************************************
**                            Main                                 **
********************************************************************* */

// Validera användarens inmatning
Console.Clear();
Console.WriteLine("Ett program för att skapa en lista med slumpade tal");

// Deklarera variabler
// Skapa en lista för att spara det slumpade talet
List<int> listaSlumptal = [];

// Fråga igen tills användaren matar in ett giltigt svar
// Fråga användaren om antal slumptal
int antalSlumptal = LäsInHeltal();
Console.WriteLine($"Du vill ha {antalSlumptal} slumptal");

// Fråga användaren om lägsta värdet på slumptal
int minSlumptal = LäsInHeltal();
Console.WriteLine($"Lägsta slumptal blir {minSlumptal}");


// Fråga användaren om högsta värdet på slumptal
int maxSlumptal = LäsInHeltal();
Console.WriteLine($"Högsta slumptal blir {maxSlumptal}");

// Slumpa fram ett slumptal
for (int i = 0; i < antalSlumptal; i++)
{
    int slumptal = Random.Shared.Next(minSlumptal, maxSlumptal + 1);
    Console.WriteLine($"Ditt nya slumptal är {slumptal}");
}

/* ******************************************************************
**                      Mina egna metoder                          **
********************************************************************* */

static int LäsInHeltal()
{
    int heltal = 0;
    while (true)
    {
        Console.Write("Ange heltal: ");

        bool lyckades = int.TryParse(Console.ReadLine(), out heltal);
        if (lyckades)
        {
            break;
        }
        else
        {
            Console.WriteLine($"Du måste skriva ett heltal");
        }
    }
    return heltal;
}
