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
    public partial class Eredmény_rögzítés : Form
    {
        DB db;
        string csapatID_1 = "";
        string csapatID_2 = "";
        public Eredmény_rögzítés()
        {
            InitializeComponent();
            db = new DB();
            db.Connection();
            db.csapat_combo_Feltöltés(combo_csapat1);
            db.csapat_combo_Feltöltés(combo_csapat2);
        }

        private void btn_Rogzit_Click(object sender, EventArgs e)
        {
            db.conn_check(db.conn);

            string QUERY_SELECT_csapatID_1 = "SELECT ID FROM csapatok WHERE csapatnev=@csapnev1";
            string QUERY_SELECT_csapatID_2 = "SELECT ID FROM csapatok WHERE csapatnev=@csapnev2";
            string QUERY_INSERT_eredmény = "INSERT INTO merkozesek(ID_1_csapat,ID_2_csapat,golok_1,golok_2) VALUES (@csap1,@csap2,@g1,@g2)";

            using (MySqlCommand CMD_SELECT_csapatID_1 = new MySqlCommand(QUERY_SELECT_csapatID_1, db.conn))
            using (MySqlCommand CMD_SELECT_csapatID_2 = new MySqlCommand(QUERY_SELECT_csapatID_2, db.conn))
            using (MySqlCommand CMD_INSERT_eredmény=new MySqlCommand(QUERY_INSERT_eredmény,db.conn))
            {
                CMD_SELECT_csapatID_1.Parameters.Add("@csapnev1", MySqlDbType.VarChar).Value = combo_csapat1.Text;
                MySqlDataReader READER_SELECT_csapatID_1 = CMD_SELECT_csapatID_1.ExecuteReader();
                READER_SELECT_csapatID_1.Read();
                csapatID_1 = READER_SELECT_csapatID_1.GetString("ID");
                READER_SELECT_csapatID_1.Close();

                CMD_SELECT_csapatID_2.Parameters.Add("@csapnev2", MySqlDbType.VarChar).Value = combo_csapat2.Text;
                MySqlDataReader READER_SELECT_csapatID_2 = CMD_SELECT_csapatID_2.ExecuteReader();
                READER_SELECT_csapatID_2.Read();
                csapatID_2 = READER_SELECT_csapatID_2.GetString("ID");
                READER_SELECT_csapatID_2.Close();

                CMD_INSERT_eredmény.Parameters.Add("@csap1", MySqlDbType.Int32).Value = Convert.ToInt32(csapatID_1);
                CMD_INSERT_eredmény.Parameters.Add("@csap2", MySqlDbType.Int32).Value = Convert.ToInt32(csapatID_2);
                CMD_INSERT_eredmény.Parameters.Add("@g1", MySqlDbType.Int32).Value = Convert.ToInt32(num_gol1.Value);
                CMD_INSERT_eredmény.Parameters.Add("@g2", MySqlDbType.Int32).Value = Convert.ToInt32(num_gol2.Value);

                if(CMD_INSERT_eredmény.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("Sikeres rögzítés");
                }
                else
                {
                    MessageBox.Show("Sikertelen rögzítés");
                }
            }
        }
    }
}
