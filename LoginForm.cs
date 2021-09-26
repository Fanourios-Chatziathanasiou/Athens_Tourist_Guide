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

namespace WinFormsApp3
{
    public partial class LoginForm : Form
    {
        private String username;
        private String password;
        public List<String> visitedForms = new List<String>();
        private OutsideForm of;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("Username and Password both required!!");
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


                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            visitedForms.Add(reader[2].ToString());
                            visitedForms.Add(reader[3].ToString());
                            visitedForms.Add(reader[4].ToString());
                            visitedForms.Add(reader[5].ToString());

                            this.Hide();
                            MessageBox.Show("Welcome " + username.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username and/or Password");
                            return;
                        }
                    }
                }
            }

            of = new OutsideForm(this ,visitedForms, username: username);
            of.ShowDialog();


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            string[] x = { "0", "0", "0", "0" };
            visitedForms = new List<String>(x);
            OutsideForm of = new OutsideForm(this ,visitedForms);
            this.Hide();
            of.ShowDialog();
        }
    }
}
