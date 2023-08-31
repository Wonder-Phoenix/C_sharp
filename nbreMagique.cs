// Jeu où l'utilisateur doit trouver un nombre entre 1 et 10 - Fonction RANDOM

using System;

namespace nombre_magique
{
    class Program
    {
        static int DemanderNombre(int min, int max)
        {
            int nombreUtilisateur = max + 1;

            while ((nombreUtilisateur < min) || (nombreUtilisateur > max))
            {
                Console.Write("Rentrez un nombre entre " + min + " et " + max + " : ");
                string reponse = Console.ReadLine();

                try
                {
                    nombreUtilisateur = int.Parse(reponse);

                    if ((nombreUtilisateur < min) || (nombreUtilisateur > max))
                    {
                        Console.WriteLine("ERREUR : le nombre doit être entre " + min + " et " + max);
                    }
                }
                catch
                {
                    Console.WriteLine("ERREUR : rentrez un nombre valide");
                }
            }

            return nombreUtilisateur;
        }

        static void Main(string[] args)
        {
            Random rand = new Random();

            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            int NOMBRE_MAGIQUE = rand.Next(NOMBRE_MIN, NOMBRE_MAX+1);


            int nombre = NOMBRE_MAGIQUE+1;

            int nbVies = 4;

            while (nbVies > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Vies restantes : " + nbVies);
                nombre = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);

                if (NOMBRE_MAGIQUE > nombre)
                {
                    Console.WriteLine("le nombre magique est plus grand");
                }
                else if (NOMBRE_MAGIQUE < nombre)
                {
                    Console.WriteLine("le nombre magique est plus petit");
                }
                else
                {
                    Console.WriteLine("Bravo, vous avez trouvé le nombre magique");
                    break;
                }
                nbVies--;
            }

            if (nbVies == 0) 
            { 
                Console.WriteLine("Vous avez perdu, le nombre magique était : " + NOMBRE_MAGIQUE);
            }
        }
    }
}
