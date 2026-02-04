using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proverka_na__parola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи парола: ");
            string password = Console.ReadLine();

            bool hasMinLength = password.Length >= 6;
            bool hasDigit = false;
            bool hasUpper = false;

            foreach (char c in password)
            {
                if (char.IsDigit(c)) hasDigit = true;
                if (char.IsUpper(c)) hasUpper = true;
            }

            if (hasMinLength && hasDigit && hasUpper)
            {
                Console.WriteLine("Паролата е сигурна ✅");
            }
            else
            {
                Console.WriteLine("Паролата НЕ е сигурна ❌");

                if (!hasMinLength) Console.WriteLine("- Трябва да е минимум 6 символа");
                if (!hasDigit) Console.WriteLine("- Трябва да има поне 1 цифра");
                if (!hasUpper) Console.WriteLine("- Трябва да има поне 1 главна буква");
            }
        }
    }
}
