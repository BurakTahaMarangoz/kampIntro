using System;

namespace SwitchStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            string tabelaVeri = "Cumartesi" ; 
            
            switch(tabelaVeri)
            {
                case "Pazartesi" :
                    Console.WriteLine("AÇIK");
                    break;

                case "Salı":
                    Console.WriteLine("AÇIK");
                    break;

                case "Çarşamba":
                    Console.WriteLine("AÇIK");
                    break;
                case "Perşembe":
                    Console.WriteLine("AÇIK");
                    break;
                case "Cuma":
                    Console.WriteLine("AÇIK");
                    break;
                case "Cumartesi":
                    Console.WriteLine("KAPALI");
                    break;
                case "Pazar":
                    Console.WriteLine("KAPALI");
                    break;
            }
        }
    }
}
