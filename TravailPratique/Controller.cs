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
                        InitializeGame();
                        break;
                    case "2":
                        GameController();
                        break;
                    case "3":
                        break;
                    case "4":
                        View.DisplayCredits();
                        ConsoleKeyInfo touche = Console.ReadKey();
                        if (touche.Key == ConsoleKey.Enter)
                        {
                            MenuController();
                        }
                        break;
                    case "5":
                        return;
                }

            }
        }
        public static void GameController()
        {
            while (true)
            {
                Console.Clear();
                View.DisplayGameMenu();
                View.DisplayGrid(Game.grid, Game.posY, Game.posX);
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        Game.MoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        Game.MoveDown();
                        break;
                    case ConsoleKey.LeftArrow:
                        Game.MoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        Game.MoveRight();
                        break;
                    case ConsoleKey.Spacebar:
                        Game.Collect(Game.grid);
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
                        MenuController();
                        break;
                }
            }

        }

        public static void BuildController()
        {
            while (true)
            {
                Console.Clear();
                View.DisplayMaterial();
                ConsoleKeyInfo input = Console.ReadKey();
                Game.Tools(input);
                if (input.Key == ConsoleKey.Enter)
                {
                    GameController();
                }
            }
        }
        public static void InitializeGame()
        {
         
            Game.posY = 0;
            Game.posX = 0;
            GameController();
        }

        public static void MenuGameController()
        {
            while (true)
            {
                Console.Clear();
                View.DisplayInventory();
                ConsoleKeyInfo touche = Console.ReadKey();
                if (touche.Key == ConsoleKey.Enter)
                {
                    GameController();
                }
            }
        }
    }
}
