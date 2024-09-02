using System.IO.Pipes;
using System.Linq.Expressions;

Console.Clear();
Console.Write("Du befinner dig i en korridor. Vilket håll går du (N/V/S)");
string väderstreck = Console.ReadLine();

if (väderstreck == "N")
{//ifall man svarar N
    Console.Write("Du går norr och möter en katt. Klappa katten? (J/N)");
    string Klappa = Console.ReadLine();
    
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
    Console.WriteLine("Du går väst, ");
}
else if (väderstreck == "S")
{//ifall man svarar S
    Console.WriteLine("Du går syd, ");
}
else 
{//ifall man svarar något annat
    Console.WriteLine("Du dog :(");
}