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
using WinFormsApp3;

namespace WinFormsApp3
{
    public partial class LoginForm : Form
    {
        private String username;
        private String password;
       // public List<String> visitedForms = new List<String>();
        private OutsideForm of;
        public LoginForm()
        {
            InitializeComponent();
        }

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
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;

            //Ckecks if fields are filled
            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Το όνομα χρήστη και ο κωδικός είναι υποχρεωτικά πεδία!!");
                return;
            }

            String str = "Data Source=tourist_guide.db;Pooling=True;Version=3";

            using (SQLiteConnection conn = new SQLiteConnection(str))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    String selectSQL = "SELECT username, password, accommodations, landmarks, markets, eatdrink " +
                                "FROM Users " +
                                "WHERE username = @username AND password = @password";

                    command.CommandText = selectSQL;
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Prepare();

                    StaticFieldsClass.visitedForms = new List<string>();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) { 
                               StaticFieldsClass.visitedForms.Add(reader[2].ToString());
                               StaticFieldsClass.visitedForms.Add(reader[3].ToString());
                               StaticFieldsClass.visitedForms.Add(reader[4].ToString());
                               StaticFieldsClass.visitedForms.Add(reader[5].ToString());



                                this.Hide();
                                MessageBox.Show("Καλωσήρθατε " + username.ToString());
                        }
                        else
                        {
                                 MessageBox.Show("Εσφαλμένο Όνομα Χρήστη και/ή Κωδικός");
                                 return;
                        }
                    }
                }
            }
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            of = new OutsideForm(this ,username);
            of.ShowDialog();
            textBoxUsername.Focus();


        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {

            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            StaticFieldsClass.visitedForms = new List<string> { "0", "0", "0", "0"};
            OutsideForm of = new OutsideForm(this); 
            this.Hide();
            of.Show();
            textBoxUsername.Focus();

        }
    }
}
