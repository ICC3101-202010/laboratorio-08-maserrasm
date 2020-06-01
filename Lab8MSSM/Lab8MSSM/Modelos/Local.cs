using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8MSSM
{
    public abstract class Local
    {
        public string localName; 
        public string ownerName;
        public int localeID;
        public string schedule; 

        public Local(string localName, string ownerName, int localeID, string schedule)
        {
            this.ownerName = ownerName; this.localeID = localeID; this.schedule = schedule;
            this.localName = localName; 

        }


    }
}
