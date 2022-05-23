using System;
using System.Collections.Generic;

namespace MovieWatchlog
{
    class MovieWatchLog
    {
        static void Main(string[] args)
        {
            List<Leffa> leffat = new List<Leffa>() { };
            int choice = 0;

            do
            {
                Console.Write("\n\r\n\rLeffojen Katseluloki\n====================\n1) Lisää Leffa\n2) Poista Leffa\n3) Näytä Raportti\n4) Lataa Tietokanta\n5) Tallenna Tietokanta\n6) Lopeta\nSyöte: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("\r");
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Lisää Leffa");
                        break;
                    case 2:
                        Console.WriteLine("Poista Leffa");
                        break;
                    case 3:
                        Console.WriteLine("Näytä Raportti");
                        break;
                    case 4:
                        Console.WriteLine("Lataa Tietokanta");
                        break;
                    case 5:
                        Console.WriteLine("Tallenna Tietokanta");
                        break;
                    case 6:
                        break;

                    default:
                        Console.WriteLine("Valinta ei kelpaa!");
                        break;
                }
            } while (choice != 6);

        }
    }

    [Serializable]
    class Leffa
    {
        public string Nimi;
        public int Kesto;
        public int Vuosi;

        public Leffa(string nimi, int kesto, int vuosi)
        {
            this.Nimi = nimi;
            this.Kesto = kesto;
            this.Vuosi = vuosi;
        }

    }
}