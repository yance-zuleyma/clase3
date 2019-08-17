using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidad;

namespace CapaDatos
{
    public class datos
    {
        public int login (entidad obj)

       {
           int n;
           string usuario, contraseña;
           usuario = obj.usuario;
           contraseña = obj.contraseña;

           if (usuario == "zule")
           {
               if (contraseña == "believe")
               {
                   n = 1;
               }
               else
               {
                   n = 2;
               }
           }
           else
           {
               n=2;
           }

           return n;
            
       }
    }
}
