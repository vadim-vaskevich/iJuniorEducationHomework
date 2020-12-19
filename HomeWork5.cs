using System;
namespace ijuniorEducationHomework
{
    public class HomeWork5
    {
        /*
        Легенда:
        Вы заходите в поликлинику и видите огромную очередь из старушек, вам нужно рассчитать время ожидания в очереди.

        Формально:
        Пользователь вводит кол-во людей в очереди.
        Фиксированное время приема одного человека всегда равно 10 минутам.
        Пример ввода: Введите кол-во старушек: 14
        Пример вывода: "Вы должны отстоять в очереди 2 часа и 20 минут."
         */
        public static void Work()
        {
            int countPeople;
            int timeMinuteInspection = 10;

            Console.WriteLine("Введите количество людей в очереди:");
            countPeople = int.Parse(Console.ReadLine());

            Console.WriteLine($"Вы должны отстоять в очереди {(countPeople * timeMinuteInspection) / 60} часа и {(countPeople * timeMinuteInspection) % 60} минут.");
        }
    }
}