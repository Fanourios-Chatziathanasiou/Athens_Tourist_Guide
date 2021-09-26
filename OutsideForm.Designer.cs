
namespace WinFormsApp3
{
    partial class OutsideForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutsideForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accommodationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eatDrinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCalendar = new FontAwesome.Sharp.IconButton();
            this.titleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.labelNewLandmarks = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.labelNewMarkets = new System.Windows.Forms.Label();
            this.labelNewEatDrink = new System.Windows.Forms.Label();
            this.labelNewAccommodations = new System.Windows.Forms.Label();
            this.btnEatDrink = new FontAwesome.Sharp.IconButton();
            this.btnMarkets = new FontAwesome.Sharp.IconButton();
            this.btnLandmarks = new FontAwesome.Sharp.IconButton();
            this.btnAccommondations = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.accommodationsToolStripMenuItem,
            this.landmarksToolStripMenuItem,
            this.marketsToolStripMenuItem,
            this.eatDrinkToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1558, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // accommodationsToolStripMenuItem
            // 
            this.accommodationsToolStripMenuItem.Name = "accommodationsToolStripMenuItem";
            this.accommodationsToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.accommodationsToolStripMenuItem.Text = "Διαμονή";
            this.accommodationsToolStripMenuItem.Click += new System.EventHandler(this.accommodationsToolStripMenuItem_Click);
            // 
            // landmarksToolStripMenuItem
            // 
            this.landmarksToolStripMenuItem.Name = "landmarksToolStripMenuItem";
            this.landmarksToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.landmarksToolStripMenuItem.Text = "Αξιοθέατα";
            this.landmarksToolStripMenuItem.Click += new System.EventHandler(this.landmarksToolStripMenuItem_Click);
            // 
            // marketsToolStripMenuItem
            // 
            this.marketsToolStripMenuItem.Name = "marketsToolStripMenuItem";
            this.marketsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.marketsToolStripMenuItem.Text = "Αγορές";
            this.marketsToolStripMenuItem.Click += new System.EventHandler(this.αγορέςToolStripMenuItem_Click);
            // 
            // eatDrinkToolStripMenuItem
            // 
            this.eatDrinkToolStripMenuItem.Name = "eatDrinkToolStripMenuItem";
            this.eatDrinkToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.eatDrinkToolStripMenuItem.Text = "Φαγητό-Διασκέδαση";
            this.eatDrinkToolStripMenuItem.Click += new System.EventHandler(this.eatDrinkToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.logoutToolStripMenuItem.Text = "Αποσύνδεση";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.exitToolStripMenuItem.Text = "Κλείσιμο";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.helpToolStripMenuItem.Text = "Βοήθεια";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.aboutToolStripMenuItem.Text = "Σχετικά";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.LightBlue;
            this.panelDesktop.Controls.Add(this.panel2);
            this.panelDesktop.Controls.Add(this.panelMenu);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 28);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1558, 789);
            this.panelDesktop.TabIndex = 4;
            this.panelDesktop.Tag = "α";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.btnCalendar);
            this.panel2.Controls.Add(this.titleChildForm);
            this.panel2.Controls.Add(this.iconCurrentChildForm);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(242, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1316, 138);
            this.panel2.TabIndex = 3;
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalendar.ForeColor = System.Drawing.Color.White;
            this.btnCalendar.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnCalendar.IconColor = System.Drawing.Color.FloralWhite;
            this.btnCalendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(960, 0);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(167, 138);
            this.btnCalendar.TabIndex = 19;
            this.btnCalendar.Tag = "Ημερολόγιο";
            this.btnCalendar.Text = "Ημερολόγιο";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // titleChildForm
            // 
            this.titleChildForm.AutoSize = true;
            this.titleChildForm.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleChildForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleChildForm.Location = new System.Drawing.Point(78, 76);
            this.titleChildForm.Margin = new System.Windows.Forms.Padding(0);
            this.titleChildForm.Name = "titleChildForm";
            this.titleChildForm.Size = new System.Drawing.Size(104, 38);
            this.titleChildForm.TabIndex = 3;
            this.titleChildForm.Text = "Αρχική";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconCurrentChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconCurrentChildForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.Control;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.Control;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 75;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(3, 60);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(0);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(75, 78);
            this.iconCurrentChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconCurrentChildForm.TabIndex = 2;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::WinFormsApp3.Properties.Resources.Athens;
            this.pictureBox2.Location = new System.Drawing.Point(1127, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Καλωσήρθατε, @username";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.btnReset);
            this.panelMenu.Controls.Add(this.labelNewLandmarks);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.labelNewMarkets);
            this.panelMenu.Controls.Add(this.labelNewEatDrink);
            this.panelMenu.Controls.Add(this.labelNewAccommodations);
            this.panelMenu.Controls.Add(this.btnEatDrink);
            this.panelMenu.Controls.Add(this.btnMarkets);
            this.panelMenu.Controls.Add(this.btnLandmarks);
            this.panelMenu.Controls.Add(this.btnAccommondations);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(242, 789);
            this.panelMenu.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.btnReset.IconColor = System.Drawing.Color.FloralWhite;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.Location = new System.Drawing.Point(0, 663);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(242, 63);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Επαναφορά νέων";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // labelNewLandmarks
            // 
            this.labelNewLandmarks.AutoSize = true;
            this.labelNewLandmarks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNewLandmarks.ForeColor = System.Drawing.Color.Red;
            this.labelNewLandmarks.Location = new System.Drawing.Point(174, 261);
            this.labelNewLandmarks.Name = "labelNewLandmarks";
            this.labelNewLandmarks.Size = new System.Drawing.Size(54, 28);
            this.labelNewLandmarks.TabIndex = 25;
            this.labelNewLandmarks.Tag = "labelNewLandmarks";
            this.labelNewLandmarks.Text = "ΝΕΟ";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.btnExit.IconColor = System.Drawing.Color.FloralWhite;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 64;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(0, 726);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(242, 63);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Αποσύνδεση";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelNewMarkets
            // 
            this.labelNewMarkets.AutoSize = true;
            this.labelNewMarkets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNewMarkets.ForeColor = System.Drawing.Color.Red;
            this.labelNewMarkets.Location = new System.Drawing.Point(174, 353);
            this.labelNewMarkets.Name = "labelNewMarkets";
            this.labelNewMarkets.Size = new System.Drawing.Size(54, 28);
            this.labelNewMarkets.TabIndex = 24;
            this.labelNewMarkets.Tag = "labelNewMarkets";
            this.labelNewMarkets.Text = "ΝΕΟ";
            // 
            // labelNewEatDrink
            // 
            this.labelNewEatDrink.AutoSize = true;
            this.labelNewEatDrink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNewEatDrink.ForeColor = System.Drawing.Color.Red;
            this.labelNewEatDrink.Location = new System.Drawing.Point(174, 445);
            this.labelNewEatDrink.Name = "labelNewEatDrink";
            this.labelNewEatDrink.Size = new System.Drawing.Size(54, 28);
            this.labelNewEatDrink.TabIndex = 23;
            this.labelNewEatDrink.Tag = "labelNewEatDrink";
            this.labelNewEatDrink.Text = "ΝΕΟ";
            // 
            // labelNewAccommodations
            // 
            this.labelNewAccommodations.AutoSize = true;
            this.labelNewAccommodations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNewAccommodations.ForeColor = System.Drawing.Color.Red;
            this.labelNewAccommodations.Location = new System.Drawing.Point(174, 169);
            this.labelNewAccommodations.Name = "labelNewAccommodations";
            this.labelNewAccommodations.Size = new System.Drawing.Size(54, 28);
            this.labelNewAccommodations.TabIndex = 21;
            this.labelNewAccommodations.Tag = "labelNewAccommodations";
            this.labelNewAccommodations.Text = "ΝΕΟ";
            // 
            // btnEatDrink
            // 
            this.btnEatDrink.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEatDrink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEatDrink.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEatDrink.FlatAppearance.BorderSize = 0;
            this.btnEatDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEatDrink.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEatDrink.ForeColor = System.Drawing.Color.White;
            this.btnEatDrink.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnEatDrink.IconColor = System.Drawing.Color.FloralWhite;
            this.btnEatDrink.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEatDrink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEatDrink.Location = new System.Drawing.Point(0, 414);
            this.btnEatDrink.Margin = new System.Windows.Forms.Padding(0);
            this.btnEatDrink.Name = "btnEatDrink";
            this.btnEatDrink.Size = new System.Drawing.Size(242, 92);
            this.btnEatDrink.TabIndex = 16;
            this.btnEatDrink.Tag = "Φαγητό-Διασκέδαση";
            this.btnEatDrink.Text = "Φαγητό-\r\nΔιασκέδαση";
            this.btnEatDrink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEatDrink.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEatDrink.UseVisualStyleBackColor = false;
            this.btnEatDrink.Click += new System.EventHandler(this.btnEatDrink_Click);
            // 
            // btnMarkets
            // 
            this.btnMarkets.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMarkets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarkets.FlatAppearance.BorderSize = 0;
            this.btnMarkets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkets.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMarkets.ForeColor = System.Drawing.Color.White;
            this.btnMarkets.IconChar = FontAwesome.Sharp.IconChar.StoreAlt;
            this.btnMarkets.IconColor = System.Drawing.Color.FloralWhite;
            this.btnMarkets.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMarkets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarkets.Location = new System.Drawing.Point(0, 322);
            this.btnMarkets.Margin = new System.Windows.Forms.Padding(0);
            this.btnMarkets.Name = "btnMarkets";
            this.btnMarkets.Size = new System.Drawing.Size(242, 92);
            this.btnMarkets.TabIndex = 15;
            this.btnMarkets.Tag = "Αγορές";
            this.btnMarkets.Text = "Αγορές";
            this.btnMarkets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarkets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarkets.UseVisualStyleBackColor = false;
            this.btnMarkets.Click += new System.EventHandler(this.btnMarkets_Click);
            // 
            // btnLandmarks
            // 
            this.btnLandmarks.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLandmarks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLandmarks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLandmarks.FlatAppearance.BorderSize = 0;
            this.btnLandmarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLandmarks.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLandmarks.ForeColor = System.Drawing.Color.White;
            this.btnLandmarks.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.btnLandmarks.IconColor = System.Drawing.Color.FloralWhite;
            this.btnLandmarks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLandmarks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLandmarks.Location = new System.Drawing.Point(0, 230);
            this.btnLandmarks.Margin = new System.Windows.Forms.Padding(0);
            this.btnLandmarks.Name = "btnLandmarks";
            this.btnLandmarks.Size = new System.Drawing.Size(242, 92);
            this.btnLandmarks.TabIndex = 14;
            this.btnLandmarks.Tag = "Αξιοθέατα";
            this.btnLandmarks.Text = "Αξιοθέατα";
            this.btnLandmarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLandmarks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLandmarks.UseVisualStyleBackColor = false;
            this.btnLandmarks.Click += new System.EventHandler(this.btnLandmarks_Click);
            // 
            // btnAccommondations
            // 
            this.btnAccommondations.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAccommondations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccommondations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccommondations.FlatAppearance.BorderSize = 0;
            this.btnAccommondations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccommondations.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccommondations.ForeColor = System.Drawing.Color.White;
            this.btnAccommondations.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.btnAccommondations.IconColor = System.Drawing.Color.FloralWhite;
            this.btnAccommondations.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccommondations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccommondations.Location = new System.Drawing.Point(0, 138);
            this.btnAccommondations.Margin = new System.Windows.Forms.Padding(0);
            this.btnAccommondations.Name = "btnAccommondations";
            this.btnAccommondations.Size = new System.Drawing.Size(242, 92);
            this.btnAccommondations.TabIndex = 12;
            this.btnAccommondations.Tag = "Διαμονή";
            this.btnAccommondations.Text = "Διαμονή";
            this.btnAccommondations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccommondations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccommondations.UseVisualStyleBackColor = false;
            this.btnAccommondations.Click += new System.EventHandler(this.btnAccommondations_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = global::WinFormsApp3.Properties.Resources.maxresdefault;
            this.pictureBox1.Image = global::WinFormsApp3.Properties.Resources.maxresdefault;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Αρχική";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // OutsideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1558, 817);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1576, 864);
            this.Name = "OutsideForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Athens Tourist Guide";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OutsideForm_FormClosed);
            this.Load += new System.EventHandler(this.OutsideForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label titleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnEatDrink;
        private FontAwesome.Sharp.IconButton btnMarkets;
        private FontAwesome.Sharp.IconButton btnLandmarks;
        private FontAwesome.Sharp.IconButton btnAccommondations;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accommodationsToolStripMenuItem;
        private System.Windows.Forms.Label labelNewLandmarks;
        private System.Windows.Forms.Label labelNewMarkets;
        private System.Windows.Forms.Label labelNewEatDrink;
        private System.Windows.Forms.Label labelNewAccommodations;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnReset;
        private System.Windows.Forms.ToolStripMenuItem landmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eatDrinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private FontAwesome.Sharp.IconButton btnCalendar;
    }
}