/* *******************************************************************************
*                                      M A I N                                   *
******************************************************************************* */
Console.Clear();

/* // Skriv ett meddelande vertikalt
string meddelande = "Måndag!";
SkrivVertikalt(meddelande);

// Skriv ett meddelande vertikalt nr 2 
string meddelande2 = "Tisdag är bättre!";
SkrivVertikalt(meddelande2);


// Skriv ett meddelande vertikalt nr 3 
string meddelande3 = "Tisdag är bättre!";
SkrivVertikalt(meddelande3); */

/* RitaKvadrat(5);

UpprepaText("Hej", 2);
UpprepaText("Hmmmmmmmmmm", 5);

 */

/* // Omvandla celsius till fahrenheit
 CTillF(20);
 */

KastaTärning(5);

/* *******************************************************************************
*                                      M E T O D E R                             *
******************************************************************************* */
/// <summary>
/// Skriver ut text vertikalt
/// </summary>
/// <param name="meddelande">Meddelandet som ska skrivas vertikalt</param>
static void SkrivVertikalt(string meddelande)
{
    for (var i = 0; i < meddelande.Length; i++)
    {
        Console.WriteLine(meddelande[i]);
    }
}

/// <summary>
/// Skriver ut kvadrat
/// </summary>
/// <param name="sidlängd">Längden på kvadratens sida</param>
static void RitaKvadrat(int sidlängd)
{
    for (var i = 0; i < sidlängd; i++)
    {
        Console.WriteLine();
        for (var j = 0; j < sidlängd; j++)
        {
            Console.Write("*");
        }
    }
}

/// <summary>
/// Upprepar text antal gånger
/// </summary>
/// <param name="text">Text som ska upprepas</param>
/// <param name="antal">Antal uppreppningar</param>
static void UpprepaText(string text, int antal)
{
    for (var i = 0; i < antal; i++)
    {
        Console.WriteLine(text);
    }
}

/// <summary>
/// celsius till fahrenheit
/// </summary>
/// <param name="temperatur"> Celsius</param>
static void CTillF(int temperatur)
{
    Console.WriteLine($"{temperatur} grader Celsius motsvarar {temperatur * 9/5 + 32} grader Fahrenheit");
}

static void KastaTärning(int antalKast)
{
    for (var i = 0; i < antalKast; i++)
    {
        Console.WriteLine($"Tärningen visar {Random.Shared.Next(1,7)}");
    }
}