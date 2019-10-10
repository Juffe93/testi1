using System;
using System.Collections.Generic;
using System.Text;

namespace Projekti
{
    class ylaluokka
    {
        private string _tehtavanimi;
        private string _tehtavanSuoritusaste;
        private int _pvm;

        public ylaluokka(string tehtavanimi, int pvm, string tehtavansuoritusaste)
        {
            _tehtavanimi = tehtavanimi;
            _pvm = pvm;
            _tehtavanSuoritusaste = tehtavansuoritusaste;
        }
        public string HaeTehtavanimi()
        {
            return _tehtavanimi;
        }

        public int HaePvm()
        {
            return _pvm;
        }
        public string HaeSuoritusaste()
        {
            return _tehtavanSuoritusaste;
        }


    }
}
