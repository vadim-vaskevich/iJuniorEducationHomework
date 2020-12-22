using System;

namespace ijuniorEducationHomework
{
    public class HomeWork3
    {
        public static void Work()
        {
            int imagesInRow = 3;
            int totalCountImages = 52;

            int fullRows = totalCountImages / imagesInRow;
            int restImages = totalCountImages % imagesInRow;

            Console.WriteLine(fullRows);
            Console.WriteLine(restImages);
        }
    }
}