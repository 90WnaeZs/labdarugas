using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Labdarugas
{
    public partial class CS_Hozzaadas : Form
    {
        DB db;
        string csapatID = "";

        public CS_Hozzaadas()
        {
            InitializeComponent();
            db = new DB();
            db.Connection();
            db.csapat_combo_Feltöltés(cmb_csapat);
        }

        private void btn_csapat_hozzaad_Click(object sender, EventArgs e)
        {
            db.conn_check(db.conn);

            string QUERY_INSERT_csapat = "INSERT INTO csapatok (csapatnev,osztaly) VALUES (@csapatnev,@osztaly)";

            using (MySqlCommand CMD_INSERT_csapat=new MySqlCommand(QUERY_INSERT_csapat,db.conn))
            {
                CMD_INSERT_csapat.Parameters.Add("@csapatnev", MySqlDbType.VarChar).Value = tbx_csapatnev.Text.Trim();
                CMD_INSERT_csapat.Parameters.Add("@osztaly", MySqlDbType.VarChar).Value = tbx_osztaly.Text.Trim();

                if (CMD_INSERT_csapat.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("Sikeres hozzáadás!");
                }
                else
                {
                    MessageBox.Show("Nem sikerült a hozzáadás!");
                }
            }
            db.conn.Close();
        }

        private void btn_tag_hozzaadas_Click(object sender, EventArgs e)
        {
            db.conn_check(db.conn);
            string QUERY_SELECT_csapatID = "SELECT ID FROM csapatok WHERE csapatnev=@csapatnev";
            using (MySqlCommand CMD_SELECT_csapatID = new MySqlCommand(QUERY_SELECT_csapatID, db.conn))
            {
                CMD_SELECT_csapatID.Parameters.Add("@csapatnev", MySqlDbType.VarChar).Value = cmb_csapat.Text.Trim();
                MySqlDataReader READER_SELECT_csapatID = CMD_SELECT_csapatID.ExecuteReader();
                READER_SELECT_csapatID.Read();
                csapatID = READER_SELECT_csapatID.GetString("ID");
                READER_SELECT_csapatID.Close();
            }

            string QUERY_INSERT_tag = "INSERT INTO csapattagok (vezeteknev,keresztnev,szuletesi_datum,ID_csapat) VALUES (@veznev,@kernev,@szuldatum,@csapatID)";

            using (MySqlCommand CMD_INSERT_tag = new MySqlCommand(QUERY_INSERT_tag, db.conn))
            {
                CMD_INSERT_tag.Parameters.Add("@veznev", MySqlDbType.VarChar).Value = tbx_veznev.Text.Trim();
                CMD_INSERT_tag.Parameters.Add("@kernev", MySqlDbType.VarChar).Value = tbx_kernev.Text.Trim();
                CMD_INSERT_tag.Parameters.Add("@szuldatum", MySqlDbType.Date).Value = dateTimePicker1.Value;
                CMD_INSERT_tag.Parameters.Add("@csapatID", MySqlDbType.Int32).Value = Convert.ToInt32(csapatID);

                if (CMD_INSERT_tag.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sikeres hozzáadás!");
                }
                else
                {
                    MessageBox.Show("Nem sikerült a hozzáadás!");
                }
            }
            db.conn.Close();
        }
    }
}
