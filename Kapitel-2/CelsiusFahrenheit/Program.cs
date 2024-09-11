// Program för att konvertera temperaturen i Celsius till Fahrenheit
Console.Clear();
Console.WriteLine("Program för att konvertera temperaturen i Celsius till Fahrenheit");

// Läser in Temp i Celsius
Console.Write("Ange temperatur i Celsius: ");
int tempCelsius = int.Parse(Console.ReadLine());

// Konvertera till Fahrenheit
int tempFahrenheit = tempCelsius * 9 / 5 + 32;

// Skriver ut resultatet
Console.WriteLine($"{tempCelsius} Celsius är {tempFahrenheit} Fahrenheit");