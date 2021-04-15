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
    public partial class Kilistázás : Form
    {
        DB db;
        string csapatID = "";
        public Kilistázás()
        {
            InitializeComponent();
            db = new DB();
            db.Connection();
            db.csapat_combo_Feltöltés(combo_csapatnev);
        }

        private void btn_tagok_Click(object sender, EventArgs e)
        {
            db.conn_check(db.conn);

            string QUERY_SELECT_tagok = "SELECT CONCAT(csapattagok.vezeteknev,csapattagok.keresztnev) AS tag FROM csapattagok JOIN csapatok ON csapattagok.ID_csapat=csapatok.ID ORDER BY tag ASC";
            
            using (MySqlCommand CMD_SELECT_tagok=new MySqlCommand(QUERY_SELECT_tagok,db.conn))
            {
                try
                {
                    DataTable DT_SELECT_ALL = new DataTable();
                    MySqlDataReader DR_SELECT_ALL = CMD_SELECT_tagok.ExecuteReader();
                    DT_SELECT_ALL.Load(DR_SELECT_ALL);
                    DR_SELECT_ALL.Close();
                    dataGridView1.DataSource = DT_SELECT_ALL;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            
        }

        private void btn_meccsek_Click(object sender, EventArgs e)
        {
            db.conn_check(db.conn);
            string QUERY_SELECT_csapatID = "SELECT ID FROM csapatok WHERE csapatnev=@csapatnev";
            using (MySqlCommand CMD_SELECT_csapatID = new MySqlCommand(QUERY_SELECT_csapatID, db.conn))
            {
                CMD_SELECT_csapatID.Parameters.Add("@csapatnev", MySqlDbType.VarChar).Value = combo_csapatnev.Text.Trim();
                using (MySqlDataReader READER_SELECT_csapatID = CMD_SELECT_csapatID.ExecuteReader())
                {
                    READER_SELECT_csapatID.Read();
                    csapatID = READER_SELECT_csapatID.GetString("ID");
                }
            }
            string QUERY_SELECT_meccsek = "SELECT csapatok.csapatnev AS 'Csapat 1',merkozesek.golok_1 AS 'Csapat 1 Gól',csapatok.csapatnev AS 'Csapat 2',merkozesek.golok_2 AS 'Csapat 2 Gól' FROM csapatok JOIN merkozesek ON csapatok.ID=merkozesek.ID_1_csapat OR csapatok.ID=merkozesek.ID_2_csapat WHERE ID_1_csapat=@csap1 OR ID_2_csapat=@csap2";
            using (MySqlCommand CMD_SELECT_meccsek = new MySqlCommand(QUERY_SELECT_meccsek, db.conn))
            {
                CMD_SELECT_meccsek.Parameters.Add("@csap1",MySqlDbType.Int32).Value =Convert.ToInt32(csapatID);
                CMD_SELECT_meccsek.Parameters.Add("@csap2", MySqlDbType.Int32).Value = Convert.ToInt32(csapatID);
                try
                {
                    DataTable DT_SELECT_ALL = new DataTable();
                    MySqlDataReader DR_SELECT_ALL = CMD_SELECT_meccsek.ExecuteReader();
                    DT_SELECT_ALL.Load(DR_SELECT_ALL);
                    DR_SELECT_ALL.Close();
                    dataGridView1.DataSource = DT_SELECT_ALL;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
