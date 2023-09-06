using System;
using System.Collections.Generic;

namespace programme_collections
{
    class Program
    {
        static void ListesDeListes()
        {

            var teams = new List<List<string>>();

            teams.Add(new List<string> { "Team A", "Marie", "Nicolas", "Sophie", "Paul", "Clara" });
            teams.Add(new List<string> { "Team B", "Jean", "Charles", "Nina", "Christophe" });
            teams.Add(new List<string> { "Team C", "Jade", "Florence", "Jeanne", "Simon" });
            teams.Add(new List<string> { "Team D", "Anna", "Léo", "Isaac", "Alice" });
            teams.Add(new List<string> { "Team E", "Arthur", "Léa", "Jean-Baptiste", "Nathan", "Frédérique" });
            teams.Add(new List<string> { "Team F", "Ambre", "Elliot", "Inès", "Hugo", "Olivier" });

            for (int i = 0; i < teams.Count; i++)
            {
                var p = teams[i];
                Console.WriteLine(p[0] + " - " + (p.Count-1) + " membres");
                for (int j = 1; j < p.Count; j++)
                {
                    Console.WriteLine("  " + p[j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            ListesDeListes();
        }
    }
}
