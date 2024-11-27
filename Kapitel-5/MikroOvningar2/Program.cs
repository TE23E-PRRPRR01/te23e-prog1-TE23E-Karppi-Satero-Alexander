// Övningar
Console.Clear();
bool lyckades = false;
int val = 0;

// Skriv ut lista med foreach
List<string> maträtter = ["Pizza", "Pasta", "Sallad"];
Console.WriteLine("Alla maträtter:");
foreach (var maträtt in maträtter)
{
    Console.WriteLine($"- {maträtt}");
}

// Skriv ut alla årtal i en lista 
List<string> årtalLista = ["1492", "1776", "1914", "1945", "1969"];
Console.WriteLine("Alla årtal:");
foreach (var årtal in årtalLista)
{
    Console.WriteLine($"- {årtal}");
}

// Loopa o fråga
List<string> städerLista = ["Stockholm", "Göteborg", "Malmö", "Umeå", "Södertälje"];

while (true)
{
    Console.Write("Vilken stad vill du besöka (1-5)? ");
    lyckades = int.TryParse(Console.ReadLine(), out val);

    if (lyckades == true)
    {
        Console.WriteLine(städerLista[val - 1]);
        break;
    }
    else
    {
        Console.WriteLine("Fel, ange ett index mellan 1 och 5.");
    }
}

// Hitta namn i en lista 
List<string> namnLista = ["Anna", "Björn", "Cecilia"];

Console.Write("Ange ett namn: ");
namnLista.Add(Console.ReadLine());

Console.Write("Ange ett till namn: ");
namnLista.Add(Console.ReadLine());

Console.Write("Ange ett namn att söka efter: ");
string namnAttLäggaTill = Console.ReadLine();
if (namnLista.Contains(namnAttLäggaTill))
{
    Console.WriteLine($"{namnAttLäggaTill} finns i listan.");
}
else
{
    Console.WriteLine($"{namnAttLäggaTill} finns inte i listan.");
}

// Hitta namn som börjar på en viss bokstav
// Jag använder tidigare namnLista
while (true)
{

    Console.WriteLine("Ange en bokstav");
    lyckades = char.TryParse(Console.ReadLine().ToUpper(), out char bokstav);
    if (lyckades = true)
    {
        foreach (var namn in namnLista)
        {
            if (namn.StartsWith(bokstav))
            {
                Console.WriteLine(namn);
            }
        }
        break;
    }
    else
    {
        Console.WriteLine("Fel: ange en bokstav.");
    }

}

// Skapa en meny 

List<string> namnLista2 = [];

while (val != 4)
{
    Console.WriteLine("""
    1. Lägg till ett namn
    2. Ta bort ett namn
    3. Visa listan
    4. Avsluta programmet 
    """);

    lyckades = int.TryParse(Console.ReadLine(), out val);

    if (val == 1)
    {
        Console.Clear();
        // Lägg till namn
        Console.WriteLine("Ange ett namn: ");
        namnLista2.Add(Console.ReadLine());
        Console.WriteLine($"Nuvarande lista: {string.Join(", ", namnLista2)}");
    }
    else if (val == 2 && namnLista2.Count > 0)
    {
        Console.Clear();
        // Ta bort ett namn om det finns 
        Console.WriteLine("Ange ett namn att ta bort: ");
        string namnAttTaBort = Console.ReadLine();
        if (namnLista2.Contains(namnAttTaBort))
        {
            namnLista2.Remove(namnAttTaBort);
            Console.WriteLine($"Nuvarande lista {string.Join(", ", namnLista2)}");
        }
        else
        {
            Console.WriteLine($"Fel: {namnAttTaBort} finns inte i listan");
        }
    }
    else if (val == 3)
    {
        Console.Clear();
        Console.WriteLine($"Listan är {string.Join(", ", namnLista2)}");
    }
}

// Summera alla tal i en lista
List<int> nummerLista = [1, 2, 3, 4, 5];

int summa = 0;

foreach (var nummer in nummerLista)
{
    summa += nummer;
}
Console.WriteLine($"Summan av alla talen i listan är: {summa}");