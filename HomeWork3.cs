using  System;

namespace ijuniorEducationHomework
{
    public class HomeWork3
    {
        /*
        На экране, в специальной зоне, выводятся картинки, по 3 в ряд. Всего у пользователя в альбоме 52 картинки. Код должен вывести, сколько полностью заполненных рядов можно будет вывести, и сколько картинок будет сверх меры.
        В качестве решения ожидаются объявленные переменные с необходимыми значениями и, основываясь на значениях переменных, вывод необходимых данных.
        */
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