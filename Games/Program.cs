using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] pole = new char[3, 3] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
            Random rnd = new Random();
            bool beskonechno = true;





            




            while (beskonechno) // цикл
            {

                // вывод поля 3 на 3 --- потом изменится
                //                   ---
                //                   ---
                for (int stroka = 0; stroka < pole.GetLength(0); stroka++)
                {
                    for (int simvol = 0; simvol < pole.GetLength(1); simvol++)
                    {
                        Console.Write(pole[stroka, simvol]);
                    }
                    Console.WriteLine();

                }



                // Крестик
                // выводит крестик где укажет пользователь
                Console.CursorTop = 3;
                Console.WriteLine("Введите координаты крестика");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                if (pole[x, y] == '-')
                {
                    if (pole[x, y] == '-')
                    {
                        if (pole[x, y] == '-')
                        {
                            pole[x, y] = 'x';
                        }
                        else if (pole[x, y] != '-')
                        {
                            beskonechno = false;
                        }
                    }
                }
                else if (x > 2)
                {
                    beskonechno = false;
                }




                // вывод Нолика рандомно

                
                    int xc = rnd.Next(0, 3);
                    int yc = rnd.Next(0, 3);
                    if (pole[xc, yc] == '-')
                    {
                        if (pole[xc, yc] == '-')
                        {
                            if (pole[xc, yc] == '-')
                            {
                                pole[xc, yc] = '0';
                            }
                        }
                    }
                    // вывод поля когда вывелся x и 0
                    for (int stroka = 0; stroka < pole.GetLength(0); stroka++)
                    {
                        for (int simvol = 0; simvol < pole.GetLength(1); simvol++)
                        {
                            Console.Write(pole[stroka, simvol]);
                        }
                        Console.WriteLine();
                    }
                    Console.Clear();

                }
                Console.ReadKey();
            }

        }
    }

    
