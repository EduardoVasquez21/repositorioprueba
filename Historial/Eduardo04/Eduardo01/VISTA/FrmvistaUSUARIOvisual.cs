using Eduardo01.DAO;
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
    public partial class FrmvistaUSUARIOvisual : Form
    {
        public FrmvistaUSUARIOvisual()
        {
            InitializeComponent();
        }

        private void FrmvistaUSUARIOvisual_Load(object sender, EventArgs e)
        {
            ClsListaUsuario cls = new ClsListaUsuario();

            foreach (var iteracion in cls.user)
            {
                dataGridView1.Rows.Add(iteracion.ToString());

            }
        }
    }
}
