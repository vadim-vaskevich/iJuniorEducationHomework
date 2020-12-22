using System;

namespace ijuniorEducationHomework
{
    public class HomeWork11
    {
        public static void Work()
        {
            // В последовательности видно, что следующее число это +7, я взял цикл while, потому что я не знаю сколько раз нужно раз плюсовать число, чтобы дойти до 98.
            int numberSummOne = 7;
            while (numberSummOne <= 98)
            {
                Console.Write($"{numberSummOne} ");
                numberSummOne += 7;
            }

            // Если бы это был цикл for, то мне сначала нужно рассчитать количество итераций, чтобы дойти до 98, выглядит не очень.
            int numberSummTwo = 7;
            for (int i = 0; i < 98 / 7; i++)
            {
                Console.Write($"{numberSummTwo} ");
                numberSummTwo += 7;
            }
        }
    }
}