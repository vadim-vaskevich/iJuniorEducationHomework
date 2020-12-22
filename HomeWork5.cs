using System;

namespace ijuniorEducationHomework
{
    public class HomeWork5
    {
        public static void Work()
        {
            int countPeople;
            int timeMinuteInspection = 10;

            Console.WriteLine("Введите количество людей в очереди:");
            countPeople = int.Parse(Console.ReadLine());

            Console.WriteLine(
                $"Вы должны отстоять в очереди {(countPeople * timeMinuteInspection) / 60} часа и {(countPeople * timeMinuteInspection) % 60} минут.");
        }
    }
}