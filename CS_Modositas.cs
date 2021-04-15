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
    public partial class CS_Modositas : Form
    {
        DB db;
        string csapatnev = "";
        string osztaly = "";
        string csapatID = "";
       
        
        public CS_Modositas()
        {
            InitializeComponent();
            db = new DB();
            db.Connection();
            db.csapat_combo_Feltöltés(cmb_csapatnev);
            db.osztaly_combo_Feltöltés(cmb_csapatnev,cmb_osztaly);
        }

        private void btn_csapat_modosit_Click(object sender, EventArgs e)
        {
            db.conn_check(db.conn);
            string QUERY_UPDATE_csapat = "UPDATE csapatok SET csapatnev=@csapatnev, osztaly=@osztaly, osszpontszam=@osszpont WHERE ID=@id";

            using (MySqlCommand CMD_UPDATE_csapat=new MySqlCommand(QUERY_UPDATE_csapat,db.conn))
            {
                CMD_UPDATE_csapat.Parameters.Add("@csapatnev",MySqlDbType.VarChar).Value =cmb_csapatnev.Text.Trim();
                CMD_UPDATE_csapat.Parameters.Add("@osztaly", MySqlDbType.VarChar).Value = cmb_csapatnev.Text.Trim();
                CMD_UPDATE_csapat.Parameters.Add("@osszpont", MySqlDbType.Int32).Value = num_osszpont.Value;
                CMD_UPDATE_csapat.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(csapatID);

                if (CMD_UPDATE_csapat.ExecuteNonQuery()>1)
                {
                    MessageBox.Show("Sikeres módosítás!");
                }
                else
                {
                    MessageBox.Show("Nem sikerült a módosítás!");
                    MessageBox.Show(csapatnev.Trim()+" "+osztaly.Trim());
                }
            }
        }

        private void cmb_csapatnev_SelectedIndexChanged(object sender, EventArgs e)
        {
            csapatnev = cmb_csapatnev.Text;
            db.csapat_combo_Feltöltés(cmb_csapatnev);
            db.osztaly_combo_Feltöltés(cmb_csapatnev, cmb_osztaly);
            db.conn_check(db.conn);

            string QUERY_SELECT_csapatID = "SELECT ID FROM csapatok WHERE csapatnev=@csapatnev";
            using (MySqlCommand CMD_SELECT_csapatID = new MySqlCommand(QUERY_SELECT_csapatID, db.conn))
            {
                CMD_SELECT_csapatID.Parameters.Add("@csapatnev", MySqlDbType.VarChar).Value = cmb_csapatnev.Text.Trim();
                using (MySqlDataReader READER_SELECT_csapatID = CMD_SELECT_csapatID.ExecuteReader())
                {
                    READER_SELECT_csapatID.Read();
                    csapatID = READER_SELECT_csapatID.GetString("ID");
                }
            }
        }

        private void cmb_osztaly_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_osztaly_TextChanged(object sender, EventArgs e)
        {
            osztaly = cmb_osztaly.Text;
        }
    }
}
