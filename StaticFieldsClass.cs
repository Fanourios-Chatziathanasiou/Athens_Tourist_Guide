using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public static class StaticFieldsClass
    {
        public static string usernameCopy { get; set; }
        public static List<string> visitedForms { get; set; } = new List<string>();

        public static void save_user_data()
        {
            string str = "Data Source=tourist_guide.db;Version=3";
            using (SQLiteConnection conn = new SQLiteConnection(str))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    string updateSQL = "UPDATE USERS " +
                                "SET accommodations = @accommodations, landmarks = @landmarks, " +
                                "markets = @markets, eatdrink = @eatdrink " +
                                "WHERE username = @username";

                    command.CommandText = updateSQL;
                    command.Parameters.AddWithValue("@accommodations", StaticFieldsClass.visitedForms[0]);
                    command.Parameters.AddWithValue("@landmarks", StaticFieldsClass.visitedForms[1]);
                    command.Parameters.AddWithValue("@markets", StaticFieldsClass.visitedForms[2]);
                    command.Parameters.AddWithValue("@eatdrink", StaticFieldsClass.visitedForms[3]);
                    command.Parameters.AddWithValue("@username", StaticFieldsClass.usernameCopy);
                    command.Prepare();

                    command.ExecuteNonQuery();


                }
            }
        }
    }

}

