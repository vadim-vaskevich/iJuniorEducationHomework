using System;
using System.Runtime.InteropServices;

namespace ijuniorEducationHomework
{
    public class HomeWork15
    {
        public static void Work()
        {
            int sumResult = 0;
            int multiplyResult = 1;

            Random randomNumberGenerator = new Random();
            int sizeColumnGenerate = randomNumberGenerator.Next(2, 5);
            int sizeRowGenerate = randomNumberGenerator.Next(2, 4);

            int[,] arrayFirst = new int[sizeColumnGenerate, sizeRowGenerate];

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < arrayFirst.GetLength(0); i++)
            {
                for (int j = 0; j < arrayFirst.GetLength(1); j++)
                {
                    arrayFirst[i, j] = randomNumberGenerator.Next(1, 10);
                    Console.Write(arrayFirst[i, j] + " ");
                }

                Console.Write("\n");
            }

            for (int i = 0; i < arrayFirst.GetLength(1); i++)
            {
                sumResult += arrayFirst[1, i];
            }

            for (int i = 0; i < arrayFirst.GetLength(0); i++)
            {
                multiplyResult *= arrayFirst[i, 0];
            }

            Console.WriteLine($"Сумма второй строки: {sumResult}");
            Console.WriteLine($"Произведение первого столбца: {multiplyResult}");
            Console.ReadKey();
        }
    }
}