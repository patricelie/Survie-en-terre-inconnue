using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailPratique
{
    internal class Game
    {
        public const int Swamp = 1;
        public const int Forest = 2;
        public const int Mountain = 3;
        public const int RIVIERE = 4;
        public const int PRAIRIE = 5;
        public const int DESERT = 6;
        public static int countSwamp = 0;
        public static int countForest = 0;
        public static int countMountain = 0;
        public static int countRiviere = 0;
        public static int countPrairie = 0;
        public static int countDesert = 0;
        public static int countFire = 0;
        public static int countAxe = 0;
        public static int countWindowpane = 0;
        public static int countBoard = 0;
        public static int countBrick = 0;
        public static int countInsulating = 0;
        public static int countHouse = 0;
        public static int countHiver = 560;
        public static int[,] grid =
        {
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        };
        public static int posX = 0;
        public static int posY = 0;
        public static Random rnd = new Random();

        /// <summary>
        /// Initialise la grille de jeu.
        /// </summary>
        public static void InitializeGame()
        {
            posX = 0;
            posY = 0;
            grid = new int[,]
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            };
            countSwamp = 0;
            countForest = 0;
            countMountain = 0;
            countRiviere = 0;
            countPrairie = 0;
            countDesert = 0;
            countFire = 0;
            countAxe = 0;
            countWindowpane = 0;
            countBoard = 0;
            countBrick = 0;
            countInsulating = 0;
            countHouse = 0;
            countHiver = 300;
        }

        /// <summary>
        /// Assigne un nombre aléatoire à chaque case de la grille.
        /// </summary>
        public static void DiscoverLand()
        {

            if (grid[posY, posX] == 0)
            {
                int number = rnd.Next(1, 7);
                grid[posY, posX] = number;
            }
            if (posY == 0 && posX == 0)
            {
                grid[posY, posX] = 0;
            }
        }

        /// <summary>
        /// Permet le déplacement du joueur.
        /// </summary>
        public static void MoveUp()
        {
            if (posY > 0)
            {
                posY--;
                DiscoverLand();
            }
        }

        public static void MoveDown()
        {

            if (posY < grid.GetLength(0) - 1)
            {
                posY++;
                DiscoverLand();
            }
        }

        public static void MoveLeft()
        {

            if (posX > 0)
            {
                posX--;
                DiscoverLand();
            }
        }

        public static void MoveRight()
        {

            if (posX < grid.GetLength(0) - 1)
            {
                posX++;
                DiscoverLand();
            }
        }

        /// <summary>
        /// Collecte des ressources.
        /// </summary>
        public static void Collect()
        {
            switch (grid[posY, posX])
            {
                case Swamp:
                    countSwamp++;
                    return;
                case Forest:
                    countForest++;
                    return;
                case PRAIRIE:
                    countPrairie++;
                    return;
                case Mountain:
                    countMountain++;
                    return;
                case RIVIERE:
                    countRiviere++;
                    return;
                case DESERT:
                    countDesert++;
                    return;
            }
        }
        /// <summary>
        /// Construction des matériaux.
        /// </summary>
        /// <param name="input">Touche appuyée par le joueur.</param>
        public static void Tools(ConsoleKeyInfo input)
        {
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    if (countForest >= 2 && countRiviere >= 1)
                    {
                        countFire++;
                        countForest -= 2;
                        countRiviere--;
                        WinterTimer();
                    }
                    return;
                case ConsoleKey.D2:
                    if (countForest >= 1 && countMountain >= 1)
                    {
                        countAxe++;
                        countForest--;
                        countMountain--;
                        WinterTimer();
                    }
                    return;
                case ConsoleKey.D3:
                    if (countDesert >= 5 && countFire >= 1)
                    {
                        countWindowpane++;
                        countDesert -= 5;
                        countFire--;
                        WinterTimer();
                    }
                    return;
                case ConsoleKey.D4:
                    if (countForest >= 4 && countAxe >= 1)
                    {
                        countBoard++;
                        countForest -= 4;
                        countAxe--;
                        WinterTimer();
                    }
                    return;
                case ConsoleKey.D5:
                    if (countSwamp >= 3 && countFire >= 1)
                    {
                        countBrick++;
                        countSwamp -= 3;
                        countFire--;
                        WinterTimer();
                    }
                    return;
                case ConsoleKey.D6:
                    if (countPrairie >= 3)
                    {
                        countInsulating++;
                        countPrairie -= 3;
                        WinterTimer();
                    }
                    return;
                case ConsoleKey.D7:
                    if (countBoard >= 4 && countBrick >= 4 && countInsulating >= 4 && countWindowpane >= 2)
                    {
                        countHouse++;
                        countBoard -= 4;
                        countBrick -= 4;
                        countInsulating -= 4;
                        countWindowpane -= 2;
                        WinterTimer();
                    }
                    return;
            }
        }

        /// <summary>
        /// Représente le compteur avant l'hiver.
        /// </summary>
        public static int WinterTimer()
        {
            return countHiver--;
        }
        public static bool IsGameWon()
        {
            return countHouse > 0;
        }

        /// <summary>
        /// Sauvegarde une partie.
        /// </summary>
        public static void Backup()
        {
            int[] backupCounter = {posY,posX,countSwamp,countPrairie,countRiviere,countMountain,countForest,countDesert,countFire,countBrick,countAxe,countHouse,countInsulating,countBoard,countWindowpane,countHiver};
            string counter = string.Join(",", backupCounter);
            File.WriteAllText("backup.text", $"{counter}\n");

            string[,] gridValues = new string[10, 10];
            for (int y = 0; y < grid.GetLength(0); y++)
            {
                for (int x = 0; x < grid.GetLength(1); x++)
                {
                    gridValues[y,x] = Convert.ToString(grid[y, x]);
                    File.AppendAllText("backup.text", $"{gridValues[y, x]},");
                }
                File.AppendAllText("backup.text", "\n");
            }     
        }

        /// <summary>
        /// Charge une partie.
        /// </summary>
        public static void Backupfile()
        {
            int[,] saveGrid = new int[10, 10];
            string[] content = File.ReadAllLines("backup.text");
            string counter = content[0].Trim();
            string[] counterDivided = counter.Split(",");

            for (int j = 0; j < counterDivided.Length; j++)
            {
                posY = Convert.ToInt32(counterDivided[0]);
                posX = Convert.ToInt32(counterDivided[1]);
                countSwamp = Convert.ToInt32(counterDivided[2]);
                countPrairie = Convert.ToInt32(counterDivided[3]);
                countRiviere = Convert.ToInt32(counterDivided[4]);
                countMountain = Convert.ToInt32(counterDivided[5]);
                countForest = Convert.ToInt32(counterDivided[6]);
                countDesert = Convert.ToInt32(counterDivided[7]);
                countFire = Convert.ToInt32(counterDivided[8]);
                countBrick = Convert.ToInt32(counterDivided[9]);
                countAxe = Convert.ToInt32(counterDivided[10]);
                countHouse = Convert.ToInt32(counterDivided[11]);
                countInsulating = Convert.ToInt32(counterDivided[12]);
                countBoard = Convert.ToInt32(counterDivided[13]);
                countWindowpane = Convert.ToInt32(counterDivided[14]);
                countHiver = Convert.ToInt32(counterDivided[15]);
            }

            for (int i = 1; i < content.Length; i++)
            {
                string ligne = content[i].Trim();
                string[] lignes = ligne.Split(',');

                for (int range = 0; range < 9; range++)
                {
                    for (int l = 0; l < lignes.Length; l++)
                    {
                        if (Int32.TryParse(lignes[l], out int nombre))
                        {
                            saveGrid[range, l] = nombre;
                        }
                    }
                }
            }
        }
    }
}
