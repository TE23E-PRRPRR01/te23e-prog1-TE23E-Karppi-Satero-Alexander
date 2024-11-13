// Ett dungeo-spel med massa rum, saker, fiender, skatter...
Console.Clear();
Console.WriteLine("Ett dungeon-spel");

// Programvariabler 
string rum = "hallen";
List<string> inventarie = [];
int liv = 3;

// Spelloop
while (true)
{
    // Är vi i hallen?
    if (rum == "hallen")
    {
        Console.WriteLine("Du är i hallen");
        Console.WriteLine("""
        1. Titta runt
        2. Gå till nästa rum
        """);
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du tittar runt i rummet och ser några gammla tavlor");
        }
        else if (val == "2")
        {
            rum = "rum 1";
            Console.WriteLine(" .. du går in i nästa rum ..");
        }
    }
    else if (rum == "rum 1")
    {
        Console.WriteLine("Du är i rum 2");
        Console.WriteLine("""
        1. Titta runt
        2. Gå till nästa rum
        """);
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser en nyckel på golvet");
            Console.Write("Vill du plocka upp nyckeln (j/n) ");
            val = Console.ReadLine().ToLower();

            if (!inventarie.Contains("nyckel") && val == "j")
            {
                inventarie.Add("nyckel");
                Console.WriteLine(" .. Du fick en nyckel .. ");
            }
            else if (inventarie.Contains("nyckel"))
            {
                Console.WriteLine("Du har redan en nyckel");
            }
            else
            {
                Console.WriteLine("Du lämnar nyckeln på golvet");
            }
        }
        else if (val == "2")
        {
            rum = "rum 2";
            Console.WriteLine(" .. du går in i nästa rum ..");
        }
    }
    else if (rum == "rum 2")
    {
        Console.WriteLine("Du är i rum 3");
        Console.WriteLine("""
        1. Titta runt
        2. Gå till nästa rum
        """);
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser ett mynt på golvet");
            Console.Write("Vill du plocka upp myntet (j/n) ");
            val = Console.ReadLine().ToLower();
            if (val == "j")
            {
                inventarie.Add("mynt");
                Console.WriteLine(" .. Du fick ett mynt .. ");
            }
            else
            {
                Console.WriteLine("Du lämnar myntet på golvet");
            }
        }
        else if (val == "2")
        {
            rum = "rum 3";
            Console.WriteLine(" .. du går in i nästa rum ..");
        }
    }
    else if (rum == "rum 3")
    {
        Console.WriteLine("Du är i rum 4");
        // Slumpa en händelse
        int händelse = Random.Shared.Next(1, 5);
        if (händelse == 1)
        {
            Console.Write("Du ser ett svärd på golvet vill du plocka upp det (j/n) ");
            string val = Console.ReadLine().ToLower();
            if (!inventarie.Contains("svärd") && val == "j")
            {
                inventarie.Add("svärd");
                Console.WriteLine(" .. Du fick ett svärd .. ");
            }
        }
        else if (händelse == 2)
        {
            Console.WriteLine("Ett spöke dyker upp");
        }
        else if (händelse == 3)
        {
            Console.WriteLine("""
        1. Titta runt
        2. Gå till nästa rum
        """);
            Console.Write("Vad vill du göra? ");
            string val = Console.ReadLine();
            if (val == "1")
            {
                Console.WriteLine("Du ser ett råtta som säljer ost");
                Console.Write("Vill du köpa ost (j/n) ");
                val = Console.ReadLine().ToLower();
                if (inventarie.Contains("mynt") && val == "j")
                {
                    inventarie.Add("ost");
                    inventarie.Remove("mynt");
                    Console.WriteLine(" .. Du fick en bit ost .. ");
                }
                else if (!inventarie.Contains("mynt") && val == "j")
                {
                    Console.WriteLine("Du har inget att betala med");
                }
                else if (val == "n")
                {
                    Console.WriteLine("Du lämnar råttan :(");
                }
                else if (inventarie.Contains("mynt") && val == "n")
                {
                    inventarie.Remove("mynt");
                    Console.WriteLine("""
                    En annan råtta stal ditt mynt
                    .. Du förlorade ett mynt ..
                    """);

                }
            }
            else if (val == "2")
            {
                rum = "rum 3";
                Console.WriteLine(" .. du går in i nästa rum ..");
            }
        }
        else if (händelse == 4)
        {
            Console.WriteLine("Du blev biten av en katt");
            liv--;
            // Är liven slut
            if (liv <= 0)
            {
                break;
            }
        }
        else if (händelse == 5)
        {

        }
    }
}

Console.WriteLine("Du dog");
Console.WriteLine("Ditt förråd: ");
for (int i = 0; i < inventarie.Count; i++)
{
    Console.WriteLine(inventarie[i]);
}