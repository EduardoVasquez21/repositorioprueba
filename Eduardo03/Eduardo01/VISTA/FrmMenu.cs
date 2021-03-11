using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eduardo01.VISTA
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void clickParaMasInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercade frm = new FrmAcercade();
            frm.MdiParent = this;
            frm.Show();
        }

        private void arreglosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmvistaUSUARIOvisual frm = new FrmvistaUSUARIOvisual();
            frm.MdiParent = this;
            frm.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void conexionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
