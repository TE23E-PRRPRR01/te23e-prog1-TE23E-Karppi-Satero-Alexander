/* ****************************************************************
*                            M A I N                              *
*******************************************************************/

Console.Clear();
Console.WriteLine("Hello, World!");

SägHejNamn("Valentin");
SägHejNamn("Johnny");
SägHejNamn("Benjamin");
SägHejNamn("");

TalIKvadrat(1);
TalIKvadrat(2);
TalIKvadrat(3);
TalIKvadrat(4);

/* ****************************************************************
*                            M E T O D E R                        *
*******************************************************************/

/// <summary>
/// Skriv ut häslning
/// </summary>
/// <param name="namn">Namnet</param>
static void SägHejNamn(string namn)
{
    Console.WriteLine($"Hej på dig {namn}!");
}

/// <summary>
/// Skriver ut tal i kvadrat
/// </summary>
/// <param name="tal">Talet</param>
static void TalIKvadrat(int tal)
{
    Console.WriteLine(tal * tal);
}