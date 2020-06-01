using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8MSSM
{
    public class Tienda : Local
    {
        public string categorias; 

        public Tienda(string localName, string ownerName, int localeID, string schedule, string categorias) : base(localName, ownerName, localeID, schedule)
        {
            this.categorias = categorias;
        }


    }
}
