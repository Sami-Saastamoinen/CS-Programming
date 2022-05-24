using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace MovieWatchlog
{
    class MovieWatchLog
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>() { };
            int choice = 0;
            string name = "";
            int duration = 0;
            int year = 0;

            do
            {
                Console.Write("\n\r\n\rMovie Watch Log\n====================\n1) Add Movie\n2) Delete Movie\n3) Show Report\n4) Load Database\n5) Save Database\n6) Quit\nSelection: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("\r");
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add Movie:");
                        Console.Write("Name:");
                        name = Console.ReadLine();
                        Console.Write("Duration (min):");
                        duration = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Year:");
                        year = Convert.ToInt32(Console.ReadLine());
                        movies.Add(new Movie(name, duration, year));
                        break;
                    case 2:
                        Console.WriteLine("Delete Movie:");
                        int idx = 1;
                        foreach (Movie movie in movies)
                        {
                            Console.WriteLine("{0}) {1} ({2}), {3} minutes.  ", idx, movie.Name, movie.Year, movie.Duration);
                            idx++;
                        }
                        Console.Write("Selection: ");
                        idx = Convert.ToInt32(Console.ReadLine());
                        movies.RemoveAt(idx - 1);
                        break;
                    case 3:
                        int total = 0;
                        foreach (Movie movie in movies)
                        {
                            Console.WriteLine("{0} ({1}), {2} minutes.  ", movie.Name, movie.Year, movie.Duration);
                            total += movie.Duration;
                        }
                        Console.WriteLine("\n\rIn total you have watched {0} movies for {1} minutes.", movies.Count, total);
                        break;
                    case 4:
                        if (File.Exists("database.xml"))
                        {
                            XmlSerializer deserializer = new XmlSerializer(typeof(List<Movie>));
                            using (StreamReader reader = new StreamReader("database.xml"))
                            {
                                movies = (List<Movie>)deserializer.Deserialize(reader);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Database not available.");
                        }
                        Console.WriteLine("Database loaded.");
                        break;
                    case 5:
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Movie>));
                        using (StreamWriter sw = new StreamWriter("database.xml"))
                        {
                            serializer.Serialize(sw, movies);
                            sw.Close();
                        }
                        Console.WriteLine("Database saved.");
                        break;
                    case 6:
                        break;

                    default:
                        Console.WriteLine("Invalid selection!");
                        break;
                }
            } while (choice != 6);

        }
    }

    [Serializable]
    public class Movie
    {
        public string Name;
        public int Duration;
        public int Year;
        public Movie()
        {
            this.Name = "";
            this.Duration = 0;
            this.Year = 0;
        }
        public Movie(string name, int duration, int year)
        {
            this.Name = name;
            this.Duration = duration;
            this.Year = year;
        }

    }
}