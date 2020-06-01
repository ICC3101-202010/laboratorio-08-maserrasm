using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab8MSSM
{
    public class Restaurant : Local
    {
        public bool mesasExclusivas;
        public Restaurant(string localName, string ownerName, int localeID, string schedule, bool mesasExclusivas) : base(localName, ownerName, localeID, schedule)
        {
            this.mesasExclusivas = mesasExclusivas;
        }
    }
}
