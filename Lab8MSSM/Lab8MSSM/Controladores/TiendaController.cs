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

    public interface ITiendaView
    {
        void addTienda(string rName, string rOwnerName, string openTime, string closeTime, string categorias);
    }


    public class TiendaController : ITiendaView
    {
        public ICineView _view;
        public List<Tienda> _tiendas;

        public TiendaController(ICineView view, List<Tienda> tiendas)
        {
            this._view = view; this._tiendas = tiendas;
        }

        public void addTienda(string cName, string rOwnerName, string openTime, string closeTime, string categorias)
        {
            string schedule = openTime + "-" + closeTime;
            int rId;

            if (_tiendas == null)
            {
                rId = 0;
            }
            else
            {
                rId = _tiendas.Count() + 1;
            }

            Tienda t = new Tienda(cName, rOwnerName, rId, schedule, categorias);
            _tiendas.Add(t);
        }
    }
}
