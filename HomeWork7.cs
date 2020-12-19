using System;
namespace ijuniorEducationHomework
{
    public class HomeWork7
    {
        public static void Work()
        {
            string words;
            int countRepeat;

            Console.WriteLine("Введите любую фразу:");
            words = Console.ReadLine();

            Console.WriteLine("Введите сколько раз ее повторить:");
            countRepeat = int.Parse(Console.ReadLine());

            for (int i = 0; i < countRepeat; i++)
            {
                Console.WriteLine($"{i+1}: {words}");
            }

            Console.ReadLine();
        }
    }
}