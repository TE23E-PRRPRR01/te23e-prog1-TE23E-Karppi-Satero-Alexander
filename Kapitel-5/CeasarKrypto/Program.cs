// Ett program för kryptering med Ceasar-chiffer
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Ett program för kryptering med Ceasar-chiffer");

// Alfabetet, lista av bokstäver att använda
string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

// Ange ett meddelande
Console.Write("Ange ett meddelande: ");
string meddelande = Console.ReadLine().ToUpper();

// Ceasar-kryptering, ange en nyckel 1-9 
Console.Write("Ange en nyckel (1-9): ");
int nyckel = int.Parse(Console.ReadLine());


// Loopa igenom  meddelandet bokstav för bokstav

foreach (char bokstav in meddelande)
{
    // Hitta bokstavens position (index)
    int index = alfabetet.IndexOf(bokstav);

    // Om bokstaven finns i alfabetet
    if (index >= 0)
    {
        int nyIndex = index + nyckel;

        // Börja om från början efter 29
        if (nyIndex >= alfabetet.Length)
        {
            nyIndex = nyIndex - alfabetet.Length;
        }

        // Plocka ut bokstaven för nyIndex
        char krypteradBokstav = alfabetet[nyIndex];
        Console.Write(krypteradBokstav);
    }
    else
    {
        Console.Write(bokstav);
    }
}
