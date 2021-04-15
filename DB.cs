using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Labdarugas
{
    class DB
    {
        public MySqlConnection conn;
        public void conn_check(MySqlConnection dbcheck)
        {
            if (dbcheck.State == ConnectionState.Closed)
            {
                dbcheck.Open();
            }
        }
        public void Connection()
        {
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.Database = "labdarugas";
            conn_string.UserID = "root";
            conn_string.Password = "";

            conn = new MySqlConnection(conn_string.ToString());

            conn.Open();
        }

        public void csapat_combo_Feltöltés(ComboBox csapat)
        {
            conn_check(this.conn);
            string QUERY_SELECT_csapatnev = "SELECT DISTINCT(csapatnev) FROM csapatok";
            using (MySqlCommand CMD_SELECT_csapatnev = new MySqlCommand(QUERY_SELECT_csapatnev, this.conn))
            {
                MySqlDataReader READER_SELECT_csapatnev = CMD_SELECT_csapatnev.ExecuteReader();
                while (READER_SELECT_csapatnev.Read())
                {
                    csapat.Items.Add(READER_SELECT_csapatnev.GetString("csapatnev"));
                }
                READER_SELECT_csapatnev.Close();
            }
            this.conn.Close();
        }

        public void osztaly_combo_Feltöltés(ComboBox csapat,ComboBox osztaly)
        {
            conn_check(this.conn);
            if (csapat.Text != "")
            {
                string QUERY_SELECT_osztaly = "SELECT osztaly FROM csapatok WHERE csapatnev=@csapatnev";
                using (MySqlCommand CMD_SELECT_osztaly = new MySqlCommand(QUERY_SELECT_osztaly, this.conn))
                {
                    CMD_SELECT_osztaly.Parameters.Add("@csapatnev", MySqlDbType.VarChar).Value = csapat.Text.Trim();
                    MySqlDataReader READER_SELECT_osztaly = CMD_SELECT_osztaly.ExecuteReader();
                    while (READER_SELECT_osztaly.Read())
                    {
                        osztaly.Text = READER_SELECT_osztaly.GetString("osztaly");
                    }
                    READER_SELECT_osztaly.Close();
                }
                this.conn.Close();
            }
        }
    }
}
