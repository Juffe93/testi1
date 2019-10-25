using System;

namespace Projekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä Kategoria: ");
            String Kategoria = Console.ReadLine();

            if ( Kategoria == ("Koulutehtava") ) 
            {
                Console.Write("Tehtävä nimi:");
                String tehtavanimi = Console.ReadLine();
                Console.Write("kurssin nimi:");
                String kategoria = Console.ReadLine();
                Console.Write("Syötä suoritustaste: ");
                String suoritusaste = Console.ReadLine();
                Console.Write("Tehtävän aikaraja: ");
                DateTime deadline = DateTime.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Tehtävä nimi:");
                String tehtavanimi = Console.ReadLine();
                Console.Write("kurssin nimi:");
                String kategoria = Console.ReadLine();
                Console.Write("Syötä suoritustaste: ");
                String suoritusaste = Console.ReadLine();
                Console.Write("Tehtävän aikaraja: ");
                DateTime deadline = DateTime.Parse(Console.ReadLine());
            }
            
            
            

        }
    }
}
