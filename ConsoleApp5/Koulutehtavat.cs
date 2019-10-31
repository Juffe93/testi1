using System;
using System.Collections.Generic;
using System.Text;

namespace Projekti
{
    class koulutehtavat : ylaluokka
    {
        private string _KurssinNimi;
        public koulutehtavat(string tehtavanimi, string suoritusaste, string KurssinNimi, double deadline) : base(tehtavanimi, suoritusaste, deadline)
        {
            _KurssinNimi = KurssinNimi;
        }
        public string HaeKurssinNimi()
        {
            return _KurssinNimi;
        }
    }

}
