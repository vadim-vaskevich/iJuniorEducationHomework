using System;

namespace ijuniorEducationHomework
{
    public class HomeWork12
    {
        public static void Work()
        {
            string nameInput;
            char symbolInput;

            Console.WriteLine("Введите имя:");
            nameInput = Console.ReadLine();

            Console.WriteLine("Введите символ:");
            symbolInput = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"{new string(symbolInput, nameInput.Length + 2)}");
            Console.WriteLine($"{symbolInput}{nameInput}{symbolInput}");
            Console.WriteLine($"{new string(symbolInput, nameInput.Length + 2)}");

            Console.ReadLine();
        }
    }
}