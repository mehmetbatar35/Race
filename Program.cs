





using RaceOefening;



Race race = new Race();


Console.WriteLine("Race game");
Console.WriteLine("---------");
string menu;

do
{
    Console.WriteLine("1. Schrijf wagen in.");
    Console.WriteLine("2. Overzicht");
    Console.WriteLine("3. Race!");
    Console.WriteLine("4. Stop");
    menu = Console.ReadLine();

    switch (menu)
    {
        case "1":
            Console.WriteLine("  Geef de gegevens van de racewagen:");
            Console.Write("   - Race code: ");
            string code = Console.ReadLine();
            Console.Write("   - Piloot naam: ");
            string piloot = Console.ReadLine();
            Console.WriteLine(race.SchrijfWagenIn(new RaceWagen { Piloot = piloot, RaceCode = code }));
            break;
        case "2":
            Console.WriteLine("Race overzicht\n");
            Console.WriteLine("Deeelnemers:");
            Console.WriteLine(race.RaceWagen1.GeefOmschrijving());
            Console.WriteLine(race.RaceWagen2.GeefOmschrijving());
            Console.WriteLine("\nWinnaar:");
            if (race.Winnaar == null)
            {
                Console.WriteLine(new string('=', 50));
                Console.WriteLine("De winnaar is nog niet gekend!");
                Console.WriteLine(new string('=', 50) + Environment.NewLine);
            }
            else
            {
                Console.WriteLine(new string('=', 50));
                if (race.Winnaar == race.RaceWagen1)
                {
                    Console.WriteLine("Racewagen code: " + race.RaceWagen1.RaceCode + " / nummer: " + race.RaceWagen1.RaceNummer + " / Piloot: " + race.RaceWagen1.Piloot);

                }
                else
                {
                    Console.WriteLine("Racewagen code: " + race.RaceWagen2.RaceCode + " / nummer: " + race.RaceWagen2.RaceNummer + " / Piloot: " + race.RaceWagen2.Piloot);

                }

                Console.WriteLine(new string('=', 50) + Environment.NewLine);
            }
            
            break;
        case "3":
            race.StartRace();
            
            break;
        default:
            break;
    }
    if (menu != "4")
    {
        Console.WriteLine("Druk op een toets om verder te gaan");

        Console.ReadKey();
    }
} while (menu != "4");












