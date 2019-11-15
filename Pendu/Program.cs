using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            // Lettres
            string mottrouver;
            char lettretest;
            // Test
            int lettrefause,longeurmot,i,test1,test3,test4,test5;
            // Conditions
            bool trouver;
            bool existe;
            // Tableau
            char[] atrouver;
            char[] lettredejatester;

            // Saisie

            Console.WriteLine("Enter un mot a trouver:");
            mottrouver = Console.ReadLine();
            mottrouver = mottrouver.ToLower();
            Console.Clear();

            // Initialisation

            lettrefause = 0;
            test1 = 0;
            test4 = 0;
            i = 0;
            longeurmot = mottrouver.Length;
            trouver = false;
            atrouver = new char[longeurmot];
            lettredejatester = new char[10];
            lettretest = char.Parse("-");

            // ajout _ tableau

            while (i <longeurmot)
            {
                atrouver[i] = char.Parse("_");
                Console.Write(atrouver[i]);
                i++;
            }

            // Tests

            while (lettrefause < 10 && trouver != true)
            {

                try
                {
                    Console.WriteLine("\nEntrer une lettre:");
                    lettretest = char.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Erreur !\nVeuillez entrer UNE SEULE lettre:");
                    Console.ReadKey();
                    Console.ResetColor();
                }

                test1 = 0;
                // Test si lettre est dans le mot
                while (test1 < longeurmot)
                {
                    if (mottrouver[test1] == lettretest)
                    {
                        atrouver[test1] = lettretest;
                        trouver = true;
                    }
                    test1++;
                }

                
                // Test si lettre fausse deja tester

                test5 = 0;
                existe = false;
                if (trouver == false)
                {
                    while (existe != true && test5 < 9)
                    {
                        if(lettretest == lettredejatester[test5])
                        {
                            existe = true;
                            Console.Clear();
                            Console.ResetColor();
                            Console.WriteLine("Vous avez deja tester la lettre: {0}", lettretest);
                            Console.ReadKey();
                        }

                        test5++;
                    }
                    if (existe != true)
                    {
                        // Ajout de la lettre au tableau de test
                        lettredejatester[test4] = lettretest;
                        // Incrémentation des variables
                        test4++;
                        lettrefause++;
                    }
                }

                // Affichage du pendu
                switch (lettrefause)
                {
                    // Si 1 faute
                    case 1:
                        Console.Clear();
                        // Couleur du pendu
                        Console.ForegroundColor = ConsoleColor.Green;
                        // Affichage du pendu
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("===================");
                        break;
                    // Si 2 fautes
                    case 2:
                        Console.Clear();
                        // Couleur du pendu
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        // Affichage du pendu
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("  /||");
                        Console.WriteLine(" //||");
                        Console.WriteLine("===================");
                        break;
                    // Si 3 fautes
                    case 3:
                        Console.Clear();
                        // Couleur du pendu
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        // Affichage du pendu
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   ||");
                        Console.WriteLine("  /||");
                        Console.WriteLine(" //||");
                        Console.WriteLine("===================");
                        break;
                    // Si 4 fautes
                    case 4:
                        Console.Clear();
                        // Couleur du pendu
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        // Affichage du pendu
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("   ||/");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   ||");
                        Console.WriteLine("  /||");
                        Console.WriteLine(" //||");
                        Console.WriteLine("===================");
                        break;
                    // Si 5 fautes
                    case 5:
                        Console.Clear();
                        // Couleur du pendu
                        Console.ForegroundColor = ConsoleColor.Blue;
                        // Affichage du pendu
                        Console.WriteLine("");
                        Console.WriteLine("   ||  /");
                        Console.WriteLine("   || /");
                        Console.WriteLine("   ||/");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   ||");
                        Console.WriteLine("  /||");
                        Console.WriteLine(" //||");
                        Console.WriteLine("===================");
                        break;
                    // Si 6 fautes
                    case 6:
                        Console.Clear();
                        // Couleur du pendu
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        // Affichage du pendu
                        Console.WriteLine("   ,==========Y===");
                        Console.WriteLine("   ||  /");
                        Console.WriteLine("   || /");
                        Console.WriteLine("   ||/");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   ||");
                        Console.WriteLine("  /||");
                        Console.WriteLine(" //||");
                        Console.WriteLine("===================");
                        break;
                    // Si 7 fautes
                    case 7:
                        Console.Clear();
                        // Couleur du pendu
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        // Affichage du pendu
                        Console.WriteLine("   ,==========Y===");
                        Console.WriteLine("   ||  /      |");
                        Console.WriteLine("   || /");
                        Console.WriteLine("   ||/");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   ||");
                        Console.WriteLine("  /||");
                        Console.WriteLine(" //||");
                        Console.WriteLine("===================");
                        break;
                    // Si 8 fautes
                    case 8:
                        Console.Clear();
                        // Couleur du pendu
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        // Affichage du pendu
                        Console.WriteLine("   ,==========Y===");
                        Console.WriteLine("   ||  /      |");
                        Console.WriteLine("   || /       |");
                        Console.WriteLine("   ||/");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   ||");
                        Console.WriteLine("  /||");
                        Console.WriteLine(" //||");
                        Console.WriteLine("===================");
                        break;
                    // Si 9 fautes
                    case 9:
                        Console.Clear();
                        // Couleur du pendu
                        Console.ForegroundColor = ConsoleColor.Red;
                        // Affichage du pendu
                        Console.WriteLine("   ,==========Y===");
                        Console.WriteLine("   ||  /      |");
                        Console.WriteLine("   || /       |");
                        Console.WriteLine("   ||/        O");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   ||");
                        Console.WriteLine("   ||");
                        Console.WriteLine("  /||");
                        Console.WriteLine(" //||");
                        Console.WriteLine("===================");
                        break;
                    default:
                        Console.Clear();
                        // Couleur du pendu
                        Console.ForegroundColor = ConsoleColor.White;
                        // Affichage du pendu
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("___________________");
                        break;
                }

                // Réecriture du pendu avec nouvelle lettre

                i = 0;
                Console.ResetColor();
                Console.WriteLine("Vous faites un nouveau test");
                while (i < longeurmot)
                {
                    Console.Write(atrouver[i]);
                    i++;
                }

                // Test si mot trouver

                trouver = true;
                test3 = 0;
                while (trouver != false && test3 < longeurmot)
                {
                    if(atrouver[test3] != mottrouver[test3])
                    {
                        trouver = false;
                    }
                    test3++;
                }
            }

            // Affichage du résultat du jeu
            if (trouver == true)
            {
                Console.Clear();
                Console.WriteLine("Vous avez trouver le mot {0} avec {1} faute",mottrouver,lettrefause);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Vous n'avez pas touver le mot {0}", mottrouver);
                // Couleur du pendu
                Console.ForegroundColor = ConsoleColor.DarkRed;
                // Affichage du pendu
                Console.WriteLine("   ,==========Y===");
                Console.WriteLine("   ||  /      |");
                Console.WriteLine("   || /       |");
                Console.WriteLine("   ||/        O");
                Console.WriteLine("   ||        /|\\");
                Console.WriteLine("   ||        / \\");
                Console.WriteLine("   ||");
                Console.WriteLine("  /||");
                Console.WriteLine(" //||");
                Console.WriteLine("===================");
            }
            Console.ReadKey();
        }
    }
}
