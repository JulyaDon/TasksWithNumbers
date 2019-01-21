using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksWithNumbers.Tasks
{
    public static class RomanArabicNumbers
    {
        public static void Replace()
        {
            Dictionary<int, string> roman = new Dictionary<int, string> {
                {1, "I"},
                {2, "II"},
                {3, "III"},
                {4, "IV"},
                {5, "V"},
                {6, "VI"},
                {7, "VII"},
                {8, "VIII"},
                {9, "IX"},
                {10, "X"},
                {40, "XL"},
                {50, "L"},
                {90, "XC"},
                {100, "C"},
                {400, "CD"},
                {500, "D"},
                {900, "CM"},
                {1000, "M"},
            };

            List<string> result = new List<string>();
            int n = 98;
            string romanNumber = "";

            for (int i = 1; n > 0; i *= 10)
            {
                int p = n % 10;
                n = n / 10;
                p *= i;
                if (p > 10 && p < 40)
                {
                    romanNumber = String.Concat(roman[10], romanNumber);

                }
                else
                {
                    result.Insert(0, roman[p]);
                }
            }

            foreach (string oneresult in result)
            {
                Console.Write(oneresult);
            }
        }
    }
}
