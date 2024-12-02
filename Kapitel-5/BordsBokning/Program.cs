// Ett program för att hantera bordsinformation

using System.IO;

Console.Clear();

Console.WriteLine("Detta är Centralrestaurangens bordshanterare");

// Initiera variabler
// Skapa en tom array för borden
string[] bordsInformation = ["", "", "", "", "", "", "", "",];

// Namn på filen som lagrar bordsbokningar
string filnamn = "centralbord.csv";

// Format på tomt bord
string tomtBordBeskrivning = "0,Inga gäster";

// Antal bord
int antalbord = 8;

for (var i = 0; i < antalbord; i++)
{
    bordsInformation[i] = tomtBordBeskrivning;
}

// Kolla efter tidigare fil
if (!File.Exists(filnamn))
{
    Console.WriteLine("Fil med bordsinformation hittades ej, ny information skapades.");
    File.Create(filnamn);
}
else
{
    // Om filen finns läs in filen i en array

}


// Programloop för meny
while (true)
{
    // Skriv ut menyn
    Console.Write("""
    1. Visa alla bord
    2. Ändra bordsinformation
    3. Markera att ett bord är ledigt
    4. Avsluta programmet
    Välj ett alternativ: 
    """);

    string val = Console.ReadLine();

    if (val == "1")
    {
        // Visa hela array:n (Den ska visst vara på ett annat sätt)
        for (var i = 0; i < antalbord; i++)
        {
            
            Console.WriteLine(bordsInformation[i]);
        }
    }
    else if (val == "2")
    {
        Console.WriteLine("Ange bords nr (1-8)");
        bool lyckades = int.TryParse(Console.ReadLine(), out int bordsNr);

        Console.WriteLine("Ange bokningsnamn");
        string bokningsNamn = Console.ReadLine();

        Console.WriteLine("Ange antal gäster");
        lyckades = int.TryParse(Console.ReadLine(), out int gästAntal);

        bordsInformation[bordsNr] = $"{gästAntal},{bokningsNamn}";
    }
    else if (val == "3")
    {
        Console.WriteLine("Ange bords nr (1-8)");
        bool lyckades = int.TryParse(Console.ReadLine(), out int bordsNr);

        bordsInformation[bordsNr] = tomtBordBeskrivning;
    }
    else if (val == "4")
    {
        Console.WriteLine("...Avslutar...");
        break;
    }
}