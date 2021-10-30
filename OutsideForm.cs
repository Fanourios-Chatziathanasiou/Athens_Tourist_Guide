using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using WinFormsApp3;



namespace WinFormsApp3
{
    public partial class OutsideForm : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm; //new InsideFormHome();   
        LoginForm lfCopy;
        //OutsideForm of;

        public OutsideForm(LoginForm lf, String username = "Guest")
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 92);
            panelMenu.Controls.Add(leftBorderBtn);
            StaticFieldsClass.usernameCopy = username;
            lfCopy = lf;
            OpenChildForm(new InsideFormHome());
        }

        /*
         *
         * WS_EX_COMPOSITED works by forcing child windows to draw back to front and by double buffering them; however, 
         * the double buffering used by WS_EX_COMPOSITED for the child windows conflicts with the double buffering used by 
         * WS_EX_LAYERED windows and DWM so it does not remove the flicker in those contexts.
         * Unfortunately, this means that your composited test application flickers with DWM turned on but not with DWM turned off.
         */

        protected override CreateParams CreateParams
        { //Very important to cancel flickering effect!!
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED 	Gets or sets a bitwise combination of extended window style values.
                                           //cp.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN not a good idea when combined with above. Not tested alone
                return cp;
            }
        }

        private void checkVisitedSections()
        {
            if (StaticFieldsClass.visitedForms[0] != "0")
            {
                labelNewAccommodations.Visible = false;
            }

            if (StaticFieldsClass.visitedForms[1] != "0")
            {
                //MessageBox.Show("landmarks");
                labelNewLandmarks.Visible = false;
            }

            if (StaticFieldsClass.visitedForms[2] != "0")
            {
                //MessageBox.Show("Markets");
                labelNewMarkets.Visible = false;
            }

            if (StaticFieldsClass.visitedForms[3] != "0")
            {
                labelNewEatDrink.Visible = false;
            }
        }

        //structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);

        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;

                leftBorderBtn.BringToFront();
                //icon Current Child FORM

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                titleChildForm.Text = currentBtn.Tag.ToString();
                iconCurrentChildForm.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.MidnightBlue;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FloralWhite;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {

            if (currentChildForm != null)
            {
                if (childForm.Name == currentChildForm.Name)
                {
                    return;
                }
                currentChildForm.Close();
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            currentChildForm = childForm;
            childForm.Show();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            titleChildForm.Text = "Αρχική";
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm.Name != "InsideFormHome")
            {         
                OpenChildForm(new InsideFormHome());
                Reset();
            }
        }

        private void btnAccommodations_Click(object sender, EventArgs e)
        {
            if (currentChildForm.Name != "InsideFormAccommodations")
            {
                if (StaticFieldsClass.visitedForms[0] == "0")
                {
                    StaticFieldsClass.visitedForms[0] = "1";
                    labelNewAccommodations.Visible = false;
                }  
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new InsideFormAccommodations());
            }
            
        }

        private void btnLandmarks_Click(object sender, EventArgs e)
        {

            if (currentChildForm.Name != "InsideFormLandmarks" ) {
                if (StaticFieldsClass.visitedForms[1] == "0"){

                    StaticFieldsClass.visitedForms[1] = "1";
                    labelNewLandmarks.Visible = false;
                }  
                ActivateButton(sender, RGBColors.color2);
                OpenChildForm(new InsideFormLandmarks());
            }
        }



        private void btnMarkets_Click(object sender, EventArgs e)
        {
            
            
            if (currentChildForm.Name != "InsideFormMarkets")
            {
                if (StaticFieldsClass.visitedForms[2] == "0")
                {
                    StaticFieldsClass.visitedForms[2] = "1";
                    labelNewMarkets.Visible = false;
                }
                ActivateButton(sender, RGBColors.color3);
                OpenChildForm(new InsideFormMarkets());
            }

        }

        private void btnEatDrink_Click(object sender, EventArgs e)
        {
            if (currentChildForm.Name != "InsideFormEatDrink")
            {
                if (StaticFieldsClass.visitedForms[3] == "0")
                {
                    StaticFieldsClass.visitedForms[3] = "1";
                    labelNewEatDrink.Visible = false;
                }
                ActivateButton(sender, RGBColors.color4);
                OpenChildForm(new InsideFormEatDrink());
            }

        }



        private void OutsideForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Καλωσήρθατε, " + StaticFieldsClass.usernameCopy;
            checkVisitedSections();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {

            StaticFieldsClass.save_user_data();
            this.Hide();
            lfCopy.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            StaticFieldsClass.visitedForms[0] = "0";
            StaticFieldsClass.visitedForms[1] = "0";
            StaticFieldsClass.visitedForms[2] = "0";
            StaticFieldsClass.visitedForms[3] = "0";
            labelNewAccommodations.Visible = true;
            labelNewLandmarks.Visible = true;
            labelNewMarkets.Visible = true;
            labelNewEatDrink.Visible = true;
            OpenChildForm(new InsideFormHome());
            Reset();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ExitForm exitform = new ExitForm();
            exitform.Show();
            if (exitform.DialogResult == DialogResult.Cancel)
            {

                exitform.Close();
            }
            else if (exitform.DialogResult == DialogResult.OK)
            {

                exitform.Close();
                StaticFieldsClass.save_user_data();
                lfCopy.Close();
            }
        }




        private void accommodationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAccommondations.PerformClick();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExit.PerformClick();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InsideFormHome());
            Reset();
        }
        private void landmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLandmarks.PerformClick();
        }

        private void marketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMarkets.PerformClick();
        }

        private void eatDrinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEatDrink.PerformClick();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            if (StaticFieldsClass.usernameCopy != "Guest")
            {
                Calendar cal = new Calendar();
                cal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Παρακαλώ εγγραφτείτε στην εφαρμογή για να έχετε πρόσβαση στις λειτουργίες του Ημερολογίου.");
            }
        }

        private void OutsideForm_FormClosing(object sender, FormClosingEventArgs e)
        {       
            if (lfCopy.Visible == false)
            {

                ExitForm exitform = new ExitForm();
                exitform.ShowDialog();

                //OutsideForm_FormClosed(this, new FormClosedEventArgs);
                if (exitform.DialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    exitform.Close();
                }
                else if (exitform.DialogResult == DialogResult.OK)
                {

                    exitform.Close();
                    StaticFieldsClass.save_user_data();
                    Environment.Exit(0);

                }
            }
        }
    }  
}
