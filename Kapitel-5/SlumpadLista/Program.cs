// Slumpa många tal och spara i lista
Console.Clear();
Console.WriteLine("Slumpa många tal och spara i lista");

// Globala variabler 
// En lista för heltat
List<int> listaSlumptal = [];

// Be användare ange antal slumpade tal
Console.Write("Ange antal slumptal: ");
int antalSlumptal = int.Parse(Console.ReadLine());

// Be användare ange min och max värde
Console.Write("Ange minsta värde för slumptal: ");
int minTal = int.Parse(Console.ReadLine());
Console.Write("Ange största värde för slumptal: ");
int maxTal = int.Parse(Console.ReadLine());

// Loopa 5 ggr 
for (int i = 0; i < antalSlumptal; i++)
{
    // Slumpa ett tal min-max
    int slumptal = 0;
    slumptal = Random.Shared.Next(minTal, maxTal + 1);

    // Lägg till slumptalet i listan
    listaSlumptal.Add(slumptal);

    Console.WriteLine($"Slumpat tal {i + 1}: {slumptal}");
}