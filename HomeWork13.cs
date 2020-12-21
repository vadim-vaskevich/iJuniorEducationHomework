using System;

namespace ijuniorEducationHomework
{
    public class HomeWork13
    {
        /*
        Создайте переменную типа string, в которой хранится пароль для доступа к тайному сообщению. Пользователь вводит пароль, далее происходит проверка пароля на правильность, и если пароль неверный, то попросите его ввести пароль ещё раз. Если пароль подошёл, выведите секретное сообщение.
        Если пользователь неверно ввел пароль 3 раза, программа завершается.
        */
        public static void Work()
        {
            string password = "qwe";
            string passwordInput;
            int numberPasswordTry = 5;

            while (numberPasswordTry > 0)
            {
                Console.WriteLine($"У вас осталось попыток ввода пароля: {numberPasswordTry}");
                numberPasswordTry--;

                Console.WriteLine("Введите пароль:");
                passwordInput = Console.ReadLine();

                if (passwordInput == password)
                {
                    Console.WriteLine("Тайное сообщение: Ola-la");
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