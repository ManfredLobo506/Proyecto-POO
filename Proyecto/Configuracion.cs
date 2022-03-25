using System;
using System.Collections.Generic;
using System.Text;

namespace Capa1Presentacion
{
   public class Configuracion
    {

        //realizamos la conexion de la aplicacion con la base de datos
      public static string getConnetionString
        {
            get
            {
                return Properties.Settings.Default.ConnetionString;
            }
        }
    }
}
