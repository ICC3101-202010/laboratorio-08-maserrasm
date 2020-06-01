using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8MSSM.Controladores
{

    public interface ICineView
    {
        void addCine(string rName, string rOwnerName, string openTime, string closeTime, int numSalas);
    }


    public class CineController : ICineView
    {
        public ICineView _view;
        public List<Cine> _cinemas;

        public CineController(ICineView view, List<Cine> cinemas)
        {
            this._view = view; this._cinemas = cinemas;
        }

        public void addCine(string cName, string rOwnerName, string openTime, string closeTime, int numSalas)
        {
            string schedule = openTime + "-" + closeTime;
            int rId;

            if (_cinemas == null)
            {
                rId = 0;
            }
            else
            {
                rId = _cinemas.Count() + 1;
            }

            Cine c = new Cine(cName, rOwnerName, rId, schedule, numSalas);
            _cinemas.Add(c);
        }
    }
}
