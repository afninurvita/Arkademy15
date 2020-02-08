using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arka5_3
{
    class Tiga
    {
        static bool isVowel(char ch)
        {
            ch = char.ToUpper(ch);
            return (ch == 'A' || ch == 'I' || ch == 'U' || ch == 'E' || ch == 'O');
        }

        static int CountVowels(string word)
        {
            int counting = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (isVowel(word[i]))
                {
                    counting++;
                }
            }
            return counting;
        }

        static void Main(string[] args)
        {
            Console.Write("Input kata-kata: ");
            string word = Convert.ToString(Console.ReadLine());
            Console.Write("Jumlah huruf vokal: ");
            Console.WriteLine(CountVowels(word));
        }
    }
}
