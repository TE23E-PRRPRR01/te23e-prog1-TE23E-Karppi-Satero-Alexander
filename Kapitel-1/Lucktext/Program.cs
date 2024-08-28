using System.Runtime.CompilerServices;

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Vad heter du?");
string namn = Console.ReadLine();
Console.WriteLine("Vad är din favorit färg? ");
string färg = Console.ReadLine();
Console.WriteLine("Vilket är ditt favoritdjur? ");
string favoritdjur = Console.ReadLine();
Console.WriteLine("Var skulle du vilja bo?");
string hem = Console.ReadLine();

if ((färg == "blå") || (färg == "Blå"))
{
    Console.ForegroundColor = ConsoleColor.Blue;
}
else
{
    Console.ForegroundColor = ConsoleColor.White;
}
if ((namn == "") || (färg == "") || (favoritdjur == "") || (hem == ""))
{
    Console.WriteLine("Svara på alla frågor");
}
else
{
    Console.WriteLine($"Ditt namn är {namn} och du bor i {hem} med en {färg} {favoritdjur}");
} 

