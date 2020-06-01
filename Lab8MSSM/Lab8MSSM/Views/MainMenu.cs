using Lab8MSSM.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8MSSM
{
    public partial class MainForm : Form, IRestaurantView, ICineView, ITiendaView
    {

        RestaurantController RController;
        CineController CController;
        TiendaController TController; 

        public MainForm()
        {
            InitializeComponent();
        }

        public void SetController(RestaurantController _Rcontroller, CineController _CController, TiendaController _TController)
        {
            this.RController = _Rcontroller; this.CController = _CController;
            this.TController = _TController; 

        }




        //MENU PRINCIPAL.

        //Escape principal. 
        private void mainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Crear local. 
        private void addLocal_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            addLocalPanel.Visible = true;

        }

        //Ver info. locales.
        private void seeInfoButton_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            seeLocalsInfoPanel.Visible = true;





        }




        //PANEL PARA CREAR LOCAL. 
        private void acceptInput_Click(object sender, EventArgs e)
        {

            string locType = localTypeTB.Text.ToUpper();

            if (locType == "RESTAURANT")
            {
                //MessageBox.Show("Creado restaurant.");
                addLocalPanel.Visible = false;

                //MOSTRAR PANEL CREAR RESTAURANT.

                createRestaurantPanel.Visible = true;
                addLocalPanel.Visible = false;


                // mainPanel.Visible = true;
                return;
            }
            if (locType == "CINE")
            {
                //MessageBox.Show("Creado cine.");
                addLocalPanel.Visible = false;

                //MOSTRAR PANEL CREAR CINE.

                CreateCinePanel.Visible = true;



                return;
            }
            if (locType == "TIENDA")
            {
                //MessageBox.Show("Creada tienda.");
                addLocalPanel.Visible = false;

                //MOSTRAR PANEL CREAR TIENDA.

                CreateStorePanel.Visible = true;

                

                return;
            }

            else
            {
                MessageBox.Show("Tipo de local invalido.");
            }
        }

        private void cancelInput_Click(object sender, EventArgs e)
        {
            addLocalPanel.Visible = false;
            mainPanel.Visible = true;
        }



        //OMITIR ESTO.
        private void localTypeTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
        }






        //PANEL PARA CREAR RESTAURANT.
        private void acceptCreateRButton_Click(object sender, EventArgs e)
        {
            string rName = EnterRNameTextBox.Text;
            string rOwnerName = EnterROwnerTextBox.Text;
            string openTime = EnterROpenTextBox.Text;
            string closeTime = EnterRCloseTextBox.Text;
            bool mesasExclusivas = exclusiveTablesCheckBox.Checked;

            RController.addRestaurant(rName, rOwnerName, openTime, closeTime, mesasExclusivas);
            createRestaurantPanel.Visible = false;
            addLocalPanel.Visible = true;


        }

        private void cancelCreateRbutton_Click(object sender, EventArgs e)
        {
            createRestaurantPanel.Visible = false;
            addLocalPanel.Visible = true;
        }




        //PANEL PARA CREAR CINE. 



        private void AcceptCreateCineButton_Click(object sender, EventArgs e)
        {
            string cineOwnerName = CineOwnerNameTextBox.Text;
            string cineName = CineNameTextBox.Text;
            string horarioApertura = CineOpenTimeTextBox.Text;
            string horarioCierre = CineCloseTimeTextBox.Text;
            int numSalas = Convert.ToInt32(CineNumSalasTextBox.Text);


            CController.addCine(cineName, cineOwnerName, horarioApertura, horarioCierre, numSalas);

            CreateCinePanel.Visible = false;
            addLocalPanel.Visible = true;
            return;
        }

        private void CancelCreateCineButton_Click(object sender, EventArgs e)
        {
            CreateCinePanel.Visible = false;
            addLocalPanel.Visible = true;
        }



        //PANEL PARA CREAR TIENDA:

        private void AcceptCreateStore_Click(object sender, EventArgs e)
        {
            string storeOwnerName = StoreOwnerNameTextBox.Text;
            string storeName = StoreNameTextBox.Text;
            string horarioApertura = StoreOpenTimeTextBox.Text;
            string horarioCierre = StoreCloseTimeTextBox.Text;
            string categorias = StoreCategoryTextBox.Text;


            TController.addTienda(storeName, storeOwnerName, horarioApertura, horarioCierre, categorias);
            CreateStorePanel.Visible = false;
            addLocalPanel.Visible = true;
        }

        private void CancelCreateStore_Click(object sender, EventArgs e)
        {
            CreateStorePanel.Visible = false;
            addLocalPanel.Visible = true;

        }






        //ESTO PARA VER INFORMACION. 
        private void exitLocaleInfoMainButton_Click(object sender, EventArgs e)
        {
            seeLocalsInfoPanel.Visible = false;
            mainPanel.Visible = true;
        }


        //PARA RESTAURANTS:
        private void SeeRestaurantsButton_Click(object sender, EventArgs e)
        {

            RestaurantsListView.Items.Clear(); RestaurantsListView.Clear();


            RestaurantsListView.View = View.Details;
            RestaurantsListView.Columns.Add("ID Local");
            RestaurantsListView.Columns.Add("Nombre Local.");
            RestaurantsListView.Columns.Add("Nombre Dueño");
            RestaurantsListView.Columns.Add("Horario");
            RestaurantsListView.Columns.Add("Mesas Exclusivas");


            for (int i = 0; i < RController._restaurants.Count(); i++)
            {
                string locID = Convert.ToString(RController._restaurants[i].localeID);
                string locName = RController._restaurants[i].localName;
                string locOwnerName = RController._restaurants[i].ownerName;
                string locSchedule = RController._restaurants[i].schedule;
                string locExclusive = Convert.ToString(RController._restaurants[i].mesasExclusivas);

                var item1 = new ListViewItem(new[] { locID, locName, locOwnerName, locSchedule, locExclusive });
                RestaurantsListView.Items.Add(item1);
            }

            seeLocalsInfoPanel.Visible = false;
            RestaurantsViewPanel.Visible = true;

        }

        private void CloseRestaurantViewPanel_Click(object sender, EventArgs e)
        {
            RestaurantsViewPanel.Visible = false;
            seeLocalsInfoPanel.Visible = true;
        }







        //PARA CINES. 

        private void SeeCinemasButton_Click(object sender, EventArgs e)
        {

            ViewCinesListView.Items.Clear(); ViewCinesListView.Clear();



            ViewCinesListView.View = View.Details;

            ViewCinesListView.Columns.Add("ID Local");
            ViewCinesListView.Columns.Add("Nombre Local.");
            ViewCinesListView.Columns.Add("Nombre Dueño");
            ViewCinesListView.Columns.Add("Horario");
            ViewCinesListView.Columns.Add("Num. Salas");

            for (int i = 0; i < CController._cinemas.Count(); i++)
            {
                string cineID = Convert.ToString(CController._cinemas[i].localeID);
                string cineOwnerName = CController._cinemas[i].ownerName;
                string cineName = CController._cinemas[i].localName;
                string horario = CController._cinemas[i].schedule;
                string numSalas = Convert.ToString(CController._cinemas[i].numSalas);

                var item1 = new ListViewItem(new[] { cineID, cineName, cineOwnerName, horario, numSalas });
                ViewCinesListView.Items.Add(item1);
            }

            ViewCinesPanel.Visible = true;
            seeLocalsInfoPanel.Visible = false;

        }


        private void ExitViewCinesButton_Click(object sender, EventArgs e)
        {
            ViewCinesPanel.Visible = false;
            seeLocalsInfoPanel.Visible = true;
        }


        // PARA TIENDAS: 

        private void VerTiendasButton_Click(object sender, EventArgs e)
        {
            StoreListView.Items.Clear(); StoreListView.Clear();



            StoreListView.View = View.Details;
            StoreListView.Columns.Add("ID Local");
            StoreListView.Columns.Add("Nombre Local.");
            StoreListView.Columns.Add("Nombre Dueño");
            StoreListView.Columns.Add("Horario");
            StoreListView.Columns.Add("Categorias");


            for (int i = 0; i < TController._tiendas.Count(); i++)
            {
                string tiendaID = Convert.ToString(TController._tiendas[i].localeID);
                string tiendaOwnerName = TController._tiendas[i].ownerName;
                string tiendaName = TController._tiendas[i].localName;
                string horario = TController._tiendas[i].schedule;
                string catsTienda = TController._tiendas[i].categorias;

                var item1 = new ListViewItem(new[] { tiendaID, tiendaName, tiendaOwnerName, horario, catsTienda });
                StoreListView.Items.Add(item1);
            }

            seeLocalsInfoPanel.Visible = false;
            VerTiendasPanel.Visible = true;
        }





        private void exitVerTiendasButton_Click(object sender, EventArgs e)
        {
            VerTiendasPanel.Visible = false;
            seeLocalsInfoPanel.Visible = true;
        }








        private void EnterRCloseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createRestaurantPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EnterRNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void addRestaurant(string rName, string rOwnerName, string openTime, string closeTime, bool mesasExclusivas)
        {
            ((IRestaurantView)RController).addRestaurant(rName, rOwnerName, openTime, closeTime, mesasExclusivas);
        }

        private void exclusiveTablesCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }




        private void seeLocalsInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RestaurantsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RestaurantsViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateCinePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void addCine(string rName, string rOwnerName, string openTime, string closeTime, int numSalas)
        {
            throw new NotImplementedException();
        }

        private void enterLocalType_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void addTienda(string rName, string rOwnerName, string openTime, string closeTime, string categorias)
        {
            ((ITiendaView)TController).addTienda(rName, rOwnerName, openTime, closeTime, categorias);
        }

        private void StoreListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
