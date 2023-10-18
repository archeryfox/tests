using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLEG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            int[,] a = new int[10, 10];
            int[] b;
            ConsoleKeyInfo key;
            int k;
            bool p = false;

            do
            {
                Console.Clear();
                Console.Write("Введите количество строк: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Введите количество столбцов: ");
                m = int.Parse(Console.ReadLine());
                Random g = new Random();
                a = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        a[i, j] = g.Next(0, 101);
                    }
                }

                Console.WriteLine("\nИсходная матрица");
                for (int i = 0; i < n; i++, Console.WriteLine())
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(a[i, j]);
                    }
                }

                b = new int[m];
                for (int j = 0; j < m; j++)
                {
                    for (int i = k = 0; i < n; i++)
                    {
                        p = true;
                        for (int d = 1; d < a[i, j]; d++)
                        {
                            if (a[i, j] % d == 0)
                            {
                                p = false;
                            }
                        }

                        if (p)
                        {
                            k++;
                        }   

                        b[j] = k;
                    }
                }

                Console.WriteLine("\nКоличтво простых чисел");
                for (int i = 0; i < b.Length; i++)
                {
                    Console.Write("{0,8:d}",b[i]);
                }

                Console.WriteLine("\nДля выхода нажмите ESC");
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Escape);
        }
    }
}
