using System;
namespace ijuniorEducationHomework
{
    public class HomeWork8
    {
        public static void Work()
        {
            string exitCycle = null;

            while (exitCycle != "exit")
            {
                Console.WriteLine("Введите exit и цикл закончится:");
                exitCycle = Console.ReadLine();
            }
            Console.WriteLine("Цикл закончился.");
            Console.ReadLine();
        }
    }
}