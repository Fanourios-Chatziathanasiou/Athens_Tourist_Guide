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
    
    public partial class CalendarEdit : Form
    {
        int querriesAffected;
        String editNote,originalNote,dt_now;
        String username = "kapsos";
        public CalendarEdit(String note, String date_now)
        {
            InitializeComponent();
            richTextBox1.Text = note;
            originalNote = note;
            dt_now = date_now;
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=tourist_guide.db;Version=3"))
            {
                conn.Open();

                using (SQLiteCommand editcommand = new SQLiteCommand(conn))
                {
                    String selectSQL = "UPDATE Notes SET note = @editNote WHERE note = @originalNote AND username_=@username AND datetime_now=@datetime_now ";

                    
                    editNote = richTextBox1.Text;
                    //MessageBox.Show(richtextboxesList[0]);
                    editcommand.CommandText = selectSQL;
                    editcommand.Parameters.AddWithValue("@editNote", editNote);
                    editcommand.Parameters.AddWithValue("@originalNote", originalNote);
                    editcommand.Parameters.AddWithValue("@username", username);
                    editcommand.Parameters.AddWithValue("@datetime_now", dt_now);
                    editcommand.Prepare();
                    querriesAffected=editcommand.ExecuteNonQuery();
                    
                    if (querriesAffected > 0)
                    {
                        MessageBox.Show("Επιτυχής καταχώρηση στο ημερολόγιο!");
                    }
                    else if (querriesAffected == 0)
                    {
                        MessageBox.Show("Ανεπιτυχής Καταχώρηση.");
                    }
                }

            }
        }
    }
}
