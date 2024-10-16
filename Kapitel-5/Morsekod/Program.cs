// En liten morsekod app
Console.Clear();
Console.WriteLine("En liten morsekod app");
Console.InputEncoding = System.Text.Encoding.Unicode;

// Två listor
List<string> alfabetet = ["A","B", "C","D", "E", "F", "G", "H", "I",
                          "J", "K", "L", "M", "N", "O", "P", "Q", "R",
                          "S", "T", "U", "V", "W", "X", "Y", "Z", "Å",
                          "Ä", "Ö", " ", "1", "2", "3", "4", "5", "6", 
                          "7", "8", "9", "0"];

List<string> morsekod = [ ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
                         "....", "..", ".---", "-.-", ".-..", "--", "-.",
                         "---", ".--.", "--.-", ".-.", "...", "-", "..-",
                         "...-", ".--", "-..-", "-.--", "--..", ".--.-",
                         ".-.-", "---.", "/", ".----", "..---", "...--", 
                         "....-", ".....", "-....", "--...", "---..", "----.", 
                         "-----" ];

// Läs in en text
Console.Write("Ange ett meddelande: ");
string meddelande = Console.ReadLine();

// Gå igenom meddelandet bokstav för bokstav

foreach (char bokstav in meddelande)
{
    // Uppslag i alfabetet efter index
    int index = alfabetet.IndexOf(bokstav.ToString());

    //  Hittar morsetecken? 
    if (index >= 0)
    {
        //Console.Write($"{bokstav} finns på index {index} ");

        // Plocka ur morsetecknet för detta index
        string morsetecken = morsekod[index];
        //Console.WriteLine($"{meddelande} är {morsetecken}");
        Console.Write($"{morsetecken} ");

        // Spela upp morse som ljud-beep
        // Tex D = "-.."
        foreach (char signal in morsetecken)
        {
            if (signal == '.') // '.'
            {
                // 1000Hz, 200ms
                Console.Beep(1000, 200);
            }
            else //'-'
            {
                Console.Beep(1000, 600);
            }
        }
    }
    else
    {
        Console.WriteLine("?");
    }

}

