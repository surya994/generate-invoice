using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasInvoice
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input : ");
            int input = Convert.ToInt32(Console.ReadLine());
            DateTime date = DateTime.Now.AddDays(3);

            string monthYear = date.ToString("yyyyMM");
            string dayName = date.ToString("dddd").Substring(0,2).ToUpper();
            string day = Romawi(Convert.ToInt32(date.ToString("dd")));
            string year = Romawi(Convert.ToInt32(date.ToString("yy")));
            int counter = input+1;

            Console.Write("Hasil : ");
            Console.WriteLine($"INV/{monthYear}/{dayName}/{day}/{year}/{counter}");
        }
        static string Romawi(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + Romawi(number - 1000);
            if (number >= 900) return "CM" + Romawi(number - 900);
            if (number >= 500) return "D" + Romawi(number - 500);
            if (number >= 400) return "CD" + Romawi(number - 400);
            if (number >= 100) return "C" + Romawi(number - 100);
            if (number >= 90) return "XC" + Romawi(number - 90);
            if (number >= 50) return "L" + Romawi(number - 50);
            if (number >= 40) return "XL" + Romawi(number - 40);
            if (number >= 10) return "X" + Romawi(number - 10);
            if (number >= 9) return "IX" + Romawi(number - 9);
            if (number >= 5) return "V" + Romawi(number - 5);
            if (number >= 4) return "IV" + Romawi(number - 4);
            if (number >= 1) return "I" + Romawi(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }
    }
}

