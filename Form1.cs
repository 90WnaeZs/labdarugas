using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labdarugas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void csapatHozzáadásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CS_Hozzaadas h = new CS_Hozzaadas();
            h.Show();
        }

        private void csapatMódosításaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CS_Modositas m = new CS_Modositas();
            m.Show();
        }

        private void csapatTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CS_Torles t = new CS_Torles();
            t.Show();
        }

        private void eredményRögzítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eredmény_rögzítés eredm = new Eredmény_rögzítés();
            eredm.Show();
        }

        private void kilistázásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kilistázás k = new Kilistázás();
            k.Show();
        }
    }
}
