using System;

namespace ijuniorEducationHomework
{
    public class HomeWork16
    {
        /*
        Найти наибольший элемент матрицы A(10,10) и записать ноль в ту ячейку, где он находится. Вывести наибольший элемент, исходную и полученную матрицу.
        Массив под измененную версию не нужен.
         */
        public static void Work()
        {
            Random randomNumber = new Random();
            int[,] arrayNumber = new int[10, 10];
            int maxValue = int.MinValue;
            int positionI = 0;
            int positionJ = 0;

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < arrayNumber.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNumber.GetLength(1); j++)
                {
                    arrayNumber[i, j] = randomNumber.Next(0, 100);
                    if (arrayNumber[i, j] > maxValue)
                    {
                        maxValue = arrayNumber[i, j];
                        positionI = i;
                        positionJ = j;
                    }

                    Console.Write(arrayNumber[i, j] + " ");
                }

                Console.WriteLine();
            }

            arrayNumber[positionI, positionJ] = 0;
            Console.WriteLine($"Первое максимальное число: {maxValue}");
            Console.WriteLine("Преобразованный массив:");

            for (int i = 0; i < arrayNumber.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNumber.GetLength(1); j++)
                {
                    if (i == positionI && j == positionJ)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ResetColor();
                    }

                    Console.Write(arrayNumber[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}