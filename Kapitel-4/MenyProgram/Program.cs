// Litet program med meny
Console.Clear();
Console.WriteLine("Litet program med meny");
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

// Variabel för valet
string val = "";

// Programloop som snurrar tills användaren säger avsluta
while (true)
{
    // Visar en meny och läser in användarens val
    Console.Write("""
    1. Omvandla en text till versaler
    2. Omvandla en text till gemener
    3. Avsluta programmet 
    Välj ett av alternativen ovan: 
    """);
    val = Console.ReadLine();
    
    // Hantera användarens val
    if (val == "1")
    {
        Console.Clear();
        Console.Write("Skriv in en text: ");
        string texten = Console.ReadLine().ToUpper();
        Console.WriteLine($"Texten i versaler blir: {texten}");
    }
    else if (val == "2")
    {
        Console.Clear();
        Console.Write("Skriv in en text: ");
        string texten = Console.ReadLine().ToLower();
        Console.WriteLine($"Texten i gemener blir: {texten}");        
    }
    else if (val == "3")
    {
        Console.WriteLine("Avslutar...");
        break;
    }
    else 
    {
        Console.WriteLine("Ogiltigt alternativ, försök igen");
    }
}
