using System;
using System.Runtime.InteropServices;

namespace ijuniorEducationHomework
{
    public class HomeWork19
    {
        public static void Work()
        {
            string[] nameArray = new string[0];
            string[] officeArray = new string[0];
            int choiceUser;
            bool isExit = false;

            while (!isExit)
            {
                Console.WriteLine("1. Добавить досье");
                Console.WriteLine("2. Вывести все досье");
                Console.WriteLine("3. Удалить досье");
                Console.WriteLine("4. Поиск по фамилии");
                Console.WriteLine("5. Выход");

                choiceUser = int.Parse(Console.ReadLine());

                switch (choiceUser)
                {
                    case 1:
                        Console.WriteLine("Введите фамилию:");
                        addName(ref nameArray, Console.ReadLine());

                        Console.WriteLine("Введите должность:");
                        addDossier(ref officeArray, Console.ReadLine());

                        Console.WriteLine("Досье добавлено.");
                        break;

                    case 2:
                        showDossiers(nameArray, officeArray);
                        break;

                    case 3:
                        if (officeArray.Length > 0)
                        {
                            showDossiers(nameArray, officeArray);
                            if (nameArray.Length > 0)
                            {
                                Console.WriteLine("Введите номер досье, которое хотите удалить:");
                                deleteDossier(ref nameArray, ref officeArray, int.Parse(Console.ReadLine()));
                            }
                        }
                        else
                        {
                            Console.WriteLine("В базе нет досье...");
                        }

                        break;

                    case 4:
                        Console.WriteLine("Введите фамилию для поиска:");
                        searchName(nameArray, officeArray, Console.ReadLine());

                        break;

                    case 5:
                        isExit = true;
                        Console.WriteLine("Выход...");
                        break;

                    default:
                        Console.WriteLine("Чет вы промазали кнопкой, попробуйте еще...");
                        break;
                }

                if (choiceUser != 5)
                {
                    Console.WriteLine("Нажмите любую клавишу для возврата в меню...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        static void addDossier(ref string[] officeArray, string inputDossier)
        {
            string[] tempArray = new string[officeArray.Length + 1];

            for (int i = 0; i < officeArray.Length; i++)
            {
                tempArray[i] = officeArray[i];
            }

            tempArray[officeArray.Length] = inputDossier;
            officeArray = tempArray;
        }

        static void addName(ref string[] nameArray, string inputName)
        {
            string[] tempArray = new string[nameArray.Length + 1];

            for (int i = 0; i < nameArray.Length; i++)
            {
                tempArray[i] = nameArray[i];
            }

            tempArray[nameArray.Length] = inputName;
            nameArray = tempArray;
        }

        static void showDossiers(string[] officeArray, string[] nameArray)
        {
            if (officeArray.Length > 0)
            {
                Console.WriteLine("Все досье:");
                for (int i = 0; i < nameArray.Length; i++)
                {
                    Console.WriteLine($"[{i + 1}]. {nameArray[i]} - {officeArray[i]}");
                }
            }
            else
            {
                Console.WriteLine("В базе нет досье...");
            }
        }

        static void searchName(string[] officeArray, string[] nameArray, string searchString)
        {
            bool isfound = false;

            if (officeArray.Length > 0)
            {
                for (int i = 0; i < nameArray.Length; i++)
                {
                    if (nameArray[i] == searchString)
                    {
                        Console.WriteLine($"Найдено досье: [{i + 1}]. {nameArray[i]} - {officeArray[i]}");
                        isfound = true;
                    }
                }

                if (!isfound)
                {
                    Console.WriteLine($"Досье с фамилией \"{searchString}\" - не найдено.");
                }
            }
            else
            {
                Console.WriteLine("В базе нет досье...");
            }
        }

        static void deleteDossier(ref string[] officeArray, ref string[] nameArray, int deleteIndex)
        {
            if (deleteIndex - 1 >= 0 && deleteIndex - 1 <= nameArray.Length)
            {
                string[] tempOfficeArray = new string[officeArray.Length - 1];
                string[] tempNameArray = new string[nameArray.Length - 1];
                int indexCounter = 0;

                for (int i = 0; i < officeArray.Length; i++)
                {
                    if (i == deleteIndex - 1)
                    {
                        Console.WriteLine($"Удалено досье: [{i + 1}]. {nameArray[i]} - {officeArray[i]}");
                    }
                    else
                    {
                        tempOfficeArray[indexCounter] = officeArray[i];
                        tempNameArray[indexCounter] = nameArray[i];
                        indexCounter++;
                    }
                }

                officeArray = tempOfficeArray;
                nameArray = tempNameArray;
            }
            else
            {
                Console.WriteLine("Вы выбрали номер досье, которого не существует.");
            }
        }
    }
}