using System;

namespace Projekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä Kategoria: ");
            String Kategoria = Console.ReadLine();

            if (Kategoria == ("Koulutehtava"))
            {
                Console.Write("Tehtävä nimi:");
                String tehtavanimi = Console.ReadLine();
                Console.Write("kurssin nimi:");
                String kurssinNimi = Console.ReadLine();
                Console.Write("Syötä suoritustaste: ");
                String suoritusaste = Console.ReadLine();
                Console.Write("Tehtävän aikaraja: ");
                double deadline = double.Parse(Console.ReadLine());


                koulutehtavat UusiKoulutehtava = new koulutehtavat(tehtavanimi, suoritusaste, kurssinNimi, deadline);
            }
            else
            {
                Console.Write("Tehtävä nimi:");
                String tehtavanimi = Console.ReadLine();
                Console.Write("Syötä suoritustaste: ");
                String suoritusaste = Console.ReadLine();
                Console.Write("Tehtävän aikaraja: ");
                double deadline = double.Parse(Console.ReadLine());

                tyotehtavat UusiTyotehtava = new tyotehtavat(tehtavanimi, suoritusaste, deadline);


            }




        }
    }
}
