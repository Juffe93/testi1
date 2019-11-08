using System;
using System.Collections.Generic;
using System.Text;

namespace Projekti
{
    class tyotehtavat : ylaluokka
    {
        private string _tyopiste;
        public tyotehtavat(string tehtavanimi, string suoritusaste, string tyopiste, DateTime deadline) : base (tehtavanimi, suoritusaste, deadline)
        {
            _tyopiste = tyopiste;
        }
        public string Haetyopiste()
        {
            return _tyopiste;
        }
    
    }
}
