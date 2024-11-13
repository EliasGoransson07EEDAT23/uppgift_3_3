using System;
namespace uppgift_3_3
{
    class Program
    {
        static void Main(string[] args)
            
        {
           
            Console.WriteLine("Hej, för att få reda på priset för hyrbilen, skriv in antal timmar nedan. (hela timmar, avrunda uppåt)");
            int tim = int.Parse(Console.ReadLine());
            int pris = tim * 80;
            if (pris < 950)
            {
                Console.WriteLine("Hyrbilen kommer kosta " + pris + "kr.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Hyrbilen kommer kosta 950kr.");
                Console.ReadKey();
            }
            

        }
    }
}