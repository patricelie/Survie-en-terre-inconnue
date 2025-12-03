using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TravailPratique
{
    internal class Controller
    {
        /// <summary>
        /// Contrôle le menu du jeu.
        /// </summary>
        public static void MenuController()
        {
            while (true)
            {
                Console.Clear();
                View.DisplayMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Game.InitializeGame();
                        GameController();
                        break;
                    case "2":
                        Console.Clear();
                        Game.Backupfile();
                        GameController();
                        break;
                    case "3":
                        Game.Backup();
                        View.SaveGame();
                        ConsoleKeyInfo toucheSave = Console.ReadKey();
                        break;
                    case "4":
                        View.DisplayCredits();
                        ConsoleKeyInfo touche = Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        View.EndGame();
                        return;
                    default:
                        View.ValidOption();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            }
        }

        /// <summary>
        /// Contrôle le jeu.
        /// </summary>
        public static void GameController()
        {
            while (true)
            {
                Console.Clear();
                View.DisplayGameMenu();
                View.DisplayGrid(Game.grid, Game.posY, Game.posX);
                ConsoleKeyInfo input = Console.ReadKey();
                if (Game.countHiver > 0)
                {
                    switch (input.Key)
                    {
                        case ConsoleKey.UpArrow:
                            Game.MoveUp();
                            Game.WinterTimer();
                            break;
                        case ConsoleKey.DownArrow:
                            Game.MoveDown();
                            Game.WinterTimer();
                            break;
                        case ConsoleKey.LeftArrow:
                            Game.MoveLeft();
                            Game.WinterTimer();
                            break;
                        case ConsoleKey.RightArrow:
                            Game.MoveRight();
                            Game.WinterTimer();
                            break;
                        case ConsoleKey.Spacebar:
                            Game.Collect();
                            Game.WinterTimer();
                            break;
                        case ConsoleKey.Enter:
                            if (Game.posY == 0 && Game.posX == 0)
                            {
                                BuildController();
                            }
                            else
                            {
                                MenuGameController();
                            }
                            break;
                        case ConsoleKey.Escape:
                            return;
                    }
                }
                else
                {
                    View.DisplayGameOver();
                    return;
                }
                if (Game.IsGameWon())
                {
                    View.Succeed();
                    return;
                }
            }

        }

        /// <summary>
        /// Contrôle l'affichage des matériaux.
        /// </summary>
        public static void BuildController()
        {
            while (true)
            {
                Console.Clear();
                View.DisplayMaterial();
                ConsoleKeyInfo input = Console.ReadKey();
                Game.Tools(input);
                if (input.Key == ConsoleKey.Enter || Game.IsGameWon())
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Contrôle la fabrication des matériaux.
        /// </summary>
        public static void MenuGameController()
        {
            while (true)
            {
                Console.Clear();
                View.DisplayInventory();
                ConsoleKeyInfo touche = Console.ReadKey();
                if (touche.Key == ConsoleKey.Enter)
                {
                    return;
                }
            } 
        }
    }
}
