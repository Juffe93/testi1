using System;
using System.Collections.Generic;
using System.Text;

namespace Projekti
{
    class ylaluokka
    {
        private string _tehtavanimi;
        private string _tehtavanSuoritusaste;
        


        public ylaluokka( string tehtavanimi, string tehtavansuoritusaste)
        {
            _tehtavanimi = tehtavanimi;
            _tehtavanSuoritusaste = tehtavansuoritusaste;
           
        }
        public string HaeTehtavanimi()
        {
            return _tehtavanimi;
        }

        public string HaeSuoritusaste()
        {
            return _tehtavanSuoritusaste;
        }

        




    }
}
