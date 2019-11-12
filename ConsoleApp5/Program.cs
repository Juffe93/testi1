using System;

namespace Projekti
{
    class Program
    {
        static void Main(string[] args)
        {
            
            do
            {

            
            Console.WriteLine(" - Tehtävälista - ");
            Console.WriteLine("1 - Koulutehtävä");
            Console.WriteLine("2 - Työtehtävä");
            Console.WriteLine();



            Console.Write("Syötä Kategoria numero: ");
            String Kategoria = Console.ReadLine();
            Console.WriteLine();


            if (Kategoria == ("1"))
            {
                Console.WriteLine();
                Console.WriteLine(" - Tehtävän nimi");
                Console.WriteLine(" - Kurssin nimi");
                Console.WriteLine(" - Syötä suoritustaste");
                Console.WriteLine(" - Tehtävän deadline");
                Console.WriteLine();
                Console.Write("Tehtävä nimi: ");
                String tehtavanimi = Console.ReadLine();
                Console.Write("kurssin nimi: ");
                String kurssinNimi = Console.ReadLine();
                Console.Write("Syötä suoritusaste %: ");
                String suoritusaste = Console.ReadLine();
                Console.Write("Tehtävän deadline: ");
                DateTime deadline = DateTime.Parse(Console.ReadLine());
                Console.WriteLine();





                    koulutehtavat UusiKoulutehtava = new koulutehtavat(tehtavanimi, suoritusaste, kurssinNimi, deadline);
                Console.WriteLine($"Tehtävä: { UusiKoulutehtava.HaeTehtavanimi()}. Suoritusaste: { UusiKoulutehtava.HaeSuoritusaste()}. Kurssi: {UusiKoulutehtava.HaeKurssinNimi()}. Deadline: {UusiKoulutehtava.HaeDeadline()}. ");
                if (suoritusaste == ("100"))
                {
                    Console.WriteLine("Tehävä valmis");
                        Console.WriteLine("-------------------------------------");
                    }
                else
                {
                    Console.WriteLine("Tehtävä kesken");
                        Console.WriteLine("-------------------------------------");

                    }
            }
                



            else
            {
                Console.WriteLine();
                Console.WriteLine(" - Tehtävän nimi");
                Console.WriteLine(" - Työpiste");
                Console.WriteLine(" - Syötä suoritustaste");
                Console.WriteLine(" - Tehtävän deadline");
                Console.WriteLine();
                Console.Write("Tehtävä nimi: ");
                String tehtavanimi = Console.ReadLine();
                Console.Write("Syötä Työpiste: ");
                String tyopiste = Console.ReadLine();
                Console.Write("Syötä suoritusaste %: ");
                String suoritusaste = Console.ReadLine();
                Console.Write("Tehtävän deadline: ");
                DateTime deadline = DateTime.Parse(Console.ReadLine());
                Console.WriteLine();


                tyotehtavat UusiTyotehtava = new tyotehtavat(tehtavanimi, suoritusaste, tyopiste, deadline);
                Console.WriteLine($"Tehtävä: { UusiTyotehtava.HaeTehtavanimi()}. Suoritusaste: { UusiTyotehtava.HaeSuoritusaste()}. Työpiste: { UusiTyotehtava.Haetyopiste()}.  Deadline: {UusiTyotehtava.HaeDeadline()}. ");
                 
                    if (suoritusaste == ("100"))
                {
                    Console.WriteLine("Tehävä valmis");
                        Console.WriteLine("-------------------------------------");

                    }
                else
                {
                    Console.WriteLine("Tehtävä kesken");
                        Console.WriteLine("-------------------------------------");

                    }
                    
                }
                
            } while (true);
            


        }
    }
}
