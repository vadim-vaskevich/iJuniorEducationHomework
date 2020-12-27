using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ijuniorEducationHomework
{
    public class HomeWork22
    {
        public static void Work()
        {
            bool isPlaying = true;
            char[,] gameMap;

            char coinSymbol = '$';
            char bombSymbol = 'x';
            char wallSymbol = '#';
            char playerSymbol = '@';
            char enemySymbol = 'S';

            int playerX, playerY;
            int playerDX = 0, playerDY = 0;

            int enemyX, enemyY;
            int enemyDX = 0, enemyDY = 1;

            bool isKilledPlayer = false;
            bool isBombedPlayer = false;

            int maxCoins = 0;
            int collectPlayerCoins = 0;
            int collectEnemyCoins = 0;

            Console.WriteLine("Начальные настройки игры.");

            Console.WriteLine("Введите ширину карты:");
            int width = GetNumber();

            Console.WriteLine("Введите высоту карты:");
            int height = GetNumber();

            Console.WriteLine("Правила игры:");
            Console.WriteLine($"Вы играете за символ [{playerSymbol}], Ваш враг символ [{enemySymbol}].");
            Console.WriteLine($"Собирайте монеты под символом [{coinSymbol}].");
            Console.WriteLine($"При попадании на бомбу под символом [{bombSymbol}] - вы умираете.");
            Console.WriteLine($"При столкновении с врагом [{enemySymbol}] - он вас убивает.");
            Console.WriteLine($"Вы выиграете, если соберете больше монет чем враг.");

            Console.WriteLine("Нажмите enter, чтобы начать игру...");
            Console.ReadLine();
            Console.Clear();

            GenerateGameMap(out gameMap, height, width, wallSymbol);
            GenerateCoins(gameMap, coinSymbol, ref maxCoins);
            GenerateBomb(gameMap, coinSymbol, bombSymbol);
            DrawGameMap(gameMap);

            SetStartPosition(gameMap, out playerX, out playerY, coinSymbol, bombSymbol, playerSymbol, enemySymbol);
            SetStartPosition(gameMap, out enemyX, out enemyY, coinSymbol, bombSymbol, playerSymbol, enemySymbol);

            Console.CursorVisible = false;

            Console.SetCursorPosition(playerY, playerX);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(playerSymbol);

            Console.SetCursorPosition(enemyY, enemyX);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(enemySymbol);

            while (isPlaying)
            {
                Console.SetCursorPosition(0, gameMap.GetLength(0) + 1);
                Console.ResetColor();
                Console.WriteLine($"Всего монет {maxCoins}.");
                Console.WriteLine($"Вы собрали {collectPlayerCoins} монет.");
                Console.WriteLine($"Враг собрал {collectEnemyCoins} монет.");

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    ChangeDirection(key, ref playerDX, ref playerDY);
                }

                if (gameMap[playerX + playerDX, playerY + playerDY] != wallSymbol)
                {
                    CollectCoins(gameMap, playerX, playerY, coinSymbol, ref collectPlayerCoins);
                    MoveUnit(ref playerX, ref playerY, playerDX, playerDY, playerSymbol, ConsoleColor.Green);
                }

                if (gameMap[enemyX + enemyDX, enemyY + enemyDY] != wallSymbol &&
                    gameMap[enemyX + enemyDX, enemyY + enemyDY] != bombSymbol)
                {
                    CollectCoins(gameMap, enemyX, enemyY, coinSymbol, ref collectEnemyCoins);
                    MoveUnit(ref enemyX, ref enemyY, enemyDX, enemyDY, enemySymbol, ConsoleColor.Red);
                    ChangeDirection(ref enemyDX, ref enemyDY);
                }
                else
                {
                    ChangeDirection(ref enemyDX, ref enemyDY);
                }

                if (gameMap[playerX, playerY] == bombSymbol)
                {
                    isPlaying = false;
                    isBombedPlayer = true;
                }

                if (playerX == enemyX && playerY == enemyY)
                {
                    isPlaying = false;
                    isKilledPlayer = true;
                }

                if ((collectPlayerCoins + collectEnemyCoins) == maxCoins)
                {
                    isPlaying = false;
                }

                System.Threading.Thread.Sleep(300);
            }

            if (collectPlayerCoins > collectEnemyCoins && !isBombedPlayer && !isKilledPlayer)
            {
                Console.SetCursorPosition(0, gameMap.GetLength(0) + 4);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Вы победили! Вы собрали больше монет, чем враг!");
            }
            else if (collectPlayerCoins < collectEnemyCoins && !isBombedPlayer && !isKilledPlayer)
            {
                Console.SetCursorPosition(0, gameMap.GetLength(0) + 4);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы проиграли! Вы собрали меньше монет, чем враг!");
            }
            else if (collectPlayerCoins == collectEnemyCoins && !isBombedPlayer && !isKilledPlayer)
            {
                Console.SetCursorPosition(0, gameMap.GetLength(0) + 4);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ничья! Вы собрали одинаковое количество монет с врагом!");
            }

            if (isBombedPlayer)
            {
                Console.SetCursorPosition(0, gameMap.GetLength(0) + 4);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы подорвались на бомбе!");
            }

            if (isKilledPlayer)
            {
                Console.SetCursorPosition(0, gameMap.GetLength(0) + 4);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вас убил враг!");
            }

            Console.ReadLine();
        }

        static void CollectCoins(char[,] map, int x, int y, char coinSymbol, ref int collectCoins)
        {
            if (map[x, y] == coinSymbol)
            {
                collectCoins++;
                map[x, y] = ' ';
            }
        }

        static void ChangeDirection(ConsoleKeyInfo key, ref int DX, ref int DY)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    DX = -1;
                    DY = 0;
                    break;
                case ConsoleKey.DownArrow:
                    DX = 1;
                    DY = 0;
                    break;
                case ConsoleKey.LeftArrow:
                    DX = 0;
                    DY = -1;
                    break;
                case ConsoleKey.RightArrow:
                    DX = 0;
                    DY = 1;
                    break;
            }
        }

        static void ChangeDirection(ref int DX, ref int DY)
        {
            Random random = new Random();
            int enemyDir = random.Next(1, 5);

            switch (enemyDir)
            {
                case 1:
                    if ((DX != -1) && (DY != 0))
                    {
                        DX = -1;
                        DY = 0;
                    }

                    break;

                case 2:
                    if ((DX != 1) && (DY != 0))
                    {
                        DX = 1;
                        DY = 0;
                    }

                    break;

                case 3:
                    if ((DX != 0) && (DY != -1))
                    {
                        DX = 0;
                        DY = -1;
                    }

                    break;

                case 4:
                    if ((DX != 0) && (DY != 1))
                    {
                        DX = 0;
                        DY = 1;
                    }

                    break;
            }
        }

        static void MoveUnit(ref int X, ref int Y, int DX, int DY, char unitSymbol, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(Y, X);
            Console.Write(' ');

            X += DX;
            Y += DY;

            Console.SetCursorPosition(Y, X);
            Console.Write(unitSymbol);
        }

        static void GenerateGameMap(out char[,] map, int width, int height, char wallSymbol)
        {
            map = new char[width, height];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (i == 0 || i == map.GetLength(0) - 1 || j == 0 || j == map.GetLength(1) - 1)
                    {
                        map[i, j] = wallSymbol;
                    }
                    else
                    {
                        map[i, j] = ' ';
                    }
                }
            }
        }

        static void GenerateCoins(char[,] map, char coinSymbol, ref int maxCoins)
        {
            Random random = new Random();

            int width = map.GetLength(0) - 2;
            int height = map.GetLength(1) - 2;

            int minCountCoin = Convert.ToInt32(((width * height) - (width * 2 + height * 2)) * 0.2);
            int maxCountCoin = Convert.ToInt32(((width * height) - (width * 2 + height * 2)) * 0.3);
            int randomMaxCoin = random.Next(minCountCoin, maxCountCoin);

            maxCoins = randomMaxCoin;

            while (randomMaxCoin > 0)
            {
                int i = random.Next(1, width);
                int j = random.Next(1, height);

                if (map[i, j] != coinSymbol)
                {
                    map[i, j] = coinSymbol;
                    randomMaxCoin--;
                }
            }
        }

        static void GenerateBomb(char[,] map, char coinSymbol, char bombSymbol)
        {
            Random random = new Random();

            int width = map.GetLength(0) - 2;
            int height = map.GetLength(1) - 2;

            int minCountBomb = Convert.ToInt32(((width * height) - (width * 2 + height * 2)) * 0.01);
            int maxCountBomb = Convert.ToInt32(((width * height) - (width * 2 + height * 2)) * 0.05);
            int randomMaxBomb = random.Next(minCountBomb, maxCountBomb);

            while (randomMaxBomb > 0)
            {
                int i = random.Next(1, width);
                int j = random.Next(1, height);

                if (map[i, j] != coinSymbol && map[i, j] != bombSymbol)
                {
                    map[i, j] = bombSymbol;
                    randomMaxBomb--;
                }
            }
        }

        static void DrawGameMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }

                Console.WriteLine();
            }
        }

        static int GetNumber()
        {
            int outNumber = 0;
            bool isCorrect = false;

            while (!isCorrect)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    isCorrect = true;
                    outNumber = number;
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Вы ввели не число, попробуйте еще раз.");
                }
            }

            return outNumber;
        }

        static void SetStartPosition(char[,] map, out int X, out int Y,
            char coinSymbol, char bombSymbol, char playerSymbol, char enemySymbol)
        {
            X = 0;
            Y = 0;
            bool isPlaced = false;
            Random random = new Random();

            while (!isPlaced)
            {
                int i = random.Next(1, map.GetLength(0) - 1);
                int j = random.Next(1, map.GetLength(1) - 1);

                if (map[i, j] != coinSymbol && map[i, j] != bombSymbol &&
                    map[i, j] != playerSymbol && map[i, j] != enemySymbol)
                {
                    X = i;
                    Y = j;
                    map[i, j] = playerSymbol;
                    isPlaced = true;
                }
            }
        }
    }
}