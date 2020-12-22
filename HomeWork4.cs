using System;

namespace ijuniorEducationHomework
{
    public class HomeWork4
    {
        public static void Work()
        {
            int totalGold;
            int totalCrystal = 0;
            int priceCrystal = 10;
            int countCrystal;
            bool enoughMoney;

            Console.WriteLine("Введите количество золота:");
            totalGold = int.Parse(Console.ReadLine());

            Console.WriteLine($"Так так, у Вас {totalGold} золотых и {totalCrystal} кристаллов.");
            Console.WriteLine($"Сегодня курс такой: 1 кристалл стоит {priceCrystal} золотых.");

            Console.WriteLine("Введите количество кристаллов для покупки за золото:");
            countCrystal = int.Parse(Console.ReadLine());

            enoughMoney = totalGold >= countCrystal * priceCrystal;
            totalCrystal = countCrystal *= Convert.ToInt32(enoughMoney);
            totalGold -= countCrystal * priceCrystal;

            Console.WriteLine($"Теперь у вас {totalGold} золотых и {totalCrystal} кристаллов.");
            Console.ReadLine();
        }
    }
}