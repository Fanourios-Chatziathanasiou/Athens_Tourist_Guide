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


namespace WinFormsApp3
{
    public partial class OutsideForm : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm; //new InsideFormHome();
        //string usertype = "Guest";
        List<String> visitedFormsCopy = new List<String>();
        string usernameCopy;
        LoginForm lfCopy;
        //OutsideForm of;

        public OutsideForm(LoginForm lf,List<String> visitedForms, String username = "Guest")
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 92);
            panelMenu.Controls.Add(leftBorderBtn);
            visitedFormsCopy = visitedForms;
            visitedFormsCopy = lf.visitedForms;
            usernameCopy = username;
            lfCopy = lf;
            //OpenChildForm(new InsideFormHome());
            //chech if section visited
            checkVisitedSections();
           


            //20/8/21 **αφαιρεση της if και κανουμε ελεγχο για το αν ειναι εγγεγραμμενος χρηστης στο "δειτε περισσοτερα"
            /*if (usernameCopy != null)
            {
                OpenChildForm(new InsideFormHomeUser());
            }else
            {
                OpenChildForm(new InsideFormHomeGuest());
            }
            */
            OpenChildForm(new InsideFormHome());
            
            
            
        }
        /*
        https://stackoverflow.com/questions/34420599/desktop-screen-overlay-new-form-flicker-issue


        */
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
            if (visitedFormsCopy[0] != "0")
            {
                labelNewAccommodations.Visible = false;
            }

            if (visitedFormsCopy[1] != "0")
            {
                //MessageBox.Show("landmarks");
                labelNewLandmarks.Visible = false;
            }

            if (visitedFormsCopy[2] != "0")
            {
                //MessageBox.Show("Markets");
                labelNewMarkets.Visible = false;
            }

            if (visitedFormsCopy[3] != "0")
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
                    //open one form and close the previous one. delete these lines for multiple forms
                    currentChildForm.Close();
                }
                
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(childForm);
                panelDesktop.Tag = childForm;
                childForm.BringToFront();
                childForm.Size = panelDesktop.Size;
                currentChildForm = childForm;
                childForm.Show();
                //titleChildForm.Text = childForm.Tag.ToString();
                
            

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
            //20/8/21 **αφαιρεση της if και κανουμε ελεγχο για το αν ειναι εγγεγραμμενος χρηστης στο "δειτε περισσοτερα"
            /*if (usernameCopy != null)
            {
                OpenChildForm(new InsideFormHomeUser());
            }
            else
            {
                OpenChildForm(new InsideFormHomeGuest());
            }
             * 
             */
            currentChildForm.Close();
            OpenChildForm(new InsideFormHome());
            Reset();
        }

        private void btnAccommondations_Click(object sender, EventArgs e)
        {
            visitedFormsCopy[0] = "1";
            //20/8/21 **αφαιρεση της if και κανουμε ελεγχο για το αν ειναι εγγεγραμμενος χρηστης στο "δειτε περισσοτερα"
            /*if (usernameCopy != null)
            {
                OpenChildForm(new InsideFormAccommodationsUser());
            }
            else
            {
                OpenChildForm(new InsideFormAccommodationsGuest());
            }
            */
            labelNewAccommodations.Visible = false;

            ActivateButton(sender, RGBColors.color2);
            currentChildForm.Close();
       
            OpenChildForm(new InsideFormAccommodations(usernameCopy));

        }

        private void btnLandmarks_Click(object sender, EventArgs e)
        {
            visitedFormsCopy[1] = "1";
            //20/8/21 **αφαιρεση της if και κανουμε ελεγχο για το αν ειναι εγγεγραμμενος χρηστης στο "δειτε περισσοτερα"
            /*
             * if (usernameCopy != null)
            {
                OpenChildForm(new InsideFormLandmarksUser());
            }
            else
            {
                OpenChildForm(new InsideFormLandmarksGuest());
            }
            */
            labelNewLandmarks.Visible = false;

            ActivateButton(sender, RGBColors.color1);
            currentChildForm.Close();
            OpenChildForm(new InsideFormLandmarks(usernameCopy));



        }



        private void btnMarkets_Click(object sender, EventArgs e)
        {
            visitedFormsCopy[2] = "1";
            //20/8/21 **αφαιρεση της if και κανουμε ελεγχο για το αν ειναι εγγεγραμμενος χρηστης στο "δειτε περισσοτερα"
            /*if (usernameCopy != null)
            {
                OpenChildForm(new InsideFormMarketsUser());
            }
            else
            {
                OpenChildForm(new InsideFormMarketsGuest());
            }
            */
            labelNewMarkets.Visible = false;
            ActivateButton(sender, RGBColors.color3);
            currentChildForm.Close();
            OpenChildForm(new InsideFormMarkets(usernameCopy));




        }

        private void btnEatDrink_Click(object sender, EventArgs e)
        {
            visitedFormsCopy[3] = "1";
            //20/8/21 **αφαιρεση της if και κανουμε ελεγχο για το αν ειναι εγγεγραμμενος χρηστης στο "δειτε περισσοτερα"
            /*
           if (usernameCopy != null)
           {
               //οταν βγαζουμε τις φορμες guest και User αφαιρουμε και τον παρακατω κώδικα
              // OpenChildForm(new InsideFormEatDrinkUser());
           }
           else
           {
              // OpenChildForm(new InsideFormEatDrinkGuest());
           }
           */
            //και το αντικαθιστούμε με το παρακάτω

            labelNewEatDrink.Visible = false;

            ActivateButton(sender, RGBColors.color4);
            currentChildForm.Close();
            
            //OpenChildForm(new plano_karantinas());
           
            OpenChildForm(new InsideFormEatDrink(usernameCopy));

        }

      

        private void OutsideForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Καλωσήρθατε, " + usernameCopy;
        }

       
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (usernameCopy != "Guest")
            {
                String str = "Data Source=tourist_guide.db;Version=3";
                using (SQLiteConnection conn = new SQLiteConnection(str))
                {
                    conn.Open();

                    using (SQLiteCommand command = new SQLiteCommand(conn))
                    {
                        String updateSQL = "UPDATE USERS " +
                                    "SET accommodations = @accommodations, landmarks = @landmarks, " +
                                    "markets = @markets, eatdrink = @eatdrink " +
                                    "WHERE username = @username";

                        command.CommandText = updateSQL;
                        command.Parameters.AddWithValue("@accommodations", visitedFormsCopy[0]);
                        command.Parameters.AddWithValue("@landmarks", visitedFormsCopy[1]);
                        command.Parameters.AddWithValue("@markets", visitedFormsCopy[2]);
                        command.Parameters.AddWithValue("@eatdrink", visitedFormsCopy[3]);
                        command.Parameters.AddWithValue("@username", usernameCopy);
                        command.Prepare();

                        command.ExecuteNonQuery();

                        //



                        //MessageBox.Show(Application.OpenForms.Count.ToString());
                    }
                }
                
            }
            MessageBox.Show("bye bye...");
            this.Close();
            lfCopy.Show();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            visitedFormsCopy[0] = "0";
            visitedFormsCopy[1] = "0";
            visitedFormsCopy[2] = "0";
            visitedFormsCopy[3] = "0";
            //20/8/21 **αφαιρεση της if και κανουμε ελεγχο για το αν ειναι εγγεγραμμενος χρηστης στο "δειτε περισσοτερα"
            /*
             * if (usernameCopy != null)
            {
                OpenChildForm(new InsideFormHomeUser());
            }
            else
            {
                OpenChildForm(new InsideFormHomeGuest());
            }
            */

            labelNewAccommodations.Visible = true;
            labelNewLandmarks.Visible = true;
            labelNewMarkets.Visible = true;
            labelNewEatDrink.Visible = true;

            currentChildForm.Close();
            OpenChildForm(new InsideFormHome());
            Reset();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usernameCopy != "Guest")
            {
                String str = "Data Source=tourist_guide.db;Version=3";
                using (SQLiteConnection conn = new SQLiteConnection(str))
                {
                    conn.Open();
                    using (SQLiteCommand command = new SQLiteCommand(conn))
                    {
                        String updateSQL = "UPDATE USERS " +
                                    "SET accommodations = @accommodations, landmarks = @landmarks, " +
                                    "markets = @markets, eatdrink = @eatdrink " +
                                    "WHERE username = @username";

                        command.CommandText = updateSQL;
                        command.Parameters.AddWithValue("@accommodations", visitedFormsCopy[0]);
                        command.Parameters.AddWithValue("@landmarks", visitedFormsCopy[1]);
                        command.Parameters.AddWithValue("@markets", visitedFormsCopy[2]);
                        command.Parameters.AddWithValue("@eatdrink", visitedFormsCopy[3]);
                        command.Parameters.AddWithValue("@username", usernameCopy);
                        command.Prepare();

                        command.ExecuteNonQuery();

                        //MessageBox.Show(Application.OpenForms.Count.ToString());
                    }
                }
            }
            MessageBox.Show("Bye Bye...");
            Application.Exit();
            //lfCopy.Close();
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
            currentChildForm.Close();
            OpenChildForm(new InsideFormHome());

            Reset();
        }
        private void landmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLandmarks.PerformClick();
        }

        private void αγορέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMarkets.PerformClick();
        }

        private void eatDrinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEatDrink.PerformClick();
        }
    
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            if (usernameCopy != "Guest")
            {
                Calendar cal = new Calendar();
                cal.Show();
            }else
            {
                MessageBox.Show("Παρακαλώ εγγραφτείτε στην εφαρμογή για να έχετε πρόσβαση στις λειτουργίες του Ημερολογίου.");
            }
        }

        private void OutsideForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (lfCopy.Visible == true)
            {
               
            }
            else
            {
                exitToolStripMenuItem.PerformClick();
              
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "tourist_guide.chm");
        }
    }
}
