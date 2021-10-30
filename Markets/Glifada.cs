using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using FontAwesome.Sharp;


namespace WinFormsApp3
{
    
    public partial class Glifada : Form
    {
        int querriesffected;
        
        String date;
        String date_now;
        String note;
        public Glifada()
        {
            InitializeComponent();
            

        }


       
        private void Glifada_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=tourist_guide.db;Version=3"))
            {
                conn.Open();

                using (SQLiteCommand insertcommand = new SQLiteCommand(conn))
                {
                    String selectSQL = "INSERT INTO Notes VALUES (@username_,@date_to_note,@datetime_now,@note)";
                    DateTime dtnow = DateTime.Now;
                    date_now = dtnow.ToString();
                    DateTime dt = DateTime.Now;
                    date = dt.ToShortDateString();
                    note = richTextBox1.Text;
            
                    insertcommand.CommandText = selectSQL;
                    insertcommand.Parameters.AddWithValue("@username_", StaticFieldsClass.usernameCopy);
                    insertcommand.Parameters.AddWithValue("@date_to_note", date);
                    insertcommand.Parameters.AddWithValue("@datetime_now", date_now);
                    insertcommand.Parameters.AddWithValue("@note", note);
                    insertcommand.Prepare();
                    querriesffected = insertcommand.ExecuteNonQuery();
                     
                }
                

            }
            if (querriesffected > 0)
            {
                MessageBox.Show("Επιτυχής καταχώρηση στο ημερολόγιο!");
            }
            else if (querriesffected == 0)
            {
                MessageBox.Show("Ανεπιτυχής Καταχώρηση.");
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                iconButton1.Enabled = true;
            }
            else
            {
                iconButton1.Enabled = false;
            }
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Enabled = true;
        }


        private void exportBtn1_Click(object sender, EventArgs e)
        {
            ExportToDocFile exportToDocFile = new ExportToDocFile();
            exportToDocFile.exportToDesktop(this);
        }
    }

}
