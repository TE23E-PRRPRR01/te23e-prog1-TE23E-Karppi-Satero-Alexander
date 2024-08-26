Console.Clear();

Console.WriteLine("Hej, världen!");
Console.WriteLine("Vad heter du?");
string namn = Console.ReadLine();
Console.WriteLine("Hej " + namn);

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("Vad gör du på fritiden?");
string fritid = Console.ReadLine();
Console.WriteLine("Jag tycker också om " + fritid);