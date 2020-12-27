using System;

namespace ijuniorEducationHomework
{
    public class HomeWork21
    {
        public static void Work()
        {
            int number = getNumber();
            Console.WriteLine($"Введенное число: {number}");
            Console.ReadLine();
        }

        static int getNumber()
        {
            int outNumber = 0;
            bool isCorrect = false;

            Console.WriteLine("Введите число:");

            while (!isCorrect)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    isCorrect = true;
                    outNumber = number;
                    Console.WriteLine("Вы ввели число.");
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Вы ввели не число, попробуйте еще раз.");
                }
            }

            return outNumber;
        }
    }
}