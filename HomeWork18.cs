using System;
using System.Runtime.CompilerServices;

namespace ijuniorEducationHomework
{
    public class HomeWork18
    {
        public static void Work()
        {
            string inputString = null;
            int[] firstArray = new int[0];
            int[] secondArray;
            int amount;

            while (inputString != "exit")
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("Введите число");
                Console.WriteLine("Ввведите sum для подсчета введенных чисел");
                Console.WriteLine("Введите exit - выход из программы");

                inputString = Console.ReadLine();

                switch (inputString)
                {
                    case "sum":
                        amount = 0;

                        for (int i = 0; i < firstArray.Length; i++)
                            amount += firstArray[i];
                        Console.Clear();
                        Console.WriteLine($"Сумма введённых чисел равна {amount}");

                        break;

                    case "exit":
                        Console.WriteLine("Выход из программы...");
                        break;

                    default:
                        int inputNumber = int.Parse(inputString);

                        secondArray = new int[firstArray.Length + 1];
                        secondArray[secondArray.Length - 1] = inputNumber;

                        for (int i = 0; i < firstArray.Length; i++)
                            secondArray[i] = firstArray[i];

                        firstArray = secondArray;
                        Console.Clear();
                        Console.WriteLine($"Размер массива: {firstArray.Length}");

                        break;
                }
            }
        }
    }
}