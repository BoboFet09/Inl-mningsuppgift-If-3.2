using System;
namespace inlämning3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du tagit studenten? J=ja , N=nej");
            string svar = Console.ReadLine().ToLower();
            if (svar == "j")
            {
                Console.WriteLine("bra! Hur gammal är du?");
                int ålder = int.Parse(Console.ReadLine());
                if (ålder <= 22)
                {
                    Console.WriteLine("Vi vill gärna anställa dig");
                }
                else
                {
                    Console.WriteLine("Tyvär vill vi inte anställa dig");
                }
            }
            else
            {
                Console.WriteLine("Du måste ha tagit studenten för att kunna anställas");
            }

        }

    }

}