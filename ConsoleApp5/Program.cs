using System;

namespace Projekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä Kategoria: ");
            String Kategoria = Console.ReadLine();
            Console.Write("Tehtävä nimi:");
            String tehtavanimi = Console.ReadLine();
            Console.Write("Syötä suoritustaste: ");
            String suoritusaste = Console.ReadLine();
            Console.Write("Tehtävän deadline: ");
            DateTime deadline = DateTime.Parse(Console.ReadLine());

            if (Kategoria == ("Koulutehtava"))
            {

                Console.Write("kurssin nimi:");
                String kurssinNimi = Console.ReadLine();


                koulutehtavat UusiKoulutehtava = new koulutehtavat(tehtavanimi, suoritusaste, kurssinNimi, deadline);
                Console.WriteLine($"Tehtävä: { UusiKoulutehtava.HaeTehtavanimi()}. Suoritusaste: { UusiKoulutehtava.HaeSuoritusaste()}. Kurssi: {UusiKoulutehtava.HaeKurssinNimi()}. Deadline: {UusiKoulutehtava.HaeDeadline()}. ");
            }
            else
            {

                Console.Write("Työpiste:");
                String tyopiste = Console.ReadLine();

                tyotehtavat UusiTyotehtava = new tyotehtavat(tehtavanimi, suoritusaste, tyopiste, deadline);
                Console.WriteLine($"Tehtävä: { UusiTyotehtava.HaeTehtavanimi()}. Suoritusaste: { UusiTyotehtava.HaeSuoritusaste()}. Työpiste: { UusiTyotehtava.Haetyopiste()}.  Deadline: {UusiTyotehtava.HaeDeadline()}. ");

            }




        }
    }
}
