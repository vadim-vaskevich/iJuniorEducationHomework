using System;

namespace ijuniorEducationHomework
{
    public class HomeWork12
    {
        /*
        Вывести имя в прямоугольник из символа, который введет сам пользователь.
        Вы запрашиваете имя, после запрашиваете символ, а после отрисовываете в консоль его имя в прямоугольнике из его символов.

        Пример:
        Alexey
        %

        %%%%%%
        % Alexey %
        %%%%%%

        Примечание:
        Длину строки можно всегда узнать через свойство Length
        string someString = “Hello”;
        Console.WriteLine(someString.Length); //5
         */
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