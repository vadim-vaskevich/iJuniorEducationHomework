using System;
namespace ijuniorEducationHomework
{
    public class HomeWork6
    {
        /*
        Вы задаете вопросы пользователю, по типу "как вас зовут", "какой ваш знак зодиака" и тд, после чего, по данным, которые он ввел, формируете небольшой текст о пользователе.
        "Вас зовут Алексей, вам 21 год, вы водолей и работаете на заводе."
        */
        public static void Work()
        {
            string nameUser;
            string ageUser;
            string zodiacUser;
            string placeWorkUser;

            Console.WriteLine("Как вас зовут?");
            nameUser = Console.ReadLine();

            Console.WriteLine("Сколько вам лет?");
            ageUser = Console.ReadLine();

            Console.WriteLine("Какой ваш знак зодиака?");
            zodiacUser = Console.ReadLine();

            Console.WriteLine("Где Вы работаете?");
            placeWorkUser = Console.ReadLine();

            Console.WriteLine($"Вас зовут {nameUser}, вам {ageUser} год, Вы {zodiacUser} и работаете на {placeWorkUser}.");
        }
    }
}