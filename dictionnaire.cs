using System;

namespace programme_collections
{
    class Program
    {
        static void Dictionnaire()
        {
            string personneAChercher = "Sophie";
            var d = new Dictionary<string, string>();
            d["Jean"] = "0611223344";
            d["Marie"] = "0611223355";
            d["Martin"] = "0611223366";
            d["Paul"] = "0611223377";
            d["Claude"] = "0611223388";
            d["Sophie"] = "0611223399";
            d["Fiona"] = "0711223344";
            d["Frédérique"] = "0711223355";
            d["Elliot"] = "0711223366";
            d["Jean-Paul"] = "0711223377";
            d["Franck"] = "0711223388";
            d["Léa"] = "0711223399";

            if (d.ContainsKey(personneAChercher))
            {
                Console.WriteLine("Le numéro de " + personneAChercher + " est : " + d[personneAChercher]);
            }
            else
            {
                Console.WriteLine("Cette personne n'a pas été trouvée");
            }
        }

        static void Main(string[] args)
        {
            Dictionnaire();
        }
    }
}
