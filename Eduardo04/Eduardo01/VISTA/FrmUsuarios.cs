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
            Clear();
        }

        void Clear()
        {

            txtid.Clear();
            //trexnam.Text = "";
            //trexap.Text = null;
            trexnam.Clear();
            trexap.Clear();
            Txtedad.Clear();
            txtpassd.Clear();

        }
        void Carga()
        {
            dtgListaUsuarios.Rows.Clear();

            using (programacionEntities db = new programacionEntities())
            {
                var Lista = db.UserList.ToList();

                foreach (var iteracion in Lista)
                {

                    dtgListaUsuarios.Rows.Add(iteracion.Id,iteracion.NombreUsuario,iteracion.Apellido,iteracion.Edad,iteracion.Pass);
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
            Clear();
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
            Clear();
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
            Clear();
        }

        private void dtgListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Apellido = dtgListaUsuarios.CurrentRow.Cells[2].Value.ToString();
            String Edad = dtgListaUsuarios.CurrentRow.Cells[3].Value.ToString();
            String Password = dtgListaUsuarios.CurrentRow.Cells[4].Value.ToString();


            txtid.Text = Id;
            trexnam.Text = Nombre;
            trexap.Text = Apellido;
            Txtedad.Text = Edad;
            txtpassd.Text = Password;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
