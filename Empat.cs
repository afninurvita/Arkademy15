using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arka5_4_1
{
    class Empat
    {
        static void replaceHuruf(string kata, char ch1, char ch2)
        {
            char[] chKata = kata.ToCharArray();
            for (int i = 0; i < chKata.Length; i++)
            {
                if (chKata[i] == ch1)
                {
                    chKata[i] = ch2;
                }
            }
            Console.WriteLine(chKata);
        }

        static void Main(string[] args)
        {
            Console.Write("Input kalimat: ");
            string kata = Convert.ToString(Console.ReadLine());
            Console.Write("Huruf yang mau diganti: ");
            char ch1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Ganti huruf tersebut dengan huruf: ");
            char ch2 = Convert.ToChar(Console.ReadLine());

            replaceHuruf(kata, ch1, ch2);
        }
    }
}
