using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int xc = random.Next(1, 3);

            int yc = random.Next(1, 3);
            char krest = 'х';
            char nuli = '0';
            char minus = '-';
            int[,] strokasimwol = new int[3, 3];
            // вывод поля 3 на 3 ---
            //                   ---
            //                   ---
            for (int i = 0; i < strokasimwol.GetLength(0); i++)
            {
                for (int j = 0; j < strokasimwol.GetLength(1); j++)
                {
                    Console.Write(minus);
                }
                Console.WriteLine();
            }

            while (true) // бесконечный цикл
            {
                // Крестик
                // выводит крестик где укажет пользователь
                Console.CursorTop = 3;
                Console.WriteLine("Введите координаты крестика");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                Console.CursorTop = y - 1;
                Console.CursorLeft = x - 1;
                Console.WriteLine(krest);
                // Нолик
            }
        }
    }
}