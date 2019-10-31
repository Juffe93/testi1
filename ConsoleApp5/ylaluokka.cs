using System;
using System.Collections.Generic;
using System.Text;

namespace Projekti
{
    class ylaluokka
    {
        private string _tehtavanimi;
        private string _suoritusaste;
        private DateTime _deadline;



        public ylaluokka(string tehtavanimi, string suoritusaste, DateTime deadline)
        {
            _tehtavanimi = tehtavanimi;
            _suoritusaste = suoritusaste;
            _deadline = deadline;

        }
        public string HaeTehtavanimi()
        {
            return _tehtavanimi;
        }

        public string HaeSuoritusaste()
        {
            return _suoritusaste;
        }
        public DateTime HaeDeadline()
        {
            return _deadline;
        }






    }
}
