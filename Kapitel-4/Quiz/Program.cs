// Ett quiz
using System.Runtime.CompilerServices;

Console.Clear();
Console.WriteLine("Quiz!");

// Fråga om namn

Console.Write("Vad heter du: ");
string namn = Console.ReadLine();

// Poäng räkning

int poäng = 0;

// Fråga 1
while (true)
{
    // Ställ frågan
    Console.Clear();
    Console.Write(@"Fråga 1
    Vad heter huvudstaden i Kenya 
    a) Nairobi 
    b) Kenya 
    c) Det finns ingen 
    Ditt svar (a, b eller c): ");
    // Läsa av svar 
    string svar = Console.ReadLine();
    svar = svar.ToLower();

    // Kontrollera svaret
    if (svar == "a")
    {
        Console.WriteLine("Rätt svar!");
        poäng ++;
        break;
    }
    else if (svar == "b")
    {
        Console.WriteLine("Fel svar!");
        break;
    }
    else if (svar == "c")
    {
        Console.WriteLine("Fel svar!");
        break;
    }
    else
    {
        continue;
    } 
}
// Samma sak med fråga 2, 3 och 4
while (true)
{
    Console.Clear();
    Console.Write(@"Fråga 2
    Vad heter huvudstaden i Sverige 
    a) Köpenhamn
    b) Stockholm
    c) Oslo
    Ditt svar (a, b eller c): ");
    string svar = Console.ReadLine();
    svar = svar.ToLower(); 

    if (svar == "a")
    {
        Console.WriteLine("Fel svar!");
        break;
    }
    else if (svar == "b")
    {
        Console.WriteLine("Rätt svar!");
        poäng ++;
        break;
    }
    else if (svar == "c")
    {
        Console.WriteLine("Fel svar!");
        break;
    }
    else
    {
        continue;
    } 
}

while (true)
{
    Console.Clear();
    Console.Write(@"Fråga 3
    Vad heter huvudstaden i Tyskland 
    a) Berlin
    b) Hamburg
    c) München
    Ditt svar (a, b eller c): ");
    string svar = Console.ReadLine();
    svar = svar.ToLower();

    if (svar == "a")
    {
        Console.WriteLine("Rätt svar!");
        poäng ++;
        break;
    }
    else if (svar == "b")
    {
        Console.WriteLine("Fel svar!");
        break;
    }
    else if (svar == "c")
    {
        Console.WriteLine("Fel svar!");
        break;
    }
    else
    {
        continue;
    } 
}

while (true)
{
    Console.Clear();
    Console.Write(@"Fråga 4
    Vad heter huvudstaden i Kanada
    a) Toronto
    b) Ottawa
    c) Paris
    Ditt svar (a, b eller c): ");
    string svar = Console.ReadLine();
    svar = svar.ToLower();

    if (svar == "a")
    {
        Console.WriteLine("Fel svar!");
        break;
    }
    else if (svar == "b")
    {
        Console.WriteLine("Rätt svar!");
        poäng ++;
        break;
    }
    else if (svar == "c")
    {
        Console.WriteLine("Fel svar!");
        break;
    }
    else
    {
        continue;
    } 
}

// Resultat

Console.Clear();
Console.WriteLine(@$"Grattis {namn} du fick {poäng}/4 poäng!
Tack för att du spelade!");