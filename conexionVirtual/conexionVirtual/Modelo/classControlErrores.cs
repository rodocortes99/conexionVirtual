using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace conexionVirtual.Modelo
{    
    class classControlErrores
    {
        private static string nombreErrror = null;
        public static string NombreErrror
        {
            get { return classControlErrores.nombreErrror; }
            set { classControlErrores.nombreErrror = value; }
        }
    }
}
