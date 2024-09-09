// Exempel på spel som man får spela för sin ålder

Console.Clear();
Console.WriteLine("Få exempel på spel till din ålder");

Console.Write("Ange din ålder: ");
string ålderText = Console.ReadLine();
//Konvertera texten till ett heltal
int ålder = int.Parse(ålderText);

if (ålder >= 12 && ålder < 18)
{
    Console.WriteLine("Gå i skolan och plugga istället för att spela");
}
else if (ålder >= 18)
{
    Console.WriteLine("Spela vad du vill, jag vet inte");
}
else if (ålder <= 3)
{
    Console.WriteLine("Spela inte överhuvudtaget");
}
else if (ålder > 3 && ålder < 12)
{
    Console.WriteLine("Spela Minecraft eller Roblox");
}