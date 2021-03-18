using Eduardo01.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eduardo01.DAO
{
    class ClsDUserList
    {
        public List<UserList> cargarDatosUserlist() {
            List<UserList> Lista;


            using (programacionEntities db = new programacionEntities())
            {
                Lista = db.UserList.ToList();

               
            }
            return Lista;
         }

        //public void SaveDatosUser(String Nombre, String Apellido, int Edad, String Pass)
        //{
        //    try
        //    {
        //        using (programacionEntities db = new programacionEntities())
        //        {

        //            UserList userList = new UserList();

        //            userList.NombreUsuario = Nombre;
        //            userList.Apellido = Apellido;
        //            userList.Edad = Edad;
        //            userList.Pass = Pass;
        //            db.UserList.Add(userList);
        //            db.SaveChanges();

        //            MessageBox.Show("Save");
        //        }
        //    }
        //    catch (Exception EX)
        //    {
        //        MessageBox.Show(EX.ToString());
        //    }


        //}


        public void SaveDatosUser(UserList user)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {

                    UserList userList = new UserList();

                    userList.NombreUsuario = user.NombreUsuario;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;
                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Save");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }


        }

        public void deleteUser(int iD)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int Eliminar = Convert.ToInt32(iD);
                    UserList userList = db.UserList.Where(x => x.Id == Eliminar).Select(x => x).FirstOrDefault();
                    //int Eliminar = Convert.ToInt32(txtid.Text);
                    //userList = db.UserList.Find(Eliminar);
                    db.UserList.Remove(userList);
                    db.SaveChanges();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }

        public void updateUser(UserList user)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int update = Convert.ToInt32(user.Id);
                    UserList userList = db.UserList.Where(x => x.Id == 3).Select(x => x).FirstOrDefault();


                    userList.NombreUsuario = user.NombreUsuario;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
