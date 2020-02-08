using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arka5_5_1
{
    class Lima
    {
        static void fibonacci(int kolom, int baris)
        {
            int angka1 = 0;
            int angka2 = 1;
            int angka3;
            
            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.Write(angka1 + " ");
                    }
                    else if (i == 0 && j == 1)
                    {
                        Console.Write(angka2 + " ");
                    }
                    else
                    {
                        angka3 = angka1 + angka2;
                        Console.Write(angka3 + " ");
                        angka1 = angka2;
                        angka2 = angka3;
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            fibonacci(4, 3);
        }
    }
}
