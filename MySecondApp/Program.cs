using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* float damagePerSecond, damageOfGun;
             float healthPointsOfEnemy;
             float numberOfHeatsPerSecond;*/
            float time;
            int numberOfHeats;
            string nameOfEnemy;

            /*Console.WriteLine("Кто на вас напал? ");
            nameOfEnemy = Console.ReadLine();
            Console.Write("Введите урон вашего оружия: ");
            damageOfGun = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите количество ударов в секунду: ");
            numberOfHeatsPerSecond = Convert.ToSingle (Console.ReadLine());
            Console.Write("Введите число хп противника: ");
            healthPointsOfEnemy = Convert.ToSingle (Console.ReadLine());*/



            /*for (int i = 0; i <  Math.Ceiling(time); i++)
            {
                Console.ReadKey();
                if (damagePerSecond * (i + 1)>=healthPointsOfEnemy)
                {
                    Console.WriteLine($"Вы нанесли {nameOfEnemy}у {healthPointsOfEnemy} урона, за {i + 1} секуду боя");
                    break;
                    
                }
                else
                {
                    Console.WriteLine($"Вы нанесли {nameOfEnemy}у {damagePerSecond * (i + 1)} урона, за {i + 1} секуду боя");
                }
            }
            Console.WriteLine($"Вы победили {nameOfEnemy}а за {time} секунд, нанеся ему {numberOfHeats} ударов");*/
            string tabulation = "\n\n";
            Random random = new Random();
            float numberOfHeatsPerSecond = Convert.ToSingle(random.Next(10));
            float damageOfGun = Convert.ToSingle(random.Next(45));
            float healthPointsOfEnemy = Convert.ToSingle(random.Next(10, 1000));
            float damageOfEnemPerSecond = Convert.ToSingle(random.Next(200));
            float playerHealthPoint = Convert.ToSingle(random.Next(10, 1000));
            float damagePerSecond;
            damagePerSecond = numberOfHeatsPerSecond * damageOfGun;
            time = healthPointsOfEnemy / damagePerSecond;

            Console.WriteLine($"Кто на вас напал? {tabulation}");
            nameOfEnemy = Console.ReadLine();
            numberOfHeats = Convert.ToInt32(Math.Ceiling(time * numberOfHeatsPerSecond));
            Console.WriteLine($"{tabulation}Ваш урон в секунду: {damagePerSecond} {tabulation}");
            Console.WriteLine($"Урон в секунду вашего врага: {damageOfEnemPerSecond} {tabulation}");
            Console.WriteLine($"Здоровье противника: {healthPointsOfEnemy} {tabulation}");
            Console.WriteLine($"Ваш ХП {playerHealthPoint} {tabulation}");
            if (healthPointsOfEnemy / (damagePerSecond) > playerHealthPoint / (damageOfEnemPerSecond))

                Console.WriteLine("Вы проиграли бой");

            else
            {
                Console.WriteLine($"Нажимайте любую клавишу, чтобы провести серию атак {tabulation}");
                for (int i = 0; i < Math.Ceiling(time); i++)
                {
                    Console.ReadKey();
                    if (damagePerSecond * (i + 1) >= healthPointsOfEnemy)
                    {
                        Console.WriteLine($"Вы нанесли {nameOfEnemy}у {healthPointsOfEnemy} урона, за {i + 1} секуду боя {tabulation}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Вы нанесли {nameOfEnemy}у {damagePerSecond * (i + 1)} урона, за {i + 1} секуду боя {tabulation}");
                    }
                }
                Console.WriteLine($"Вы победили {nameOfEnemy}а за {time} секунд, нанеся ему {numberOfHeats} ударов");
            }
        }
    }
}
