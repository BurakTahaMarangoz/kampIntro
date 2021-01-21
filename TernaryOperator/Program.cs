using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayi giriniz(max=99) : ");

            int number = Convert.ToInt32(Console.ReadLine());

            // Ternary Operator
            // Sonuç = koşul ? koşul oluşuyorsa bu kısım çalışsın : Değilse bu kısım çalışsın 
            string resultTernary = number >= 10 && number <= 99 ? "Two digits" : "One digit ";
            Console.WriteLine(resultTernary);
        }
    }
}
