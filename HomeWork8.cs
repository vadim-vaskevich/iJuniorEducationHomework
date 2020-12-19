using System;
namespace ijuniorEducationHomework
{
    public class HomeWork8
    {
        /*
        Написать программу, которая будет выполняться до тех пор, пока не будет введено слово exit.
        Помните, в цикле должно быть условие, которое отвечает за то, когда цикл должен завершиться.
        Это нужно, чтобы любой разработчик взглянув на ваш код, понял четкие границы вашего цикла.
         */
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