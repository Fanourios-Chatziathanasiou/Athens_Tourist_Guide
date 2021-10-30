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
    public partial class Calendar : Form
    {
        
       
        List<Button> deletebuttonsList = new List<Button>();
        List<Button> editbuttonsList = new List<Button>();
        List<String> richtextboxesList = new List<String>();
        List<String> datetimestrings = new List<String>();    
        String date, date_now;
        String note;
        int i = 1;
        
        public Calendar()
        {

            InitializeComponent();
            label1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label1.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            displaycomments();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
           
            
            
           
        }

        void displaycomments()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=tourist_guide.db;Version=3"))
            {
                conn.Open();
                i = 1;
                panel1.Controls.Clear();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    String selectSQL = "SELECT username_, date_to_note,datetime_now,note " +
                                        "FROM Notes " +
                                        "WHERE username_ = @username AND date_to_note= @date";

                    
                    date = label1.Text;
                    command.CommandText = selectSQL;
                    command.Parameters.AddWithValue("@username", StaticFieldsClass.usernameCopy);
                    command.Parameters.AddWithValue("@date", date);
                    command.Prepare();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //δημιουργια richtextbox για καθε σχολιο
                            RichTextBox richtxtbox = new RichTextBox();
                            richtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            richtxtbox.Location = new System.Drawing.Point(0, (i - 1) * 198 + (i - 1) * 50);
                            richtxtbox.BackColor = Color.White;
                            richtxtbox.Margin = new Padding(0, 0, 0, 0);
                            richtxtbox.Name = "mytextBox" + i.ToString();
                            richtxtbox.ReadOnly = true;
                            //richtxtbox.Dock = System.Windows.Forms.DockStyle.Top;
                            //richtxtbox.Location = new Point(0, (i - 1) * 198 + 10);
                            richtxtbox.TabIndex = 31;
                            richtxtbox.MaxLength = 53;
                            richtxtbox.AppendText(reader[3].ToString());
                            richtextboxesList.Add(richtxtbox.Text);
                            richtxtbox.Text = "";
                            richtxtbox.AppendText("Username: " + reader[0].ToString() + ",  Ημερομηνία:" + reader[2].ToString() + "\n\n" + "Σχόλιο:\n" + reader[3].ToString());
                            richtxtbox.Height = 198;
                            richtxtbox.Width = 580;
                            
                            //δημιουργια delete button για το κάθε σχόλιο
                            IconButton deletebtn = new IconButton();
                            deletebtn.FlatAppearance.BorderSize = 0;
                            deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            deletebtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
                            deletebtn.IconChar = FontAwesome.Sharp.IconChar.Ban;
                            deletebtn.IconColor = System.Drawing.Color.RoyalBlue;
                            deletebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
                            deletebtn.IconSize = 34;
                            deletebtn.Location = new System.Drawing.Point(546, (i - 1) * 198 + (i - 1) * 50 + 198);
                            deletebtn.Margin = new System.Windows.Forms.Padding(0);
                            deletebtn.Name = "myiconButton1" + i.ToString();
                            deletebtn.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
                            deletebtn.Size = new System.Drawing.Size(34, 34);
                            deletebtn.TabIndex = 31;
                            deletebtn.UseVisualStyleBackColor = true;
                            deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                            deletebtn.FlatAppearance.BorderSize = 1;
                            deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            deletebtn.Click += new EventHandler(deletebtnEvent);


                            //δημιουργια delete button για το κάθε σχόλιο
                            IconButton editbtn = new IconButton();
                            editbtn.FlatAppearance.BorderSize = 0;
                            editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            editbtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
                            editbtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
                            editbtn.IconColor = System.Drawing.Color.RoyalBlue;
                            editbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
                            editbtn.IconSize = 34;
                            editbtn.Location = new System.Drawing.Point(512, (i - 1) * 198 + (i - 1) * 50 + 198);
                            editbtn.Margin = new System.Windows.Forms.Padding(0);
                            editbtn.Name = "myiconButton1" + i.ToString();
                            editbtn.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
                            editbtn.Size = new System.Drawing.Size(34, 34);
                            editbtn.TabIndex = 31;
                            editbtn.UseVisualStyleBackColor = true;
                            editbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                            editbtn.FlatAppearance.BorderSize = 1;
                            editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            editbtn.Click += new EventHandler(editEvent);

                            i++;
                            deletebuttonsList.Add(deletebtn);
                            editbuttonsList.Add(editbtn);
                            datetimestrings.Add(reader[2].ToString());

                            panel1.Controls.Add(richtxtbox);
                            panel1.Controls.Add(deletebtn);
                            panel1.Controls.Add(editbtn);
                        }
                    }
                   
                }  
               
            }
            
        }


        void deletebtnEvent(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=tourist_guide.db;Version=3"))
            {
                conn.Open();

                using (SQLiteCommand deletecommand = new SQLiteCommand(conn))
                {
                    String selectSQL = "DELETE FROM Notes WHERE note =@note AND datetime_now= @date_now AND username_=@username";


                    note = richtextboxesList[deletebuttonsList.IndexOf((Button)sender)];
                    date_now = datetimestrings[deletebuttonsList.IndexOf((Button)sender)];

                    //MessageBox.Show(richtextboxesList[0]);
                    deletecommand.CommandText = selectSQL;
                    deletecommand.Parameters.AddWithValue("@note", note);
                    deletecommand.Parameters.AddWithValue("@date_now", date_now);
                    deletecommand.Parameters.AddWithValue("@username", StaticFieldsClass.usernameCopy);
                    deletecommand.Prepare();
                    deletecommand.ExecuteNonQuery();
                    
                }
                    
            }
            displaycomments();
        }
        void editEvent(object sender, EventArgs e)
        {
            String date_now = datetimestrings[editbuttonsList.IndexOf((Button)sender)];
            String note = richtextboxesList[editbuttonsList.IndexOf((Button)sender)];
            CalendarEdit ce = new CalendarEdit(note,date_now);
            ce.ShowDialog();
            displaycomments();


        }
    }
    
}

    
