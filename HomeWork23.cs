using System;

namespace ijuniorEducationHomework
{
    public class HomeWork23
    {
        public static void Work()
        {
            Random random = new Random();
            int[] array = new int[random.Next(5, 10)];

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
                Console.WriteLine($"[{i}] - {array[i]}");
            }

            Shuffle(array);

            Console.WriteLine("Измененный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"[{i}] - {array[i]}");
            }

            Console.ReadLine();
        }

        static void Shuffle(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int tempValue = array[i];
                int tempIndex = i;

                int targetIndexReplace = random.Next(0, array.Length);
                int targetValueReplace = array[targetIndexReplace];

                array[tempIndex] = targetValueReplace;
                array[targetIndexReplace] = tempValue;
            }
        }
    }
}