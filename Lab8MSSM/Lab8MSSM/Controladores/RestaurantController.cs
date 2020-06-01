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

    public interface IRestaurantView
    {
        void addRestaurant(string rName, string rOwnerName, string openTime, string closeTime, bool mesasExclusivas);
    }


    public class RestaurantController : IRestaurantView
    {
        public IRestaurantView _view;
        public List<Restaurant> _restaurants;

        public RestaurantController(IRestaurantView view, List<Restaurant> restaurants)
        {
            this._view = view; this._restaurants = restaurants;
        }


        public void addRestaurant(string rName, string rOwnerName, string openTime, string closeTime, bool mesasExclusivas)
        {

            string schedule = openTime + "-" + closeTime;
            int rId;

            if (_restaurants == null)
            {
                rId = 0;
            }
            else
            {
                rId = _restaurants.Count() + 1;
            }

            Restaurant r = new Restaurant(rName, rOwnerName, rId, schedule, mesasExclusivas);
            _restaurants.Add(r);

            for (int i = 0; i < _restaurants.Count(); i++)
            {
                Debug.WriteLine(_restaurants[i].ownerName);
            }




        }
     

    }
}
