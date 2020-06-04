using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdsdsdssd
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] pole = new char[3, 3] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
            bool d = true;
            while (d)
            {
                for (int i = 0; i < pole.GetLength(0); i++)
                {
                    for (int j = 0; j < pole.GetLength(1); j++)
                    {
                        Console.Write(pole[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Введите координату х");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координату y");
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
                            d = false;
                        }
                    }
                }
                else if (x > 1)
                {
                    d = false;
                }

                Random rnd = new Random();
                int O = rnd.Next(0, 2);
                int O2 = rnd.Next(0, 2);
                if (pole[O, O2] == '-')
                {
                    if (pole[O, O2] == '-')
                    {
                        if (pole[O, O2] == '-')
                        {
                            pole[O, O2] = '0';
                        }
                    }
                }

                for (int i = 0; i < pole.GetLength(0); i++)
                {
                    for (int j = 0; j < pole.GetLength(1); j++)
                    {
                        Console.Write(pole[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.Clear();

            }
            Console.ReadKey();

        }
    }
}
