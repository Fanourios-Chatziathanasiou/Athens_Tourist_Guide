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
using System.Text.RegularExpressions;

namespace WinFormsApp3
{

    public partial class Museums : Form
    {
        int querriesffected;
        private int ImageNumber = 26;
        String date;
        String date_now;
        String note;
        public Museums()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }


        private void Slider()
        {
            if (ImageNumber == 30)
            {
                ImageNumber = 26;
            }
            pictureBox1.ImageLocation = @"Sliderimages\" + ImageNumber.ToString() + ".jpg";
            ImageNumber++;
        }

        private void Museums_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            pictureBox1.ImageLocation = @"Sliderimages\" + ImageNumber.ToString() + ".jpg";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Slider();
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
                    //MessageBox.Show(richtextboxesList[0]);
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ExportToDocFile exportToDocFile = new ExportToDocFile();
            exportToDocFile.exportToDesktop(this);

        }

        private void exportBtn1_Click(object sender, EventArgs e)
        {
            ExportToDocFile exportToDocFile = new ExportToDocFile();
            exportToDocFile.exportToDesktop(this);
        }
    }
    }
