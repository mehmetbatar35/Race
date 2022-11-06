using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceOefening
{
    internal class RaceWagen
    {
        string piloot;
        int raceNummer;

        public string RaceCode { get; set; }
        public string Piloot
        {
            get
            {
                return piloot;
            }
            set
            {
                if (value == "")
                {
                    piloot = "Piloot nog toe te wijzen!";
                }
                else
                {
                    piloot = value;
                }
            }
        }
        public int RaceNummer
        {
            get
            {
                return raceNummer;
            }
            set
            {
                if (value < 0)
                {
                    raceNummer = 1;
                }
                else
                {
                    raceNummer = value;
                }
            }
        }

        public string GeefOmschrijving()
        {

            string message = "Racewagencode: " + RaceCode + " / nummer: " + RaceNummer + " / Piloot: " + Piloot;

            return message;

        }
    }
}
