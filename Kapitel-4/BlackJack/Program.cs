// Spelet BlackJack, även kallat 21:an
Console.Clear();
Console.WriteLine("Spelet BlackJack");

// Kortens värde är
// 2-10 = 2-10
// Knekt, dam, kung = 10
// Ess = 1 eller 11
// Slump måste efterlikna riktig kortlek


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

// Flera gånger (loop)
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
        // Datorn får ta kort 

        if (summaDator < 15)
        {
            kort = Random.Shared.Next(1, 11); // @todo Knekt, dam & kung?
            summaDator += kort;
            // Skriv ut kortet
            Console.WriteLine($"Datorn fick {kort} poäng");
        }

        // Vem har vunnit?
        // Den som har närmast men inte mer än 21 har vunnit

        if (summaSpelare < 22 && summaSpelare > summaDator)
        {
            Console.WriteLine("Du har vunnit");
        }
        else
        {
            Console.WriteLine("Du har förlorat");
        }
        break;
    }

    // Ta ett extra kort 
    kort = Random.Shared.Next(1, 11); // @todo Knekt, dam & kung?
    summaSpelare += kort;
    // Skriv ut kortet
    Console.WriteLine($"Du fick {kort} poäng");

    // Datorn får också ett nytt kort
    if (summaDator < 15)
    {
        kort = Random.Shared.Next(1, 11); // @todo Knekt, dam & kung?
        summaDator += kort;
        // Skriv ut kortet
        Console.WriteLine($"Datorn fick {kort} poäng");
    }

    // Vem har vunnit?
    // Har datorn fått 21 och vunnit
    if (summaDator == 21)
    {
        Console.WriteLine("Datorn har vunnit");
        break;
    }
    // Har spelaren fått 21 har de vunnit
    if (summaSpelare == 21)
    {
        Console.WriteLine("Du har vunnit");
        break;
    }

    // Är spelaren tjock?
    if (summaSpelare > 21)
    {
        Console.WriteLine("Du har förlorat!");
        break;
    }
    // Är datorn tjock?
    if (summaDator > 21)
    {
        Console.WriteLine("Du har vunnit!");
        break;
    }
}