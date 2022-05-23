using System;
namespace MovieWatchlog
{
    class MovieWatchLog
    {
        static void Main(string[] args)
        {
            List<Leffa> leffat = new List<Leffa>() { };
            leffat.Add(new Leffa("Robocop", 102, 1987));
            leffat.Add(new Leffa("Robocop 2", 117, 1990));
            leffat.Add(new Leffa("Robocop 3", 104, 1993));

            foreach (var leffa in leffat)
            {
                Console.Write("Name: " + leffa.Nimi + ", duration: " + leffa.Kesto + "min, year: " + leffa.Vuosi + "\n\r");
            }
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