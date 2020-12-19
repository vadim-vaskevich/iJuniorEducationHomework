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
            int[] arrayNumber = new int[30];
            int minValue = int.MinValue;
            
            Console.WriteLine("Исходный массив:");
            
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                arrayNumber[i] = randomNumber.Next(-100, 100);
                Console.Write(arrayNumber[i] + " ");
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}