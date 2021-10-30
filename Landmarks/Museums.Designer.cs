
namespace WinFormsApp3
{
    partial class Museums
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Museums));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.exportBtn2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.exportBtn1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tag = "Museums";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1053, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Museums";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1053, 96);
            this.label1.TabIndex = 2;
            this.label1.Tag = "Museums";
            this.label1.Text = "Λοιπά Μουσεία και Πινακοθήκες";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1053, 96);
            this.label2.TabIndex = 4;
            this.label2.Tag = "Museums";
            this.label2.Text = "Πληροφορίες";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 617);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1053, 448);
            this.label3.TabIndex = 5;
            this.label3.Tag = "Museums";
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Cyan;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 1065);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1053, 96);
            this.label4.TabIndex = 7;
            this.label4.Tag = "Museums";
            this.label4.Text = "Μουσεία";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 1161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 387);
            this.panel1.TabIndex = 8;
            this.panel1.Tag = "Museums";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(338, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(692, 308);
            this.label6.TabIndex = 20;
            this.label6.Tag = "Museums";
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinFormsApp3.Properties.Resources.ethniko_arxaiologiko_mouseio_01;
            this.pictureBox2.Location = new System.Drawing.Point(3, 71);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(499, 400);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 214);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Museums";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Cyan;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1053, 52);
            this.label5.TabIndex = 1;
            this.label5.Tag = "Museums";
            this.label5.Text = "Εθνικό Αρχαιολογικό Μουσείο ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 1548);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 405);
            this.panel2.TabIndex = 9;
            this.panel2.Tag = "Museums";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Cyan;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(341, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(711, 300);
            this.label8.TabIndex = 20;
            this.label8.Tag = "Museums";
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinFormsApp3.Properties.Resources.mouseio_mpenaki_01;
            this.pictureBox3.Location = new System.Drawing.Point(3, 71);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(499, 400);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(291, 214);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Museums";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Cyan;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1053, 52);
            this.label7.TabIndex = 1;
            this.label7.Tag = "Museums";
            this.label7.Text = "Μουσείο Μπενάκη";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 1953);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1053, 405);
            this.panel3.TabIndex = 10;
            this.panel3.Tag = "Museums";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Cyan;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(341, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(675, 300);
            this.label10.TabIndex = 20;
            this.label10.Tag = "Museums";
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WinFormsApp3.Properties.Resources.ethniko_istoriko_mouseio_01;
            this.pictureBox4.Location = new System.Drawing.Point(3, 71);
            this.pictureBox4.MaximumSize = new System.Drawing.Size(499, 400);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(291, 214);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Museums";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Cyan;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1053, 52);
            this.label9.TabIndex = 1;
            this.label9.Tag = "Museums";
            this.label9.Text = "Εθνικό Ιστορικό Μουσείο";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGreen;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 2358);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1053, 405);
            this.panel4.TabIndex = 12;
            this.panel4.Tag = "Museums";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightGreen;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(341, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(682, 300);
            this.label12.TabIndex = 20;
            this.label12.Tag = "Museums";
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WinFormsApp3.Properties.Resources.ethniki_pinakothiki_01;
            this.pictureBox5.Location = new System.Drawing.Point(3, 71);
            this.pictureBox5.MaximumSize = new System.Drawing.Size(499, 400);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(291, 214);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Museums";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.LightGreen;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1053, 52);
            this.label11.TabIndex = 1;
            this.label11.Tag = "Museums";
            this.label11.Text = "Εθνική Πινακοθήκη - Μουσείο Αλεξάνδρου Σούτζου";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FloralWhite;
            this.panel6.Controls.Add(this.exportBtn2);
            this.panel6.Controls.Add(this.iconButton1);
            this.panel6.Controls.Add(this.richTextBox1);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 2763);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1053, 405);
            this.panel6.TabIndex = 14;
            this.panel6.Tag = "Museums";
            // 
            // exportBtn2
            // 
            this.exportBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exportBtn2.BackColor = System.Drawing.Color.MidnightBlue;
            this.exportBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportBtn2.FlatAppearance.BorderSize = 0;
            this.exportBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exportBtn2.ForeColor = System.Drawing.Color.White;
            this.exportBtn2.IconChar = FontAwesome.Sharp.IconChar.FileWord;
            this.exportBtn2.IconColor = System.Drawing.Color.FloralWhite;
            this.exportBtn2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exportBtn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportBtn2.Location = new System.Drawing.Point(9, 332);
            this.exportBtn2.Margin = new System.Windows.Forms.Padding(0);
            this.exportBtn2.Name = "exportBtn2";
            this.exportBtn2.Size = new System.Drawing.Size(226, 64);
            this.exportBtn2.TabIndex = 36;
            this.exportBtn2.Tag = "Museums";
            this.exportBtn2.Text = "Εξαγωγή σε αρχείο κειμένου";
            this.exportBtn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exportBtn2.UseVisualStyleBackColor = false;
            this.exportBtn2.Click += new System.EventHandler(this.exportBtn1_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Enabled = false;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.iconButton1.IconColor = System.Drawing.Color.FloralWhite;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(855, 332);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(189, 64);
            this.iconButton1.TabIndex = 22;
            this.iconButton1.Tag = "Museums";
            this.iconButton1.Text = "Kαταχώρηση μηνύματος";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.Location = new System.Drawing.Point(341, 178);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(408, 160);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Tag = "Museums";
            this.richTextBox1.Text = "";
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FloralWhite;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(0, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(1053, 91);
            this.label19.TabIndex = 20;
            this.label19.Tag = "Museums";
            this.label19.Text = "Έχετε κάποιο προσωπικό σχόλιο-σημείωση που θα θέλατε να κάνετε για το αξιοθέατο;\r" +
    "\nΣυμπληρώστε τη παρακάτω φόρμα για να καταχωρηθεί στο προσωπικό σας ημερολόγιο!";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FloralWhite;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Dock = System.Windows.Forms.DockStyle.Top;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(1053, 52);
            this.label20.TabIndex = 1;
            this.label20.Tag = "Museums";
            this.label20.Text = "Προσωπικά Σχόλια...";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exportBtn1
            // 
            this.exportBtn1.BackColor = System.Drawing.Color.MidnightBlue;
            this.exportBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportBtn1.FlatAppearance.BorderSize = 0;
            this.exportBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exportBtn1.ForeColor = System.Drawing.Color.White;
            this.exportBtn1.IconChar = FontAwesome.Sharp.IconChar.FileWord;
            this.exportBtn1.IconColor = System.Drawing.Color.FloralWhite;
            this.exportBtn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exportBtn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportBtn1.Location = new System.Drawing.Point(3, 448);
            this.exportBtn1.Margin = new System.Windows.Forms.Padding(0);
            this.exportBtn1.Name = "exportBtn1";
            this.exportBtn1.Size = new System.Drawing.Size(226, 64);
            this.exportBtn1.TabIndex = 36;
            this.exportBtn1.Tag = "Museums";
            this.exportBtn1.Text = "Εξαγωγή σε αρχείο κειμένου";
            this.exportBtn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exportBtn1.UseVisualStyleBackColor = false;
            this.exportBtn1.Click += new System.EventHandler(this.exportBtn1_Click);
            // 
            // Museums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1074, 595);
            this.Controls.Add(this.exportBtn1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Museums";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Museums";
            this.Load += new System.EventHandler(this.Museums_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private FontAwesome.Sharp.IconButton exportBtn2;
        private FontAwesome.Sharp.IconButton exportBtn1;
    }
}