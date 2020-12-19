using System;

namespace ijuniorEducationHomework
{
    public class HomeWork13
    {
        public static void Work()
        {
            string password = "qwe";
            string passwordInput;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"У вас осталось попыток ввода пароля: {3 - i}");

                Console.WriteLine("Введите пароль:");
                passwordInput = Console.ReadLine();

                if (passwordInput == password)
                {
                    Console.WriteLine("Тайное сообщение: Ola-la\nВведите enter для выхода...");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Пароль не верный...");
                }
            }

            Console.WriteLine("Введите enter для выхода...");
            Console.ReadLine();
        }
    }
}