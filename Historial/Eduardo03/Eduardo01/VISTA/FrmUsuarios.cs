using Eduardo01.MODEL;
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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (programacionEntities db = new programacionEntities()) {

                UserList userList = new UserList();

                userList.NombreUsuario = trexnam.Text;
                userList.Apellido = trexap.Text;
                userList.Edad = Convert.ToInt32 (Txtedad);
                userList.Pass = txtpassd.Text;
                db.UserList.Add(userList);
                db.SaveChanges();
            
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (programacionEntities db = new programacionEntities())
            {

                UserList userList = new UserList();
                int Eliminar = Convert.ToInt32(trexnam.Text);
                userList = db.UserList.Find(Eliminar);
                db.UserList.Remove(userList);
                db.SaveChanges();


            }
        }
    }
}
