/* *******************************************************************************
*                                      M A I N                                   *
******************************************************************************* */
// Använd metoder här!
int svar = Addera(3, 5);
Console.WriteLine($"talet är {svar}");
Console.WriteLine($"talet är {Addera(3, 5)}");
Console.WriteLine($"3 + 5 = {Addera(3, 5)}");

Console.WriteLine($"Det du skrivit vänt är: {VändText("Måndag")}");

Console.WriteLine(Multiplicera(5, 5));

Console.WriteLine(Dividera(10, 2));

Console.WriteLine(Längst("dfdgsfgdshs", "dhgkshjgsjkhkfdgh"));

Console.Write("Ange ett tal: ");
int nyTal1 = LäsInHeltal();

Console.Write("Ange ett tal: ");
int nyTal2 = LäsInHeltal();


/* *******************************************************************************
*                                   M E T O D E R                                *
******************************************************************************* */
// Skapa metoder här!

/// <summary>
/// Summera två tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static int Addera(int tal1, int tal2)
{
    int summa = tal1 + tal2;
    return summa;
}

/// <summary>
/// Vänder på texten
/// </summary>
/// <param name="text"></param>
static string VändText(string text)
{
    string omvändText = "";
    for (var i = text.Length - 1; i >= 0; i--)
    {
        omvändText += text[i];
    }
    return omvändText;
}

/// <summary>
/// Multiplicera två tal med varann
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Multiplicera(double tal1, double tal2)
{
    double summa = tal1 * tal2;
    return summa;
}

/// <summary>
/// Dividera två tal med varann
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Dividera(double tal1, double tal2)
{
    double summa = tal1 / tal2;
    return summa;
}

/// <summary>
/// Returnerar längsta texten
/// </summary>
/// <param name="text1"></param>
/// <param name="text2"></param>
/// <returns></returns>
static string Längst(string text1, string text2)
{
    if (text1.Length < text2.Length)
    {
        string text = text2;
        return text;
    }
    else
    {
        string text = text1;
        return text;
    }
}

/// <summary>
/// Säkert sätt att läsa in ett tal (utan att det kraschar)
/// </summary>
static int LäsInHeltal()
{
    int tal = 0;
    while (true)
    {
        string textSomBlirTal = Console.ReadLine();
        // Kolla om texten är ett tal
        bool lyckades = int.TryParse(textSomBlirTal, out tal);

        if (lyckades == true)
        {
            break;
        }
        else
        {
            Console.WriteLine("Fel. Va god ange ett heltal");
        }
    }

    return tal;
}