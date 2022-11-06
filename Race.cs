using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceOefening
{
    internal class Race
    {

        public RaceWagen RaceWagen1 { get; private set; }
        public RaceWagen RaceWagen2 { get; private set; }
        public RaceWagen Winnaar { get; private set; }



        public string SchrijfWagenIn(RaceWagen raceWagen)
        {          
            string inschrijving = String.Empty;

            if (RaceWagen1 == null)
            {
                RaceWagen1 = raceWagen;

                RaceWagen1.RaceNummer = new Random().Next(1000);

                inschrijving += "Racewagen 1 ingeschreven! Nummer: " + RaceWagen1.RaceNummer;

            }
            else if (RaceWagen2 == null)
            {
                RaceWagen2 = raceWagen;

                RaceWagen2.RaceNummer = new Random().Next(1000);

                inschrijving += "Racewagen 2 ingeschreven! Nummer: " + RaceWagen2.RaceNummer;
            }
            else
            {
                
                inschrijving += "Geen vrije plaatsen!";
            }
            return inschrijving;
        }
        public bool StartRace()
        {
            bool isStartRace = (RaceWagen1 != null && RaceWagen2 != null);

            int winnaar = new Random().Next(2);

            if (isStartRace)
            {
                Console.WriteLine("De winnaar van de race is: ");
                Console.WriteLine("----------------------------");
                Winnaar = (winnaar == 0) ? RaceWagen1 : RaceWagen2;
                Console.WriteLine("Racewagen code: " + Winnaar.RaceCode + " / nummer: " + Winnaar.RaceNummer + " / Piloot: " + Winnaar.Piloot);
                return true;
            }
            else
            {
                Console.WriteLine("Het is onmogelijk om de race te starten. Omdat er geen twee Racewagen zijn.");
                return false;
            }

            Console.WriteLine("\n=============================");


            return isStartRace;
        }
    }
}
