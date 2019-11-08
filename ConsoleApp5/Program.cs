using System;

namespace Projekti
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(" - Tehtävälista - ");
            //Console.WriteLine("1 - Koulutehtävä");
            //Console.WriteLine("2 - Työtehtävä");
            //Console.WriteLine("syötä tehtävänumero: ");
            //int tehtävänumero = int.parse(console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(" - Syötä Kategoria");
            Console.WriteLine(" - Tehtävä nimi");
            Console.WriteLine(" - Syötä suoritustaste");
            Console.WriteLine(" - Tehtävän deadline");
            Console.WriteLine();


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
                Console.WriteLine();


                koulutehtavat UusiKoulutehtava = new koulutehtavat(tehtavanimi, suoritusaste, kurssinNimi, deadline);
                Console.WriteLine($"Tehtävä: { UusiKoulutehtava.HaeTehtavanimi()}. Suoritusaste: { UusiKoulutehtava.HaeSuoritusaste()}. Kurssi: {UusiKoulutehtava.HaeKurssinNimi()}. Deadline: {UusiKoulutehtava.HaeDeadline()}. ");
            }


            else
            {

                Console.Write("Työpiste:");
                String tyopiste = Console.ReadLine();
                Console.WriteLine();


                tyotehtavat UusiTyotehtava = new tyotehtavat(tehtavanimi, suoritusaste, tyopiste, deadline);
                Console.WriteLine($"Tehtävä: { UusiTyotehtava.HaeTehtavanimi()}. Suoritusaste: { UusiTyotehtava.HaeSuoritusaste()}. Työpiste: { UusiTyotehtava.Haetyopiste()}.  Deadline: {UusiTyotehtava.HaeDeadline()}. ");

            }

        

        }
    }
}
