using System;
using System.Runtime.InteropServices;

namespace ijuniorEducationHomework
{
    public class HomeWork15
    {
        /*
        Дан двумерный массив.
        Вычислить сумму второй строки и произведение первого столбца. Вывести исходную матрицу и результаты вычислений.
         */
        public static void Work()
        {
            int summaResult = 0;
            int multiplyResult = 1;

            Random randomNumberGenerator = new Random();
            int sizeColumnGenerate = randomNumberGenerator.Next(2, 10);
            int sizeRowGenerate = randomNumberGenerator.Next(2, 10);

            int[,] arrayFirst = new int[sizeColumnGenerate, sizeRowGenerate];

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < arrayFirst.GetLength(0); i++)
            {
                for (int j = 0; j < arrayFirst.GetLength(1); j++)
                {
                    arrayFirst[i, j] = randomNumberGenerator.Next(1, 10);
                    Console.Write(arrayFirst[i, j] + " ");

                    if (i == 0)
                    {
                        summaResult += arrayFirst[0, j];
                    }
                }

                multiplyResult *= arrayFirst[i, 0];
                Console.Write("\n");
            }

            Console.WriteLine($"Сумма второй строки: {summaResult}");
            Console.WriteLine($"Произведение первого столбца: {multiplyResult}");
            Console.ReadKey();
        }
    }
}