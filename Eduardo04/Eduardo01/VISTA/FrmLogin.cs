using Eduardo01.DOMINIO;
using Eduardo01.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eduardo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Usuario = txtUser.Text;
            log.Usuario = txtPassword.Text;

            ClsLogin clsL = new ClsLogin();

           int variabledeevaluacion= clsL.acceso(log);
            if (variabledeevaluacion==1) {

                MessageBox.Show("WELCOME");
            }
            else {
                MessageBox.Show("FALSE");
            }
        }
    }
}
