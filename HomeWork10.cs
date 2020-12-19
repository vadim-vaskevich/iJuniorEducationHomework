using System;

namespace ijuniorEducationHomework
{
    public class HomeWork10
    {
        public static void Work()
        {
            string userInput = null;
            string passwordInput;
            string nameUser = null;
            string passsword = null;
            string colorConsoleInput;
            Random randomCoin = new Random();

            while (userInput != "6")
            {
                Console.WriteLine("1. Введите имя");
                Console.WriteLine("2. Сменить цвет консоли");
                Console.WriteLine("3. Установить пароль");
                Console.WriteLine("4. Вывести имя");
                Console.WriteLine("5. Подбросить монетку");
                Console.WriteLine("6. Выход из программы");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Введите имя");
                        nameUser = Console.ReadLine();
                        Console.WriteLine("Имя задано.\nНажмите enter для продолжения...");
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("Выберите новый цвет консоли:");
                        Console.WriteLine("1. Зеленый");
                        Console.WriteLine("2. Красный");
                        Console.WriteLine("3. Желтый");
                        Console.WriteLine("4. По умолчанию");
                        colorConsoleInput = Console.ReadLine();
                        switch (colorConsoleInput)
                        {
                            case "1":
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Clear();
                                break;
                            case "2":
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Clear();
                                break;
                            case "3":
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.Clear();
                                break;
                            case "4":
                                Console.ResetColor();
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine(
                                    "Вы ввели что-то не то, попробуйте еще раз. Для продолжения нажмите enter");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                        }

                        break;

                    case "3":
                        Console.WriteLine("Введите пароль:");
                        passsword = Console.ReadLine();
                        Console.WriteLine("Пароль задан.\nНажмите enter для продолжения...");
                        Console.ReadLine();
                        break;

                    case "4":
                        if (passsword != null && nameUser != null)
                        {
                            Console.WriteLine("Введите пароль:");
                            passwordInput = Console.ReadLine();
                            if (passwordInput == passsword)
                            {
                                Console.WriteLine($"Заданное имя: {nameUser}");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Неверный пароль.\nНажмите enter для продолжения...");
                                Console.ReadLine();
                            }
                        }
                        else if (passsword == null)
                        {
                            Console.WriteLine(
                                "Пароль не задан, выберите вариант меню, чтобы задать его.\nНажмите enter для продолжения...");
                            Console.ReadLine();
                        }
                        else if (nameUser == null)
                        {
                            Console.WriteLine(
                                "Имя не задано, выберите вариант меню, чтобы задать его.\nНажмите enter для продолжения...");
                            Console.ReadLine();
                        }

                        break;

                    case "5":
                        switch (randomCoin.Next(0, 3))
                        {
                            case 0:
                                Console.WriteLine("Вам выпала: Решка\nНажмите enter для продолжения...");
                                Console.ReadLine();
                                break;
                            case 1:
                                Console.WriteLine("Вам выпал: Орел\nНажмите enter для продолжения...");
                                Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Монетка упала на ребро\nНажмите enter для продолжения...");
                                Console.ReadLine();
                                break;
                        }

                        break;

                    case "6":
                        Console.WriteLine("Выход из программы, нажмите enter");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Вы ввели что-то не то, попробуйте еще раз. Для продолжения нажмите enter");
                        Console.ReadLine();
                        break;
                }

                Console.Clear();
            }
        }
    }
}