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
    public partial class CS_Torles : Form
    {
        DB db;
        public CS_Torles()
        {
            InitializeComponent();
            db = new DB();
            db.Connection();
            db.csapat_combo_Feltöltés(cmb_csapatnev);
            db.osztaly_combo_Feltöltés(cmb_csapatnev,cmb_osztaly);
        }

        private void btn_csapat_delete_Click(object sender, EventArgs e)
        {
            db.conn_check(db.conn);
            string QUERY_DELETE_csapat = "DELETE FROM csapatok WHERE csapatnev=@csapnev";
            using (MySqlCommand CMD_DELETE_csapat = new MySqlCommand(QUERY_DELETE_csapat, db.conn))
            {
                CMD_DELETE_csapat.Parameters.Add("@csapnev", MySqlDbType.VarChar).Value = cmb_csapatnev.Text.Trim();
                if (CMD_DELETE_csapat.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("Sikeres törlés");
                }
                else
                {
                    MessageBox.Show("Nem sikerült a törlés");
                }
            }

        }

        private void cmb_csapatnev_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.osztaly_combo_Feltöltés(cmb_csapatnev, cmb_osztaly);
        }
    }
}
