using System;

namespace ijuniorEducationHomework
{
    public class HomeWork14
    {
        /*
        Легенда: Вы – теневой маг(можете быть вообще хоть кем) и у вас в арсенале есть несколько заклинаний, которые вы можете использовать против Босса. Вы должны уничтожить босса и только после этого будет вам покой.
        Формально: перед вами босс, у которого есть определенное кол-во жизней и определенный ответный урон. У вас есть 4 заклинания для нанесения урона боссу. Программа завершается только после смерти босса или смерти пользователя.

        Пример заклинаний
        Рашамон – призывает теневого духа для нанесения атаки (Отнимает 100 хп игроку)
        Хуганзакура (Может быть выполнен только после призыва теневого духа), наносит 100 ед. урона
        Межпространственный разлом – позволяет скрыться в разломе и восстановить 250 хп. Урон босса по вам не проходит
        Заклинания должны иметь схожий характер и быть достаточно сложными, они должны иметь какие-то условия выполнения (пример - Хуганзакура). Босс должен иметь возможность убить пользователя.
         */
        public static void Work()
        {
            Random randomGenerate = new Random();

            float healthBoss = randomGenerate.Next(2000, 2500);
            int damageBoss = randomGenerate.Next(100, 200);
            int armorBoss = randomGenerate.Next(10, 50);

            float healthMag = randomGenerate.Next(1500, 2000);
            int armorMag = randomGenerate.Next(20, 40);
            int damageSkill1 = 100;
            int damageSkill2 = 100;
            int damageSkill3 = 250;

            bool skillUsedMag1 = false;

            Console.WriteLine($"У Босса {healthBoss} жизней, {armorBoss} брони и {damageBoss} урона.");
            Console.WriteLine($"У Мага {healthMag} жизней, {armorMag} брони.");
            Console.WriteLine("Бой начинается!");
            Console.WriteLine(new string('-', 20));

            while (healthBoss > 0 && healthMag > 0)
            {
                switch (randomGenerate.Next(0, 3))
                {
                    case 1:
                        Console.WriteLine($"Маг использует Рашамон, призывая духа!");
                        Console.WriteLine($"Босс наносит удар!");
                        healthMag -= damageSkill1;
                        healthBoss -= Convert.ToSingle(randomGenerate.Next(10, damageSkill1) / 100 * armorBoss);
                        healthMag -= Convert.ToSingle(randomGenerate.Next(10, damageBoss) / 100 * armorBoss);
                        Console.WriteLine($"У Босса {healthBoss} жизней.");
                        Console.WriteLine($"У Мага {healthMag} жизней.");
                        skillUsedMag1 = true;
                        Console.WriteLine(new string('-', 20));
                        break;

                    case 2:
                        if (skillUsedMag1)
                        {
                            Console.WriteLine($"Маг использует Хуганзакура");
                            Console.WriteLine($"Босс наносит удар!");
                            healthBoss -= Convert.ToSingle(randomGenerate.Next(10, damageSkill2) / 100 * armorBoss);
                            healthMag -= Convert.ToSingle(randomGenerate.Next(10, damageBoss) / 100 * armorBoss);
                            skillUsedMag1 = false;
                        }
                        else
                        {
                            Console.WriteLine("Маг не смог использовать Хуганзакура");
                            Console.WriteLine($"Босс наносит удар!");
                            healthMag -= Convert.ToSingle(randomGenerate.Next(10, damageBoss) / 100 * armorBoss);
                        }

                        Console.WriteLine($"У Босса {healthBoss} жизней.");
                        Console.WriteLine($"У Мага {healthMag} жизней.");
                        Console.WriteLine(new string('-', 20));
                        break;

                    case 3:

                        Console.WriteLine($"Маг использует Межпространственный разлом, восстанавливает 100 жизней!");
                        Console.WriteLine($"Босс не смог нанести удар!");
                        healthMag += damageSkill3;
                        healthBoss -= Convert.ToSingle(randomGenerate.Next(10, damageSkill3) / 100 * armorBoss);

                        Console.WriteLine($"У Босса {healthBoss} жизней.");
                        Console.WriteLine($"У Мага {healthMag} жизней.");
                        Console.WriteLine(new string('-', 20));
                        break;
                }
            }

            if (healthBoss <= 0 && healthMag <= 0)
            {
                Console.WriteLine("Ничья, оба мертвы");
            }
            else if (healthBoss <= 0)
            {
                Console.WriteLine("Босс проиграл!");
            }
            else if (healthMag <= 0)
            {
                Console.WriteLine("Маг проиграл!");
            }

            Console.ReadLine();
        }
    }
}