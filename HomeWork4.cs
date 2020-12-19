using System;
namespace ijuniorEducationHomework
{
    public class HomeWork4
    {
        /*
        Легенда:
        Вы приходите в магазин и хотите купить за своё золото кристаллы. В вашем кошельке есть какое-то количество золота, продавец спрашивает у вас, сколько кристаллов вы хотите купить? После сделки у вас остаётся какое-то количество золота и появляется какое-то количество кристаллов.

        Формально:
        При старте программы пользователь вводит начальное количество золота. Потом ему предлагается купить какое-то количество кристаллов по цене N(задать в программе самому). Пользователь вводит число и его золото конвертируется в кристаллы. Остаток золота и кристаллов выводится на экран.
        */
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