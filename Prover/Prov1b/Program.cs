// Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Console.Clear();
Console.WriteLine("""
Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Marginalskatten räknas ut baserat på din bruttolön.
Med bruttolön avses din årslön före skatt.
""");

Console.Write("Vad heter du: ");
string namn = Console.ReadLine();

// Programloop
while (true)
{
    Console.Write("Ange din bruttolön i kronor: ");
    int bruttolön = int.Parse(Console.ReadLine());

    // Har användaren matat in vettiga siffror?
    if (bruttolön < 10000 || bruttolön > 1000000)
    {
        Console.WriteLine($"{namn}, Bruttolön måste vara mellan 10000:- och 1000000:-");
    }
    else
    {
        // Vad är skattesatsen? 
        int skattesatsen = 0;
        // 10000:- till 145000:- --> 22%
        if (bruttolön >= 10000 && bruttolön < 145000)
        {
            skattesatsen = 22;   
        }
        // 145000:- till 515000:- --> 33%
        if (bruttolön >= 145000 && bruttolön < 515000)
        {
            skattesatsen = 33;   
        }
        // 515000:- eller mer --> 53%
        if (bruttolön >= 515000)
        {
            skattesatsen = 53;   
        }

        // Skatteuträkning
        int nettolön = bruttolön * (100-skattesatsen) / 100;

        // Skriv ut resultat
        Console.WriteLine($"Din nettolön blir {nettolön} kr. Uträkning baserad på bruttolön {bruttolön} kr och marginalskatten {skattesatsen}%.");
    }

    // Vill du göra en ny beräkning? (j/n)
    Console.Write("Vill du göra en ny beräkning? (j/n)");
    string görOm = Console.ReadLine().ToLower().Trim();
    if (görOm == "n")
    {
        break;
    }
    
}