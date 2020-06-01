using Lab8MSSM.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lab8MSSM
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<Restaurant> allRestaurants = new List<Restaurant>();
            List<Cine> allCinemas = new List<Cine>();
            List<Tienda> allStores = new List<Tienda>();

            MainForm main = new MainForm();

            //Controlador Restaurants. 
            RestaurantController rc = new RestaurantController(main, allRestaurants);
            CineController cc = new CineController(main, allCinemas);
            TiendaController tt = new TiendaController(main, allStores);
            main.SetController(rc, cc, tt);


            


            Application.Run(main);



        }
    }
}
