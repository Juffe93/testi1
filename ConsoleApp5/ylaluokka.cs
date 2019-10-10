using System;
using System.Collections.Generic;
using System.Text;

namespace Projekti
{
    class ylaluokka
    {
        private string _tehtavanimi;
        private int _pvm;

        public ylaluokka(string tehtavanimi, int pvm)
        {
            _tehtavanimi = tehtavanimi;
            _pvm = pvm;
        }
        public string HaeTehtavanimi()
        {
            return _tehtavanimi;
        }



    }
}
