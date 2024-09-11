// Program för att räkna ut BMI
using System.Runtime.CompilerServices;

Console.Clear();
Console.WriteLine("Program för att räkna ut BMI");

// Läs in vikt och längd
Console.Write("Vad är din vikt (kg): ");
double vikt = double.Parse(Console.ReadLine());

Console.Write("Vad är din längd (m): ");
double längd = double.Parse(Console.ReadLine());

// Räkna ut BMI
double BMI = vikt / (längd + längd);

// Skriv resultat
Console.WriteLine($"Ditt BMI är {BMI:00.00}");







