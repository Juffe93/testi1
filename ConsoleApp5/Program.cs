using System;

namespace Projekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä nimi:" );
            String tehtavanimi = Console.ReadLine();
            Console.WriteLine("Syötä suoritustaste: ");
            String suoritusaste = Console.ReadLine();
            Console.WriteLine("Tehtävän aikaraja: ");
            DateTime deadline = DateTime.Parse(Console.ReadLine());

        }
    }
}
