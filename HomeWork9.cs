using System;
namespace ijuniorEducationHomework
{
    public class HomeWork9
    {
        /*
        Написать конвертер валют (3 валюты).
        У пользователя есть баланс в каждой из представленных валют. Он может попросить сконвертировать часть баланса с одной валюты в другую. Тогда у него с баланса одной валюты снимется X и зачислится на баланс другой Y. Курс конвертации должен быть просто прописан в программе.
        Программа должна завершиться тогда, когда это решит пользователь.
        */
        public static void Work()
        {
            int rubToUsd = 73, usdToRub = 71;
            float rub;
            float usd;
            int userInput;
            float currencyCount;
            string exitProgram = null;

            Console.WriteLine("Сколько у вас рублей?");
            rub = float.Parse(Console.ReadLine());

            Console.WriteLine("Сколько у вас долларов?");
            usd = float.Parse(Console.ReadLine());

            while (exitProgram != "x")
            {
                Console.WriteLine($"Отлично, у вас {rub} рублей, {usd} долларов.");
                Console.WriteLine($"Сегодня в нашем банке такие курсы: USD в RUB: {usdToRub}, RUB в USD: {rubToUsd}.");

                Console.WriteLine("1 - Обменять RUB в USD.");
                Console.WriteLine("2 - Обменять USD в RUB.");
                userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Сколько RUB вы хотите обменять на USD?");
                        currencyCount = int.Parse(Console.ReadLine());
                        if (currencyCount <= rub)
                        {
                            rub -= currencyCount;
                            usd += currencyCount / rubToUsd;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество рублей.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Сколько USD вы хотите обменять на RUB?");
                        currencyCount = int.Parse(Console.ReadLine());
                        if (currencyCount <= usd)
                        {
                            usd -= currencyCount;
                            rub += currencyCount * usdToRub;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество рублей.");
                        }
                        break;

                    default:
                        Console.WriteLine("Ыы выбрали что-то не то.");
                        break;
                }

                Console.WriteLine("Чтобы выйти из программы введите: x");
                exitProgram = Console.ReadLine();
            }
        }
    }
}