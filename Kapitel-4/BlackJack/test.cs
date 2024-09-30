/* // Spelet BlackJack, även kallat 21:an
Console.Clear();
Console.WriteLine("Spelet BlackJack");

// Kortens värde är
// 2-10 = 2-10
// Knekt, dam, kung = 10
// Ess = 1 eller 11

// Variabler
int summaSpelare = 0;
int summaDator = 0;
int kort = 0;

// Dela ut två kort till spelaren
kort = Random.Shared.Next(1, 11); // @todo Knekt, dam & kung?
summaSpelare += kort;
kort = Random.Shared.Next(1, 11);
summaSpelare += kort;

// Dela ut två kort till datorn
kort = Random.Shared.Next(1, 11); // @todo Knekt, dam & kung?
summaDator += kort;
kort = Random.Shared.Next(1, 11);
summaDator += kort;

// Flera gånger (loop) spelaren tar kort
while (true)
{
    // Skriv ut summorna 
    Console.WriteLine($"Du har {summaSpelare} poäng. ");
    Console.WriteLine($"Datorn har {summaDator} poäng. ");

    // Stanna eller dra ett kort?
    Console.Write("Vill du ha ett nytt kort? (j/n) ");
    string svar = Console.ReadLine().ToLower();
    if (svar == "n")
    {
        break;
    }

    // Ta ett extra kort 
    kort = Random.Shared.Next(1, 11); // @todo Knekt, dam & kung?
    summaSpelare += kort;
    // Skriv ut kortet
    Console.Clear();
    Console.WriteLine($"Du fick {kort} poäng");
}

// Datorn får också ett nytt kort så länge den har mindre än 17
while (summaDator < 17)
{
    // Så länge inte spelaren har förlorat
    if (summaSpelare > 21)
    {
        break;
    }
    else
    {

        kort = Random.Shared.Next(1, 11); // @todo Knekt, dam & kung?
        summaDator += kort;
        // Skriv ut kortet
        Console.WriteLine($"Datorn fick {kort} poäng. Datorn har {summaDator} poäng");
    }
}

// Vem har vunnit?

// Har datorn fått 21?
if (summaDator == 21)
{
    Console.WriteLine("Du har förlorat");
}
// Har spelaren fått 21 har de vunnit
else if (summaSpelare == 21)
{
    Console.WriteLine("Du har vunnit");
}
// Är spelaren tjock?
else if (summaSpelare > 21)
{
    Console.WriteLine("Du har förlorat!");
}
// Är datorn tjock?
else if (summaDator > 21)
{
    Console.WriteLine("Du har vunnit");
}
// Vem är närmst 21 
else if (summaSpelare > summaDator)
{
    Console.WriteLine("Du har vunnit");
}
else
{
    Console.WriteLine("Du har förlorat");
} */