// Mikroövning
Console.Clear();

// Be användaren ange startvärde och slutvärde

Console.Write("Ange startvärde: ");
string startvärdeText = Console.ReadLine();
bool lyckades = int.TryParse(startvärdeText, out int startvärde);

Console.Write("Ange slutvärde: ");
string slutvärdeText = Console.ReadLine();
lyckades = int.TryParse(slutvärdeText, out int slutvärde);

// Skriv ut alla värden mellan start och slut
Console.WriteLine($"""
Alla värden mellan {startvärde} och {slutvärde}

""");

for (int i = startvärde; i < slutvärde + 1; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine($"""

Summan av alla tal från {startvärde} till {slutvärde}

""");

int summa = 0;
for (int i = startvärde; i < slutvärde + 1; i++)
{
    summa += i;
}

Console.WriteLine(summa);

// Skriv ut alla jämna siffror från 1 till 20
Console.Write("Jämna siffror: ");
for (int i = 1; i < 21; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
    }
}

// Skriv ut alla udda siffror från 1 till 20
Console.Write("""

Udda siffror: 
""");
for (int i = 1; i < 21; i++)
{
    if (i % 2 != 0)
    {
        Console.Write($"{i}, ");
    }

}

// Multiplikationstabell
Console.Write("");
Console.WriteLine("Ange ett tal: ");
string multiplikationTalText = Console.ReadLine();
lyckades = int.TryParse(multiplikationTalText, out int multiplikationTal);

for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"{multiplikationTal} x {i} = {multiplikationTal * i}");
}

// Skapa ett mönster med stjärnor
Console.WriteLine("Ange antal rader: ");
string antalRaderText = Console.ReadLine();
lyckades = int.TryParse(antalRaderText, out int antalRader);

for (int i = 1; i < antalRader + 1; i++)
{
    for (int a = 0; a < i; a++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}

// Skriv ut en julgran 

Console.WriteLine("Ange antal rader: ");
string antalRaderJulgranText = Console.ReadLine();
lyckades = int.TryParse(antalRaderJulgranText, out int antalRaderJulgran);

for (int i = 0; i < antalRaderJulgran; i++)
{
    for (int a = 0; a < antalRaderJulgran - i; a++)
    {
        Console.Write(" ");
    }
    for (int b = 0; b < 1 + (i * 2) ; b++)
    {
        Console.Write("*");
    }
    for (int c = 0; c < antalRaderJulgran - i; c++)
    {
        Console.Write(" ");
    }
    Console.WriteLine("");
}
