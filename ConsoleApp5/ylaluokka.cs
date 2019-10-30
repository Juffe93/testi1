using System;
using System.Collections.Generic;
using System.Text;

namespace Projekti
{
    class ylaluokka
    {
        private string _tehtavanimi;
        private string _tehtavanSuoritusaste;
        private double _deadline;



        public ylaluokka(string tehtavanimi, string tehtavansuoritusaste, double deadline)
        {
            _tehtavanimi = tehtavanimi;
            _tehtavanSuoritusaste = tehtavansuoritusaste;
            _deadline = deadline;

        }
        public string HaeTehtavanimi()
        {
            return _tehtavanimi;
        }

        public string HaeSuoritusaste()
        {
            return _tehtavanSuoritusaste;
        }
        public double HaeDeadline()
        {
            return _deadline;
        }






    }
}
