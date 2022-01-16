using System;

namespace ExtensionsWithParams
{
    class Program
    {
        static void Main(string[] args)
        {
            string deneme = "merhaba";
            deneme.IsValidPassword(char.IsDigit(deneme, 0), char.IsUpper(deneme,0));

        }
    }
    public static class MyExtensions
    {
        public static void IsValidPassword(this string str, params bool[] logics)
        {
            foreach (var logic in logics)
            {
                if ((bool)logic == false)
                {
                    Console.WriteLine("Şifre gerekli şartları sağlamıyor");
                }
            }

        }
    }
}

