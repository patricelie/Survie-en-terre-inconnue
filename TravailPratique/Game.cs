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
        /// <value>Numéro du marais.</value>
        public const int Swamp = 1;
        /// <value>Numéro de la forêt.</value>
        public const int Forest = 2;
        /// <value>Numéro de la montagne.</value>
        public const int Mountain = 3;
        /// <value>Numéro de la rivière.</value>
        public const int RIVER = 4;
        /// <value>Numéro de la prairie.</value>
        public const int PRAIRIE = 5;
        /// <value>Numéro de la forêt.</value>
        public const int DESERT = 6;
        /// <value>Conteur marais.</value>
        public static int countSwamp = 0;
        /// <value>Conteur Forêt.</value>
        public static int countForest = 0;
        /// <value>Conteur montagne.</value>
        public static int countMountain = 0;
        /// <value>Conteur rivière.</value>
        public static int countRiver = 0;
        /// <value>Conteur prairie.</value>
        public static int countPrairie = 0;
        /// <value>Conteur desert.</value>
        public static int countDesert = 0;
        /// <value>Conteur feu.</value>
        public static int countFire = 0;
        /// <value>Conteur hache.</value>
        public static int countAxe = 0;
        /// <value>Conteur vitre.</value>
        public static int countWindowpane = 0;
        /// <value>Conteur planche.</value>
        public static int countBoard = 0;
        /// <value>Conteur brique.</value>
        public static int countBrick = 0;
        /// <value>Conteur isolant.</value>
        public static int countInsulating = 0;
        /// <value>Conteur maison.</value>
        public static int countHouse = 0;
        /// <value>Conteur avant l'hiver.</value>
        public static int countHiver = 200;
        /// <value>La carte du jeu.</value>
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
        /// <value>Position X du joueur au départ</value>
        public static int posX = 0;
        /// <value>Position Y du joueur au départ</value>
        public static int posY = 0;
        /// <value>Initialisation du seed pour générer la couleur.</value>
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
            countRiver = 0;
            countPrairie = 0;
            countDesert = 0;
            countFire = 0;
            countAxe = 0;
            countWindowpane = 0;
            countBoard = 0;
            countBrick = 0;
            countInsulating = 0;
            countHouse = 0;
            countHiver = 200;
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
                case RIVER:
                    countRiver++;
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
                    if (countForest >= 2 && countRiver >= 1)
                    {
                        countFire++;
                        countForest -= 2;
                        countRiver--;
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
            int[] backupCounter = { posY, posX, countSwamp, countPrairie, countRiver, countMountain, countForest, countDesert, countFire, countBrick, countAxe, countHouse, countInsulating, countBoard, countWindowpane, countHiver };
            string counter = string.Join(",", backupCounter);
            File.WriteAllText("backup.text", $"{counter}\n");
            string[,] gridValues = new string[10, 10];

            for (int y = 0; y < grid.GetLength(0); y++)
            {
                for (int x = 0; x < grid.GetLength(1); x++)
                {
                    gridValues[y, x] = Convert.ToString(grid[y, x]);
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
            try
            {
                string[] content = File.ReadAllLines("backup.text");
                string counter = content[0].Trim();
                string[] counterDivided = counter.Split(",");

                for (int j = 0; j < counterDivided.Length; j++)
                {
                    posY = Convert.ToInt32(counterDivided[0]);
                    posX = Convert.ToInt32(counterDivided[1]);
                    countSwamp = Convert.ToInt32(counterDivided[2]);
                    countPrairie = Convert.ToInt32(counterDivided[3]);
                    countRiver = Convert.ToInt32(counterDivided[4]);
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
                    string[] cols = content[i].Trim().Split(',');
                    for (int l = 0; l < cols.Length; l++)
                    {
                        if (Int32.TryParse(cols[l], out int nombre))
                        {
                            grid[i - 1, l] = nombre;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors du chargement : {e}");
            }
        }
    }
}
