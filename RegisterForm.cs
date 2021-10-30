using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


//na prosthesoume email sthn vash kai na kanoume to insert
namespace WinFormsApp3
{
    public partial class RegisterForm : Form
    {
        private String username;
        private String password;
        private String email;
        public RegisterForm()
        {
            InitializeComponent();
        }
        //Register Button
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
        private void button1_Click(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;
            email = textBoxEmail.Text;

            //Ckecks if fields are filled
            if (username.Length == 0 || password.Length == 0 || email.Length == 0)
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε όλα τα πεδία.");
                return;
            }

            //Checks if email is valid
            if (!Regex.Match(textBoxEmail.Text, "^[α-ωΑ-Ωa-zA-Z0-9]+[@][α-ωΑ-Ωa-zA-Z]+[.][α-ωΑ-Ωa-zA-Z]+$").Success) {
                MessageBox.Show("Μη έγκυρη μορφή email.");
                return;
            }

            

            String str = "Data Source=tourist_guide.db;Version=3";

            //Creates a new connection
            using (SQLiteConnection conn = new SQLiteConnection(str))
            {
                //open it
                conn.Open();

                //Creates a new command object
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    String selectSQL = "SELECT username FROM Users WHERE username = @username";

                    //fills it with command
                    command.CommandText = selectSQL;
                    command.Parameters.AddWithValue("@username", username);
                    command.Prepare();

                    
                    //Creates reader object to read database data
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        //Checks if username or password is allready in use
                        if (reader.Read())
                        {
                            MessageBox.Show("Το όνομα Χρήστη υπάρχει ήδη.");
                            return;
                        }else if (username.ToUpper() == "GUEST")
                        {
                            MessageBox.Show("Το όνομα Χρήστη \"Guest\" δεν μπορει να χρησιμοποιηθεί.");
                            return;
                        }
                    } 
                }


                //Creates a new command object
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    String selectSQL = "SELECT email FROM Users WHERE email = @email";

                    //fills it with command
                    command.CommandText = selectSQL;
                    command.Parameters.AddWithValue("@email", email);
                    command.Prepare();


                    //Creates reader object to read database data
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        //Checks if username or password is allready in use
                        if (reader.Read())
                        {
                            MessageBox.Show("Το email που εισάγατε υπάρχει ήδη.");
                            return;
                        }
                    }
                }


                //Now we insert the data in database
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    String insertSQL = "INSERT INTO Users (username, password, email,accommodations, landmarks, markets, eatdrink) " +
                        "VALUES (@username,@password,@email, 0, 0, 0, 0)";

                    command.CommandText = insertSQL;
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);    
                    command.Prepare();

                    command.ExecuteNonQuery();
                }
               
            }
            MessageBox.Show("Επιτυχής εγγραφή.Μπορείτε να εισέλθετε με Username: "+username);
            this.Close();
        }
    }
}
