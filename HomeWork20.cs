using System;

namespace ijuniorEducationHomework
{
    public class HomeWork20
    {
        public static void Work()
        {
            int healt = 0, mana = 0;
            bool isExit = false;

            while (!isExit)
            {
                drawBar(healt, 0, '#');
                drawBar(mana, 1, '#');

                Console.SetCursorPosition(0, 3);

                Console.WriteLine("Введите сколько % жизней закрасить:");
                healt = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите сколько % маны закрасить:");
                mana = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите exit, чтобы выйти или enter для продолжения.");
                if (Console.ReadLine() == "exit")
                {
                    isExit = true;
                }

                Console.Clear();
            }
        }

        static void drawBar(int inputValue, int position, char symbol = '#')
        {
            int drawValue = 0;
            int maxDrawValue = 10;

            Console.SetCursorPosition(0, position);

            if (inputValue < 100 && inputValue >= 0)
            {
                if (inputValue > 0 && inputValue < 10)
                {
                    drawValue = 1;
                }
                else
                {
                    drawValue = inputValue / 10;
                }

                Console.Write('[');

                for (int i = 0; i < drawValue; i++)
                {
                    Console.Write(symbol);
                }

                for (int i = drawValue; i < maxDrawValue; i++)
                {
                    Console.Write('_');
                }

                Console.Write(']');
            }
            else
            {
                Console.Write("Закрашеваемое количество % нужно ввести в диапазоне от 0 до 100");
            }
        }
    }
}