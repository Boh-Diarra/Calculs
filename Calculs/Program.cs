
using System;

namespace Calculs
{
    /// <summary>
    /// Application Calculs : addition ou multiplication de 2 nombres
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            Random rand = new Random();
            int val1, val2;
            int solution;
            int reponse = 0;
            int choix;
            bool correct;

            // Boucle sur le menu
            choix = 1;

            while (choix != 0)
            {
                // Affichage du menu
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");

                // Correction incident n°2 :
                // Vérification de la saisie du choix
                val1 = rand.Next(1, 10);
                val2 = rand.Next(1, 10);
                if (!int.TryParse(Console.ReadLine(), out choix))
                {
                    Console.WriteLine("erreur de saisie");
                    continue;
                }

                // Traitement des choix
                if (choix != 0)
                {
                    if (choix == 1)
                    {
                        // Choix de l'addition
                        //val1 = rand.Next(1, 10);
                        //val2 = rand.Next(1, 10);

                        // Correction incident n°3 :
                        // Répéter jusqu'à une saisie entière valide
                        correct = false;

                        while (!correct)
                        {
                            Console.Write(val1 + " + " + val2 + " = ");

                            correct = int.TryParse(
                                Console.ReadLine(), out reponse);

                            if (!correct)
                            {
                                Console.WriteLine(
                                    "erreur de saisie : veuillez saisir un nombre entier");
                            }
                        }

                        // Comparaison avec la bonne réponse
                        solution = val1 + val2;

                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1
                                + " + " + val2 + " = " + solution);
                        }
                    }
                    else if (choix == 2)
                    {
                        // Choix de la multiplication
                        //val1 = rand.Next(1, 10);
                        //val2 = rand.Next(1, 10);

                        // Correction incident n°3 :
                        // Répéter jusqu'à une saisie entière valide
                        correct = false;

                        while (!correct)
                        {
                            Console.Write(val1 + " x " + val2 + " = ");

                            correct = int.TryParse(
                                Console.ReadLine(), out reponse);

                            if (!correct)
                            {
                                Console.WriteLine(
                                    "erreur de saisie : veuillez saisir un nombre entier");
                            }
                        }

                        // Comparaison avec la bonne réponse
                        solution = val1 * val2;

                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1
                                + " x " + val2 + " = " + solution);
                        }
                    }
                    else
                    {
                        // Correction incident n°1 :
                        // Choix non proposé dans le menub
                        Console.WriteLine("erreur de saisie");
                    }
                }
            }
        }
    }
}
