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
          
           
            bool beskonehno = true;
            Random random = new Random();
            int xc = random.Next(1, 4);

            int yc = random.Next(1, 4);
            char krest = 'х';
            char nuli = '0';
            char minus = '-';
            
            int[,] strokasimwol = new int[3, 3];
            // вывод поля 3 на 3 ---
            //                   ---
            //                   ---
            for (int stroka = 0; stroka < strokasimwol.GetLength(0); stroka++)
            {
                for (int simvol = 0; simvol < strokasimwol.GetLength(1); simvol++)
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
                beskonehno = true;
                // Нолик
                while (beskonehno)
                {
                    xc = random.Next(1, 4);
                    yc = random.Next(1, 4);
                    if (strokasimwol[xc,yc] == minus)
                    { 
                        Console.CursorTop = xc - 1;
                        Console.CursorLeft = yc - 1;
                        Console.WriteLine(nuli);
                        beskonehno = false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            
            
        }
    }
}