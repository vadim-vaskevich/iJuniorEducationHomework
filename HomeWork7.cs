using System;
namespace ijuniorEducationHomework
{
    public class HomeWork7
    {
        /*
        При помощи циклов вы можете повторять один и тот же код множество раз.
        Напишите простейшую программу, которая выводит указанное(установленное) пользователем сообщение заданное количество раз.
        */
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