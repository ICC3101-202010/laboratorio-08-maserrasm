namespace Lab8MSSM
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainExit = new System.Windows.Forms.Button();
            this.addLocal = new System.Windows.Forms.Button();
            this.seeInfoButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.addLocalPanel = new System.Windows.Forms.Panel();
            this.localTypeTB = new System.Windows.Forms.TextBox();
            this.cancelInput = new System.Windows.Forms.Button();
            this.acceptInput = new System.Windows.Forms.Button();
            this.enterLocalType = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.createRestaurantPanel = new System.Windows.Forms.Panel();
            this.exclusiveTablesCheckBox = new System.Windows.Forms.CheckBox();
            this.EnterRCloseTextBox = new System.Windows.Forms.TextBox();
            this.EnterROpenTextBox = new System.Windows.Forms.TextBox();
            this.EnterROwnerTextBox = new System.Windows.Forms.TextBox();
            this.EnterRNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelCreateRbutton = new System.Windows.Forms.Button();
            this.acceptCreateRButton = new System.Windows.Forms.Button();
            this.seeLocalsInfoPanel = new System.Windows.Forms.Panel();
            this.exitLocaleInfoMainButton = new System.Windows.Forms.Button();
            this.SeeRestaurantsButton = new System.Windows.Forms.Button();
            this.RestaurantsViewPanel = new System.Windows.Forms.Panel();
            this.CloseRestaurantViewPanel = new System.Windows.Forms.Button();
            this.RestaurantsListView = new System.Windows.Forms.ListView();
            this.CreateCinePanel = new System.Windows.Forms.Panel();
            this.AcceptCreateCineButton = new System.Windows.Forms.Button();
            this.CancelCreateCineButton = new System.Windows.Forms.Button();
            this.CineOwnerNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CineNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CineOpenTimeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CineCloseTimeTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CineNumSalasTextBox = new System.Windows.Forms.TextBox();
            this.ViewCinesPanel = new System.Windows.Forms.Panel();
            this.ViewCinesListView = new System.Windows.Forms.ListView();
            this.ExitViewCinesButton = new System.Windows.Forms.Button();
            this.SeeCinemasButton = new System.Windows.Forms.Button();
            this.CreateStorePanel = new System.Windows.Forms.Panel();
            this.StoreNameTextBox = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.StoreOwnerNameTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.StoreOpenTimeTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.StoreCloseTimeTextBox = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.StoreCategoryTextBox = new System.Windows.Forms.TextBox();
            this.AcceptCreateStore = new System.Windows.Forms.Button();
            this.CancelCreateStore = new System.Windows.Forms.Button();
            this.VerTiendasPanel = new System.Windows.Forms.Panel();
            this.StoreListView = new System.Windows.Forms.ListView();
            this.exitVerTiendasButton = new System.Windows.Forms.Button();
            this.VerTiendasButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.addLocalPanel.SuspendLayout();
            this.createRestaurantPanel.SuspendLayout();
            this.seeLocalsInfoPanel.SuspendLayout();
            this.RestaurantsViewPanel.SuspendLayout();
            this.CreateCinePanel.SuspendLayout();
            this.ViewCinesPanel.SuspendLayout();
            this.CreateStorePanel.SuspendLayout();
            this.VerTiendasPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainExit
            // 
            this.mainExit.Location = new System.Drawing.Point(46, 277);
            this.mainExit.Name = "mainExit";
            this.mainExit.Size = new System.Drawing.Size(117, 58);
            this.mainExit.TabIndex = 0;
            this.mainExit.Text = "Salir";
            this.mainExit.UseVisualStyleBackColor = true;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // addLocal
            // 
            this.addLocal.Location = new System.Drawing.Point(46, 15);
            this.addLocal.Name = "addLocal";
            this.addLocal.Size = new System.Drawing.Size(117, 58);
            this.addLocal.TabIndex = 1;
            this.addLocal.Text = "Agregar Local";
            this.addLocal.UseVisualStyleBackColor = true;
            this.addLocal.Click += new System.EventHandler(this.addLocal_Click);
            // 
            // seeInfoButton
            // 
            this.seeInfoButton.Location = new System.Drawing.Point(46, 105);
            this.seeInfoButton.Name = "seeInfoButton";
            this.seeInfoButton.Size = new System.Drawing.Size(117, 67);
            this.seeInfoButton.TabIndex = 2;
            this.seeInfoButton.Text = "Ver Info. Locales";
            this.seeInfoButton.UseVisualStyleBackColor = true;
            this.seeInfoButton.Click += new System.EventHandler(this.seeInfoButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.addLocal);
            this.mainPanel.Controls.Add(this.seeInfoButton);
            this.mainPanel.Controls.Add(this.mainExit);
            this.mainPanel.Location = new System.Drawing.Point(280, 31);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(204, 363);
            this.mainPanel.TabIndex = 3;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // addLocalPanel
            // 
            this.addLocalPanel.Controls.Add(this.localTypeTB);
            this.addLocalPanel.Controls.Add(this.cancelInput);
            this.addLocalPanel.Controls.Add(this.acceptInput);
            this.addLocalPanel.Controls.Add(this.enterLocalType);
            this.addLocalPanel.Location = new System.Drawing.Point(162, 75);
            this.addLocalPanel.Name = "addLocalPanel";
            this.addLocalPanel.Size = new System.Drawing.Size(437, 146);
            this.addLocalPanel.TabIndex = 4;
            this.addLocalPanel.Visible = false;
            // 
            // localTypeTB
            // 
            this.localTypeTB.Location = new System.Drawing.Point(178, 23);
            this.localTypeTB.Name = "localTypeTB";
            this.localTypeTB.Size = new System.Drawing.Size(226, 26);
            this.localTypeTB.TabIndex = 4;
            this.localTypeTB.TextChanged += new System.EventHandler(this.localTypeTB_TextChanged);
            // 
            // cancelInput
            // 
            this.cancelInput.Location = new System.Drawing.Point(225, 80);
            this.cancelInput.Name = "cancelInput";
            this.cancelInput.Size = new System.Drawing.Size(124, 38);
            this.cancelInput.TabIndex = 3;
            this.cancelInput.Text = "Cancelar";
            this.cancelInput.UseVisualStyleBackColor = true;
            this.cancelInput.Click += new System.EventHandler(this.cancelInput_Click);
            // 
            // acceptInput
            // 
            this.acceptInput.Location = new System.Drawing.Point(65, 80);
            this.acceptInput.Name = "acceptInput";
            this.acceptInput.Size = new System.Drawing.Size(124, 38);
            this.acceptInput.TabIndex = 2;
            this.acceptInput.Text = "Aceptar";
            this.acceptInput.UseVisualStyleBackColor = true;
            this.acceptInput.Click += new System.EventHandler(this.acceptInput_Click);
            // 
            // enterLocalType
            // 
            this.enterLocalType.AutoSize = true;
            this.enterLocalType.Location = new System.Drawing.Point(17, 29);
            this.enterLocalType.Name = "enterLocalType";
            this.enterLocalType.Size = new System.Drawing.Size(155, 20);
            this.enterLocalType.TabIndex = 0;
            this.enterLocalType.Text = "Ingrese tipo de local:";
            this.enterLocalType.Click += new System.EventHandler(this.enterLocalType_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // createRestaurantPanel
            // 
            this.createRestaurantPanel.Controls.Add(this.exclusiveTablesCheckBox);
            this.createRestaurantPanel.Controls.Add(this.EnterRCloseTextBox);
            this.createRestaurantPanel.Controls.Add(this.EnterROpenTextBox);
            this.createRestaurantPanel.Controls.Add(this.EnterROwnerTextBox);
            this.createRestaurantPanel.Controls.Add(this.EnterRNameTextBox);
            this.createRestaurantPanel.Controls.Add(this.label4);
            this.createRestaurantPanel.Controls.Add(this.label3);
            this.createRestaurantPanel.Controls.Add(this.label2);
            this.createRestaurantPanel.Controls.Add(this.label1);
            this.createRestaurantPanel.Controls.Add(this.cancelCreateRbutton);
            this.createRestaurantPanel.Controls.Add(this.acceptCreateRButton);
            this.createRestaurantPanel.Location = new System.Drawing.Point(162, 254);
            this.createRestaurantPanel.Name = "createRestaurantPanel";
            this.createRestaurantPanel.Size = new System.Drawing.Size(437, 259);
            this.createRestaurantPanel.TabIndex = 5;
            this.createRestaurantPanel.Visible = false;
            this.createRestaurantPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.createRestaurantPanel_Paint);
            // 
            // exclusiveTablesCheckBox
            // 
            this.exclusiveTablesCheckBox.AutoSize = true;
            this.exclusiveTablesCheckBox.Location = new System.Drawing.Point(142, 174);
            this.exclusiveTablesCheckBox.Name = "exclusiveTablesCheckBox";
            this.exclusiveTablesCheckBox.Size = new System.Drawing.Size(202, 24);
            this.exclusiveTablesCheckBox.TabIndex = 10;
            this.exclusiveTablesCheckBox.Text = "Tiene Mesas Exclusivas";
            this.exclusiveTablesCheckBox.UseVisualStyleBackColor = true;
            this.exclusiveTablesCheckBox.CheckedChanged += new System.EventHandler(this.exclusiveTablesCheckBox_CheckedChanged);
            // 
            // EnterRCloseTextBox
            // 
            this.EnterRCloseTextBox.Location = new System.Drawing.Point(142, 135);
            this.EnterRCloseTextBox.Name = "EnterRCloseTextBox";
            this.EnterRCloseTextBox.Size = new System.Drawing.Size(228, 26);
            this.EnterRCloseTextBox.TabIndex = 9;
            this.EnterRCloseTextBox.TextChanged += new System.EventHandler(this.EnterRCloseTextBox_TextChanged);
            // 
            // EnterROpenTextBox
            // 
            this.EnterROpenTextBox.Location = new System.Drawing.Point(142, 103);
            this.EnterROpenTextBox.Name = "EnterROpenTextBox";
            this.EnterROpenTextBox.Size = new System.Drawing.Size(228, 26);
            this.EnterROpenTextBox.TabIndex = 8;
            // 
            // EnterROwnerTextBox
            // 
            this.EnterROwnerTextBox.Location = new System.Drawing.Point(142, 64);
            this.EnterROwnerTextBox.Name = "EnterROwnerTextBox";
            this.EnterROwnerTextBox.Size = new System.Drawing.Size(228, 26);
            this.EnterROwnerTextBox.TabIndex = 7;
            // 
            // EnterRNameTextBox
            // 
            this.EnterRNameTextBox.Location = new System.Drawing.Point(142, 26);
            this.EnterRNameTextBox.Name = "EnterRNameTextBox";
            this.EnterRNameTextBox.Size = new System.Drawing.Size(228, 26);
            this.EnterRNameTextBox.TabIndex = 6;
            this.EnterRNameTextBox.TextChanged += new System.EventHandler(this.EnterRNameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hora Cierre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora Apertura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Dueño:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // cancelCreateRbutton
            // 
            this.cancelCreateRbutton.Location = new System.Drawing.Point(246, 204);
            this.cancelCreateRbutton.Name = "cancelCreateRbutton";
            this.cancelCreateRbutton.Size = new System.Drawing.Size(103, 42);
            this.cancelCreateRbutton.TabIndex = 1;
            this.cancelCreateRbutton.Text = "Cancelar";
            this.cancelCreateRbutton.UseVisualStyleBackColor = true;
            this.cancelCreateRbutton.Click += new System.EventHandler(this.cancelCreateRbutton_Click);
            // 
            // acceptCreateRButton
            // 
            this.acceptCreateRButton.Location = new System.Drawing.Point(81, 204);
            this.acceptCreateRButton.Name = "acceptCreateRButton";
            this.acceptCreateRButton.Size = new System.Drawing.Size(108, 42);
            this.acceptCreateRButton.TabIndex = 0;
            this.acceptCreateRButton.Text = "Aceptar";
            this.acceptCreateRButton.UseVisualStyleBackColor = true;
            this.acceptCreateRButton.Click += new System.EventHandler(this.acceptCreateRButton_Click);
            // 
            // seeLocalsInfoPanel
            // 
            this.seeLocalsInfoPanel.Controls.Add(this.VerTiendasButton);
            this.seeLocalsInfoPanel.Controls.Add(this.SeeCinemasButton);
            this.seeLocalsInfoPanel.Controls.Add(this.exitLocaleInfoMainButton);
            this.seeLocalsInfoPanel.Controls.Add(this.SeeRestaurantsButton);
            this.seeLocalsInfoPanel.Location = new System.Drawing.Point(253, 22);
            this.seeLocalsInfoPanel.Name = "seeLocalsInfoPanel";
            this.seeLocalsInfoPanel.Size = new System.Drawing.Size(258, 393);
            this.seeLocalsInfoPanel.TabIndex = 6;
            this.seeLocalsInfoPanel.Visible = false;
            this.seeLocalsInfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.seeLocalsInfoPanel_Paint);
            // 
            // exitLocaleInfoMainButton
            // 
            this.exitLocaleInfoMainButton.Location = new System.Drawing.Point(73, 300);
            this.exitLocaleInfoMainButton.Name = "exitLocaleInfoMainButton";
            this.exitLocaleInfoMainButton.Size = new System.Drawing.Size(133, 61);
            this.exitLocaleInfoMainButton.TabIndex = 1;
            this.exitLocaleInfoMainButton.Text = "Salir";
            this.exitLocaleInfoMainButton.UseVisualStyleBackColor = true;
            this.exitLocaleInfoMainButton.Click += new System.EventHandler(this.exitLocaleInfoMainButton_Click);
            // 
            // SeeRestaurantsButton
            // 
            this.SeeRestaurantsButton.Location = new System.Drawing.Point(73, 24);
            this.SeeRestaurantsButton.Name = "SeeRestaurantsButton";
            this.SeeRestaurantsButton.Size = new System.Drawing.Size(133, 61);
            this.SeeRestaurantsButton.TabIndex = 0;
            this.SeeRestaurantsButton.Text = "Ver Restaurants";
            this.SeeRestaurantsButton.UseVisualStyleBackColor = true;
            this.SeeRestaurantsButton.Click += new System.EventHandler(this.SeeRestaurantsButton_Click);
            // 
            // RestaurantsViewPanel
            // 
            this.RestaurantsViewPanel.Controls.Add(this.CloseRestaurantViewPanel);
            this.RestaurantsViewPanel.Controls.Add(this.RestaurantsListView);
            this.RestaurantsViewPanel.Location = new System.Drawing.Point(62, 12);
            this.RestaurantsViewPanel.Name = "RestaurantsViewPanel";
            this.RestaurantsViewPanel.Size = new System.Drawing.Size(639, 488);
            this.RestaurantsViewPanel.TabIndex = 7;
            this.RestaurantsViewPanel.Visible = false;
            this.RestaurantsViewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RestaurantsViewPanel_Paint);
            // 
            // CloseRestaurantViewPanel
            // 
            this.CloseRestaurantViewPanel.Location = new System.Drawing.Point(242, 416);
            this.CloseRestaurantViewPanel.Name = "CloseRestaurantViewPanel";
            this.CloseRestaurantViewPanel.Size = new System.Drawing.Size(155, 42);
            this.CloseRestaurantViewPanel.TabIndex = 1;
            this.CloseRestaurantViewPanel.Text = "Cerrar";
            this.CloseRestaurantViewPanel.UseVisualStyleBackColor = true;
            this.CloseRestaurantViewPanel.Click += new System.EventHandler(this.CloseRestaurantViewPanel_Click);
            // 
            // RestaurantsListView
            // 
            this.RestaurantsListView.HideSelection = false;
            this.RestaurantsListView.Location = new System.Drawing.Point(28, 10);
            this.RestaurantsListView.Name = "RestaurantsListView";
            this.RestaurantsListView.Size = new System.Drawing.Size(578, 390);
            this.RestaurantsListView.TabIndex = 0;
            this.RestaurantsListView.UseCompatibleStateImageBehavior = false;
            this.RestaurantsListView.SelectedIndexChanged += new System.EventHandler(this.RestaurantsListView_SelectedIndexChanged);
            // 
            // CreateCinePanel
            // 
            this.CreateCinePanel.Controls.Add(this.CineNumSalasTextBox);
            this.CreateCinePanel.Controls.Add(this.label9);
            this.CreateCinePanel.Controls.Add(this.CineCloseTimeTextBox);
            this.CreateCinePanel.Controls.Add(this.label8);
            this.CreateCinePanel.Controls.Add(this.CineOpenTimeTextBox);
            this.CreateCinePanel.Controls.Add(this.label7);
            this.CreateCinePanel.Controls.Add(this.CineNameTextBox);
            this.CreateCinePanel.Controls.Add(this.label6);
            this.CreateCinePanel.Controls.Add(this.label5);
            this.CreateCinePanel.Controls.Add(this.CineOwnerNameTextBox);
            this.CreateCinePanel.Controls.Add(this.CancelCreateCineButton);
            this.CreateCinePanel.Controls.Add(this.AcceptCreateCineButton);
            this.CreateCinePanel.Location = new System.Drawing.Point(62, -3);
            this.CreateCinePanel.Name = "CreateCinePanel";
            this.CreateCinePanel.Size = new System.Drawing.Size(670, 611);
            this.CreateCinePanel.TabIndex = 8;
            this.CreateCinePanel.Visible = false;
            // 
            // AcceptCreateCineButton
            // 
            this.AcceptCreateCineButton.Location = new System.Drawing.Point(140, 460);
            this.AcceptCreateCineButton.Name = "AcceptCreateCineButton";
            this.AcceptCreateCineButton.Size = new System.Drawing.Size(132, 64);
            this.AcceptCreateCineButton.TabIndex = 0;
            this.AcceptCreateCineButton.Text = "Aceptar";
            this.AcceptCreateCineButton.UseVisualStyleBackColor = true;
            this.AcceptCreateCineButton.Click += new System.EventHandler(this.AcceptCreateCineButton_Click);
            // 
            // CancelCreateCineButton
            // 
            this.CancelCreateCineButton.Location = new System.Drawing.Point(357, 460);
            this.CancelCreateCineButton.Name = "CancelCreateCineButton";
            this.CancelCreateCineButton.Size = new System.Drawing.Size(132, 64);
            this.CancelCreateCineButton.TabIndex = 1;
            this.CancelCreateCineButton.Text = "Cancelar";
            this.CancelCreateCineButton.UseVisualStyleBackColor = true;
            this.CancelCreateCineButton.Click += new System.EventHandler(this.CancelCreateCineButton_Click);
            // 
            // CineOwnerNameTextBox
            // 
            this.CineOwnerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CineOwnerNameTextBox.Location = new System.Drawing.Point(181, 104);
            this.CineOwnerNameTextBox.Name = "CineOwnerNameTextBox";
            this.CineOwnerNameTextBox.Size = new System.Drawing.Size(308, 26);
            this.CineOwnerNameTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre Dueño:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre Cine:";
            // 
            // CineNameTextBox
            // 
            this.CineNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CineNameTextBox.Location = new System.Drawing.Point(181, 152);
            this.CineNameTextBox.Name = "CineNameTextBox";
            this.CineNameTextBox.Size = new System.Drawing.Size(308, 26);
            this.CineNameTextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hora Apertura:";
            // 
            // CineOpenTimeTextBox
            // 
            this.CineOpenTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CineOpenTimeTextBox.Location = new System.Drawing.Point(181, 204);
            this.CineOpenTimeTextBox.Name = "CineOpenTimeTextBox";
            this.CineOpenTimeTextBox.Size = new System.Drawing.Size(308, 26);
            this.CineOpenTimeTextBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hora Cierre:";
            // 
            // CineCloseTimeTextBox
            // 
            this.CineCloseTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CineCloseTimeTextBox.Location = new System.Drawing.Point(181, 255);
            this.CineCloseTimeTextBox.Name = "CineCloseTimeTextBox";
            this.CineCloseTimeTextBox.Size = new System.Drawing.Size(308, 26);
            this.CineCloseTimeTextBox.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Num. Salas:";
            // 
            // CineNumSalasTextBox
            // 
            this.CineNumSalasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CineNumSalasTextBox.Location = new System.Drawing.Point(181, 304);
            this.CineNumSalasTextBox.Name = "CineNumSalasTextBox";
            this.CineNumSalasTextBox.Size = new System.Drawing.Size(308, 26);
            this.CineNumSalasTextBox.TabIndex = 11;
            // 
            // ViewCinesPanel
            // 
            this.ViewCinesPanel.Controls.Add(this.ExitViewCinesButton);
            this.ViewCinesPanel.Controls.Add(this.ViewCinesListView);
            this.ViewCinesPanel.Location = new System.Drawing.Point(22, 31);
            this.ViewCinesPanel.Name = "ViewCinesPanel";
            this.ViewCinesPanel.Size = new System.Drawing.Size(887, 574);
            this.ViewCinesPanel.TabIndex = 9;
            this.ViewCinesPanel.Visible = false;
            // 
            // ViewCinesListView
            // 
            this.ViewCinesListView.HideSelection = false;
            this.ViewCinesListView.Location = new System.Drawing.Point(40, 19);
            this.ViewCinesListView.Name = "ViewCinesListView";
            this.ViewCinesListView.Size = new System.Drawing.Size(800, 471);
            this.ViewCinesListView.TabIndex = 0;
            this.ViewCinesListView.UseCompatibleStateImageBehavior = false;
            // 
            // ExitViewCinesButton
            // 
            this.ExitViewCinesButton.Location = new System.Drawing.Point(386, 510);
            this.ExitViewCinesButton.Name = "ExitViewCinesButton";
            this.ExitViewCinesButton.Size = new System.Drawing.Size(143, 51);
            this.ExitViewCinesButton.TabIndex = 1;
            this.ExitViewCinesButton.Text = "Salir";
            this.ExitViewCinesButton.UseVisualStyleBackColor = true;
            this.ExitViewCinesButton.Click += new System.EventHandler(this.ExitViewCinesButton_Click);
            // 
            // SeeCinemasButton
            // 
            this.SeeCinemasButton.Location = new System.Drawing.Point(73, 110);
            this.SeeCinemasButton.Name = "SeeCinemasButton";
            this.SeeCinemasButton.Size = new System.Drawing.Size(133, 63);
            this.SeeCinemasButton.TabIndex = 2;
            this.SeeCinemasButton.Text = "Ver Cines";
            this.SeeCinemasButton.UseVisualStyleBackColor = true;
            this.SeeCinemasButton.Click += new System.EventHandler(this.SeeCinemasButton_Click);
            // 
            // CreateStorePanel
            // 
            this.CreateStorePanel.Controls.Add(this.CancelCreateStore);
            this.CreateStorePanel.Controls.Add(this.AcceptCreateStore);
            this.CreateStorePanel.Controls.Add(this.StoreCategoryTextBox);
            this.CreateStorePanel.Controls.Add(this.label14);
            this.CreateStorePanel.Controls.Add(this.StoreCloseTimeTextBox);
            this.CreateStorePanel.Controls.Add(this.label13);
            this.CreateStorePanel.Controls.Add(this.StoreOpenTimeTextBox);
            this.CreateStorePanel.Controls.Add(this.label12);
            this.CreateStorePanel.Controls.Add(this.StoreOwnerNameTextBox);
            this.CreateStorePanel.Controls.Add(this.label11);
            this.CreateStorePanel.Controls.Add(this.label10);
            this.CreateStorePanel.Controls.Add(this.splitter1);
            this.CreateStorePanel.Controls.Add(this.StoreNameTextBox);
            this.CreateStorePanel.Location = new System.Drawing.Point(90, 110);
            this.CreateStorePanel.Name = "CreateStorePanel";
            this.CreateStorePanel.Size = new System.Drawing.Size(639, 455);
            this.CreateStorePanel.TabIndex = 12;
            this.CreateStorePanel.Visible = false;
            // 
            // StoreNameTextBox
            // 
            this.StoreNameTextBox.Location = new System.Drawing.Point(172, 60);
            this.StoreNameTextBox.Name = "StoreNameTextBox";
            this.StoreNameTextBox.Size = new System.Drawing.Size(317, 26);
            this.StoreNameTextBox.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 455);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nombre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Nombre Dueño:";
            // 
            // StoreOwnerNameTextBox
            // 
            this.StoreOwnerNameTextBox.Location = new System.Drawing.Point(172, 114);
            this.StoreOwnerNameTextBox.Name = "StoreOwnerNameTextBox";
            this.StoreOwnerNameTextBox.Size = new System.Drawing.Size(317, 26);
            this.StoreOwnerNameTextBox.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Hora Apertura:";
            // 
            // StoreOpenTimeTextBox
            // 
            this.StoreOpenTimeTextBox.Location = new System.Drawing.Point(172, 174);
            this.StoreOpenTimeTextBox.Name = "StoreOpenTimeTextBox";
            this.StoreOpenTimeTextBox.Size = new System.Drawing.Size(317, 26);
            this.StoreOpenTimeTextBox.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Hora Cierre:";
            // 
            // StoreCloseTimeTextBox
            // 
            this.StoreCloseTimeTextBox.Location = new System.Drawing.Point(172, 233);
            this.StoreCloseTimeTextBox.Name = "StoreCloseTimeTextBox";
            this.StoreCloseTimeTextBox.Size = new System.Drawing.Size(317, 26);
            this.StoreCloseTimeTextBox.TabIndex = 8;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(310, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Categorias (ingresar separadas por coma):";
            // 
            // StoreCategoryTextBox
            // 
            this.StoreCategoryTextBox.Location = new System.Drawing.Point(49, 326);
            this.StoreCategoryTextBox.Name = "StoreCategoryTextBox";
            this.StoreCategoryTextBox.Size = new System.Drawing.Size(450, 26);
            this.StoreCategoryTextBox.TabIndex = 10;
            // 
            // AcceptCreateStore
            // 
            this.AcceptCreateStore.Location = new System.Drawing.Point(141, 376);
            this.AcceptCreateStore.Name = "AcceptCreateStore";
            this.AcceptCreateStore.Size = new System.Drawing.Size(120, 55);
            this.AcceptCreateStore.TabIndex = 11;
            this.AcceptCreateStore.Text = "Aceptar";
            this.AcceptCreateStore.UseVisualStyleBackColor = true;
            this.AcceptCreateStore.Click += new System.EventHandler(this.AcceptCreateStore_Click);
            // 
            // CancelCreateStore
            // 
            this.CancelCreateStore.Location = new System.Drawing.Point(322, 376);
            this.CancelCreateStore.Name = "CancelCreateStore";
            this.CancelCreateStore.Size = new System.Drawing.Size(120, 55);
            this.CancelCreateStore.TabIndex = 12;
            this.CancelCreateStore.Text = "Cancelar";
            this.CancelCreateStore.UseVisualStyleBackColor = true;
            this.CancelCreateStore.Click += new System.EventHandler(this.CancelCreateStore_Click);
            // 
            // VerTiendasPanel
            // 
            this.VerTiendasPanel.Controls.Add(this.exitVerTiendasButton);
            this.VerTiendasPanel.Controls.Add(this.StoreListView);
            this.VerTiendasPanel.Location = new System.Drawing.Point(13, 12);
            this.VerTiendasPanel.Name = "VerTiendasPanel";
            this.VerTiendasPanel.Size = new System.Drawing.Size(871, 485);
            this.VerTiendasPanel.TabIndex = 13;
            this.VerTiendasPanel.Visible = false;
            // 
            // StoreListView
            // 
            this.StoreListView.HideSelection = false;
            this.StoreListView.Location = new System.Drawing.Point(22, 28);
            this.StoreListView.Name = "StoreListView";
            this.StoreListView.Size = new System.Drawing.Size(827, 390);
            this.StoreListView.TabIndex = 0;
            this.StoreListView.UseCompatibleStateImageBehavior = false;
            this.StoreListView.SelectedIndexChanged += new System.EventHandler(this.StoreListView_SelectedIndexChanged);
            // 
            // exitVerTiendasButton
            // 
            this.exitVerTiendasButton.Location = new System.Drawing.Point(373, 424);
            this.exitVerTiendasButton.Name = "exitVerTiendasButton";
            this.exitVerTiendasButton.Size = new System.Drawing.Size(146, 48);
            this.exitVerTiendasButton.TabIndex = 1;
            this.exitVerTiendasButton.Text = "Salir";
            this.exitVerTiendasButton.UseVisualStyleBackColor = true;
            this.exitVerTiendasButton.Click += new System.EventHandler(this.exitVerTiendasButton_Click);
            // 
            // VerTiendasButton
            // 
            this.VerTiendasButton.Location = new System.Drawing.Point(73, 202);
            this.VerTiendasButton.Name = "VerTiendasButton";
            this.VerTiendasButton.Size = new System.Drawing.Size(133, 54);
            this.VerTiendasButton.TabIndex = 3;
            this.VerTiendasButton.Text = "Ver Tiendas";
            this.VerTiendasButton.UseVisualStyleBackColor = true;
            this.VerTiendasButton.Click += new System.EventHandler(this.VerTiendasButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 664);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.RestaurantsViewPanel);
            this.Controls.Add(this.VerTiendasPanel);
            this.Controls.Add(this.CreateStorePanel);
            this.Controls.Add(this.seeLocalsInfoPanel);
            this.Controls.Add(this.createRestaurantPanel);
            this.Controls.Add(this.addLocalPanel);
            this.Controls.Add(this.CreateCinePanel);
            this.Controls.Add(this.ViewCinesPanel);
            this.Name = "MainForm";
            this.Text = "Menu";
            this.mainPanel.ResumeLayout(false);
            this.addLocalPanel.ResumeLayout(false);
            this.addLocalPanel.PerformLayout();
            this.createRestaurantPanel.ResumeLayout(false);
            this.createRestaurantPanel.PerformLayout();
            this.seeLocalsInfoPanel.ResumeLayout(false);
            this.RestaurantsViewPanel.ResumeLayout(false);
            this.CreateCinePanel.ResumeLayout(false);
            this.CreateCinePanel.PerformLayout();
            this.ViewCinesPanel.ResumeLayout(false);
            this.CreateStorePanel.ResumeLayout(false);
            this.CreateStorePanel.PerformLayout();
            this.VerTiendasPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainExit;
        private System.Windows.Forms.Button addLocal;
        private System.Windows.Forms.Button seeInfoButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel addLocalPanel;
        private System.Windows.Forms.Label enterLocalType;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button cancelInput;
        private System.Windows.Forms.Button acceptInput;
        private System.Windows.Forms.TextBox localTypeTB;
        private System.Windows.Forms.Panel createRestaurantPanel;
        private System.Windows.Forms.CheckBox exclusiveTablesCheckBox;
        private System.Windows.Forms.TextBox EnterRCloseTextBox;
        private System.Windows.Forms.TextBox EnterROpenTextBox;
        private System.Windows.Forms.TextBox EnterROwnerTextBox;
        private System.Windows.Forms.TextBox EnterRNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelCreateRbutton;
        private System.Windows.Forms.Button acceptCreateRButton;
        private System.Windows.Forms.Panel seeLocalsInfoPanel;
        private System.Windows.Forms.Button exitLocaleInfoMainButton;
        private System.Windows.Forms.Button SeeRestaurantsButton;
        private System.Windows.Forms.Panel RestaurantsViewPanel;
        private System.Windows.Forms.ListView RestaurantsListView;
        private System.Windows.Forms.Button CloseRestaurantViewPanel;
        private System.Windows.Forms.Panel CreateCinePanel;
        private System.Windows.Forms.Button CancelCreateCineButton;
        private System.Windows.Forms.Button AcceptCreateCineButton;
        private System.Windows.Forms.TextBox CineNumSalasTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CineCloseTimeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CineOpenTimeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CineNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CineOwnerNameTextBox;
        private System.Windows.Forms.Panel ViewCinesPanel;
        private System.Windows.Forms.Button ExitViewCinesButton;
        private System.Windows.Forms.ListView ViewCinesListView;
        private System.Windows.Forms.Button SeeCinemasButton;
        private System.Windows.Forms.Panel CreateStorePanel;
        private System.Windows.Forms.Button CancelCreateStore;
        private System.Windows.Forms.Button AcceptCreateStore;
        private System.Windows.Forms.TextBox StoreCategoryTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox StoreCloseTimeTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox StoreOpenTimeTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox StoreOwnerNameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox StoreNameTextBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel VerTiendasPanel;
        private System.Windows.Forms.Button exitVerTiendasButton;
        private System.Windows.Forms.ListView StoreListView;
        private System.Windows.Forms.Button VerTiendasButton;
    }
}

