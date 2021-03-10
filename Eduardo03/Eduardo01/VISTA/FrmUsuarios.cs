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
            Carga();
        }
        void Carga()
        {
            dataGridView1.Rows.Clear();

            using (programacionEntities db = new programacionEntities())
            {
                var Lista = db.UserList.ToList();

                foreach (var iteracion in Lista)
                {

                    dataGridView1.Rows.Add(iteracion.Id,iteracion.NombreUsuario,iteracion.Apellido,iteracion.Edad,iteracion.Pass);
                }
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (programacionEntities db = new programacionEntities()) {

                UserList userList = new UserList();

                userList.NombreUsuario = trexnam.Text;
                userList.Apellido = trexap.Text;
                userList.Edad = (Convert.ToInt32 (Txtedad));
                userList.Pass = txtpassd.Text;
                db.UserList.Add(userList);
                db.SaveChanges();
            
            
            }
            Carga();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (programacionEntities db = new programacionEntities())
            {
                int Eliminar = Convert.ToInt32(txtid.Text);
                UserList userList = db.UserList.Where(x => x.Id == Eliminar).Select(x => x).FirstOrDefault();
                //int Eliminar = Convert.ToInt32(txtid.Text);
                //userList = db.UserList.Find(Eliminar);
                db.UserList.Remove(userList);
                db.SaveChanges();


            }
            Carga();
        }

        private void Buttomact_Click(object sender, EventArgs e)
        {
            try {
            using (programacionEntities db = new programacionEntities())
            {
            //int update = Convert.ToInt32(txtid.Text);
            UserList user = db.UserList.Where(x => x.Id == 3).Select(x => x).FirstOrDefault();
                user.NombreUsuario = trexnam.Text;
                user.Apellido = trexap.Text;
                user.Edad = Convert.ToInt32(Txtedad.Text);
                user.Pass = txtpassd.Text;
                db.SaveChanges();
            }
            }
            catch (Exception ex) {

                MessageBox.Show(ex.ToString());
            }
            Carga();
        }

    }
}
