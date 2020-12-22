using System;

namespace ijuniorEducationHomework
{
    public class HomeWork17
    {
        /*
        Дан массив целых чисел из 30 элементов.
        Найдите все локальные максимумы и вывести их. (Элемент является локальным максимумом, если он не имеет соседей, больших, чем он сам)
        Крайние элементы являются локальными максимумами если не имеют соседа большего, чем они сами.
        Программа должна работать с массивом любого размера.
        Массив всех локальных максимумов не нужен.
         */
        public static void Work()
        {
            Random randomNumber = new Random();
            int arraySize = 30;
            int[] arrayNumber = new int[arraySize];

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < arrayNumber.Length; i++)
            {
                arrayNumber[i] = randomNumber.Next(-100, 100);
                Console.Write(arrayNumber[i] + " ");
            }

            Console.WriteLine();
            if (arrayNumber[0] > arrayNumber[1])
            {
                Console.WriteLine($"Локальный максимум {arrayNumber[0]} на позиции [0] ");
            }

            for (int i = 1; i < arrayNumber.Length - 1; ++i)
            {
                if (arrayNumber[i + 1] < arrayNumber[i] && arrayNumber[i - 1] < arrayNumber[i])
                {
                    Console.WriteLine($"Локальный максимум {arrayNumber[i]} на позиции [{i}]");
                }
            }

            if (arrayNumber[arrayNumber.Length - 1] > arrayNumber[arrayNumber.Length - 2])
            {
                Console.WriteLine($"Локальный максимум {arrayNumber[arrayNumber.Length - 1]} " +
                                  $"на позиции [{arrayNumber.Length}]");
            }

            Console.ReadLine();
        }
    }
}