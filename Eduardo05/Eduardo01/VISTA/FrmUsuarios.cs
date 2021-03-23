using Eduardo01.DAO;
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
            trexnam.Clear();
            trexap.Clear();
            Txtedad.Clear();
            txtpassd.Clear();

        }
        void Carga()
        {
            dtgListaUsuarios.Rows.Clear();

            ClsDUserList clsDUserList = new ClsDUserList();
            List<UserList> Lista = clsDUserList.cargarDatosUserlist();

            foreach (var iteracion in Lista)
            {

                dtgListaUsuarios.Rows.Add(iteracion.Id, iteracion.NombreUsuario, iteracion.Apellido, iteracion.Edad, iteracion.Pass);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals("")) { 
            ClsDUserList clsDUserList = new ClsDUserList();
            //clsDUserList.SaveDatosUser(trexnam.Text,trexap.Text, Convert.ToInt32(Txtedad.Text),txtpassd.Text);
            UserList userList = new UserList();
            userList.NombreUsuario = trexnam.Text;
            userList.Apellido = trexap.Text;
            userList.Edad = Convert.ToInt32(Txtedad.Text);
            userList.Pass = txtpassd.Text;
            clsDUserList.SaveDatosUser(userList);
        }else{

                ClsDUserList clsDUserList = new ClsDUserList();

                UserList userList = new UserList();
                userList.Id = Convert.ToInt32(txtid.Text);
                userList.NombreUsuario = trexnam.Text;
                userList.Apellido = trexap.Text;
                userList.Edad = Convert.ToInt32(Txtedad.Text);
                userList.Pass = txtpassd.Text;
                clsDUserList.updateUser(userList);

            }
            Carga();
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsDUserList user = new ClsDUserList();
            user.deleteUser(Convert.ToInt32(txtid.Text));
            Carga();
            Clear();
        }

        private void Buttomact_Click(object sender, EventArgs e)
        {

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

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    ClsDUserList clsDUserList = new ClsDUserList();
            
        //    UserList userList = new UserList();
        //    userList.Id = Convert.ToInt32 (txtid.Text);
        //    userList.NombreUsuario = trexnam.Text;
        //    userList.Apellido = trexap.Text;
        //    userList.Edad = Convert.ToInt32(Txtedad.Text);
        //    userList.Pass = txtpassd.Text;
        //    ClsDUserList.updateUser();
        //    Carga();
        //    Clear();
        //}
    }
}
