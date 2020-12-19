using System;
using System.Runtime.InteropServices;

namespace ijuniorEducationHomework
{
    public class HomeWork15
    {
        public static void Work()
        {
            int summa = 0;
            int multiply;

            int[,] arrayFirst =
            {
                {3, 7, 5, 3, 8, 3, 3, 2},
                {6, 7, 2, 4, 6, 7, 2, 1}
            };

            multiply = arrayFirst[0, 0] * arrayFirst[1, 0];
            Console.WriteLine("Исходный двумерный массив:");

            for (int i = 0; i < arrayFirst.GetLength(0); i++)
            {
                for (int j = 0; j < arrayFirst.GetLength(1); j++)
                {
                    Console.Write(arrayFirst[i, j] + " ");
                    if (i == 1)
                    {
                        summa += arrayFirst[1, j];
                    }
                }

                Console.Write("\n");
            }

            Console.WriteLine($"Сумма второй строки: {summa}");
            Console.WriteLine($"Произведение первого столбца: {multiply}");
            Console.ReadKey();
        }
    }
}