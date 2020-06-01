using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8MSSM
{
    public class Cine: Local
    {
        public int numSalas;

        public Cine(string localName, string ownerName, int localeID, string schedule, int numSalas) : base(localName, ownerName, localeID, schedule)
        {
            this.numSalas = numSalas;
        }



    }
}
