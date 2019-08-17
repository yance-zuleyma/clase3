using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class negocio
    {
        datos dts = new datos();

     public int N_login(entidad obj)

     {
         return dts.login(obj);
    }
   

    }
        

}


