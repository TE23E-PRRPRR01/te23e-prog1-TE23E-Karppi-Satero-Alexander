using System.IO.Pipes;
using System.Linq.Expressions;

Console.Clear();
while (true){
    Console.Write("Du befinner dig i en korridor. Vilket håll går du (N/V/S) ");
    string väderstreck = Console.ReadLine(). ToUpper();

    if (väderstreck == "N")
    {//ifall man svarar N
        Console.Write("Du går norr och möter en katt. Klappa katten? (J/N) ");
        string Klappa = Console.ReadLine(). ToUpper();
    
        if (Klappa == "J")
        {
          Console.WriteLine("Du klappar katten");
        }
        else
        {
         Console.WriteLine("Du blir uppäten av katten :)");
     }
    }
    else if (väderstreck == "V")
    {//ifall man svarar V
        Console.WriteLine("Du går väst. ");
        Console.WriteLine("Grattis, du valde det tråkiga slutet");
    }
    else if (väderstreck == "S")
    {//ifall man svarar S
        Console.WriteLine("Du går syd. ");
        Console.Write("Du hamnar i en korsning (V/Ö)");
        väderstreck = Console.ReadLine().ToUpper();

        if (väderstreck == "V")
        {
            Console.WriteLine("Du halkade, slog i huvudet och dog.");
        }
        else if (väderstreck == "N")
        {
            Console.WriteLine("Du går tillbaka");
            continue;
        }
        else
        {
            Console.WriteLine("Det var ingen korsning, du gick in i vägen.");
        }
    }   
    else 
    {//ifall man svarar något annat
        Console.WriteLine("Du dog :(");
    }
}
