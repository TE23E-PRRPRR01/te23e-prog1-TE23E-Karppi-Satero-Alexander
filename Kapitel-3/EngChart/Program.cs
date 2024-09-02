// Program som simulerar kända Engineering Flowchart
Console.Clear();
Console.WriteLine("Välkommen till ingenjörens flödeschema");

// Visa en ASCii art
Console.WriteLine($"""
                                          $"   *.      
              d$$$$$$$P"                  $    J
                  ^$.                     4r  "
                  d"b                    .db
                 P   $                  e" $
        ..ec.. ."     *.              zP   $.zec..
    .^        3*b.     *.           .P" .@"4F      "4
  ."         d"  ^b.    *c        .$"  d"   $         %
 /          P      $.    "c      d"   @     3r         3
4        .eE........$r===e$$$$eeP    J       *..        b
$       $$$$$       $   4$$$$$$$     F       d$$$.      4
$       $$$$$       $   4$$$$$$$     L       *$$$"      4
4         "      ""3P ===$$$$$$"     3                  P
 *                 $                  b                J
  ".             .P                    %.             @
    %.         z*"                      ^%.        .r"
       "*==*""                             ^"*==*""   
""");

// Flödesschema

Console.Write("Does it move? (y/n) ");
string answer = Console.ReadLine();

// Kolla om svar är ja eller nej
if (answer == "y")
{
    Console.Write("Should it? (y/n) ");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("No problem!");
    }
    else
    {
        Console.WriteLine("Plz use Duct Tape");
    }
}
else
{
    Console.Write("Should it? (y/n) ");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("Plz use WD40");
    }
    else
    {
        Console.WriteLine("No problem!");
    }
}

// Annan variant av samma flödesschema

Console.Write("Does it move? (y/n)");
string svar = Console.ReadLine();
Console.Write("Should it? (y/n) ");
string svar2 = Console.ReadLine();
if ((svar == "y" && svar2 == "y"))
{
    Console.WriteLine("No problem! ");
}
else if (svar == "n" && svar2 == "y")
{
    Console.WriteLine("Plz use WD40");
}
else if (svar == "y" && svar2 == "n")
{
    Console.WriteLine("Plz use Duct Tape");
}
else if (svar == "n" && svar2 == "n")
{
    Console.WriteLine("No problem! ");
}
else 
{
    Console.WriteLine("Answer with y/n");
}