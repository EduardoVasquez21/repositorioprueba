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
       

        public int acceso(Login log)
        {
            int estado = 0;
            if (log.Usuario.Equals("Eduardo") && log.Password.Equals("123")) {
                estado = 1;
            }
            

                return estado;
    }
}
