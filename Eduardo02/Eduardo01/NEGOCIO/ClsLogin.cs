using Eduardo01.DAO;
using Eduardo01.DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eduardo01.NEGOCIO
{
    class ClsLogin
    {
        ClsListaUsuario cls = new ClsListaUsuario;
     
    public int acceso(Login log)
    {
            int estado = 0;
        for (int i = 0; i < cls.users.Length;i++){

            if (log.Usuario.Equals(cls.user[i]) && log.Password.Equals(cls.pass[i])) {
                estado = 1;
            }
            }

        return estado;
    }
}
