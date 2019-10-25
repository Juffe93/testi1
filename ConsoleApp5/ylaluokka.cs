using System;
using System.Collections.Generic;
using System.Text;

namespace Projekti
{
    class ylaluokka
    {
        private string _tehtavanimi;
        private string _tehtavanSuoritusaste;
        private int _Deadline;


        public ylaluokka( string tehtavanimi, string tehtavansuoritusaste, int Deadline)
        {
            _tehtavanimi = tehtavanimi;
            _tehtavanSuoritusaste = tehtavansuoritusaste;
            _Deadline = Deadline;
        }
        public string HaeTehtavanimi()
        {
            return _tehtavanimi;
        }

        public string HaeSuoritusaste()
        {
            return _tehtavanSuoritusaste;
        }

        public int HaeDeadline()
        {
            return _Deadline;
        }




    }
}
