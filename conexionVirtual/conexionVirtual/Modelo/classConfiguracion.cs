using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;

namespace conexionVirtual.Modelo
{
    class classConfiguracion
    {
        private static string path = null;
        public static string Path
        {
            get { return classConfiguracion.path; }
            set { classConfiguracion.path = value; }
        }
        private static string timagen = null;
        public static string Timagen
        {
            get { return classConfiguracion.timagen; }
            set { classConfiguracion.timagen = value; }
        }
        public static string ruta = null;
     
        Controlador.classFormularios frm = new Controlador.classFormularios();
        public bool preinstalado(string ruta)
        {
            bool val = false;
            try
            {
                //Validamos que no exista el directorio donde vamos a crear la instalacion
                //Si no existe creamos la carpeta
                if (System.IO.Directory.Exists(ruta))
                {
                    creaDirectorios(ruta);
                }
                else
                {
                    System.IO.Directory.CreateDirectory(ruta + "/APP");
                    creaDirectorios(ruta);
                }

                Modelo.classConfiguracion.Timagen = "bien.png";
                frm.activaComponente("pbRutas");
            }
            catch
            {
                Modelo.classConfiguracion.Timagen = "mal.png";
                frm.activaComponente("pbRutas");
            }
            return val;
        }
        //Funcion para copiar la aplicacion a la ruta final
        public static bool copElementos(string ruta, string tipo)
        {
            bool res = false;
            string[] aFiles = System.IO.Directory.GetFiles(Modelo.classConfiguracion.Path + tipo);
            //leemos y copiamos los archivos al directorio de instalacion
            foreach (string nFile in aFiles)
            {
                string nombreArchivo = System.IO.Path.GetFileName(nFile);
             
                System.IO.File.Copy(nFile, ruta + "/" + nombreArchivo, true);
            }
            return res;
        }

        public static bool creaDirectorios(string ruta)
        {
            bool resp = false;
            //Directorio para Tomar Adendas
            System.IO.Directory.CreateDirectory(ruta + "/ADDENDA");
            //Directorio para la Aplicacion
            System.IO.Directory.CreateDirectory(ruta + "/APP");
            copElementos(ruta + "/APP", "APP");
            //Directorio para depositar archivos
            System.IO.Directory.CreateDirectory(ruta + "/ARCHIVOS");
            System.IO.Directory.CreateDirectory(ruta + "/ARCHIVOS/CFD");
            System.IO.Directory.CreateDirectory(ruta + "/ARCHIVOS/NOMINA");
            System.IO.Directory.CreateDirectory(ruta + "/ARCHIVOS/TXT");
            System.IO.Directory.CreateDirectory(ruta + "/ARCHIVOS/VALES");
            //Definimos directorios de las carpetas para CFDI cancelados
            System.IO.Directory.CreateDirectory(ruta + "/CANCELADOS");
            System.IO.Directory.CreateDirectory(ruta + "/CANCELADOS/FACTURAS");
            System.IO.Directory.CreateDirectory(ruta + "/CANCELADOS/NOMINA");
            System.IO.Directory.CreateDirectory(ruta + "/CANCELADOS/NOTA CARGO");
            System.IO.Directory.CreateDirectory(ruta + "/CANCELADOS/NOTA CREDITO");
            System.IO.Directory.CreateDirectory(ruta + "/CANCELADOS/VALES");
            //Directorio para hacer cancelaciones
            System.IO.Directory.CreateDirectory(ruta + "/ADDENDA/CANCELAR");
            //Directorio para certificados de Emisor
            System.IO.Directory.CreateDirectory(ruta + "/CERT");
            //Directorio para txt de comentarios
            System.IO.Directory.CreateDirectory(ruta + "/COMENTARIOS");
            //Directorio de archivos enviados 
            System.IO.Directory.CreateDirectory(ruta + "/ENVIADOS");
            System.IO.Directory.CreateDirectory(ruta + "/ENVIADOS/FACTURAS");
            System.IO.Directory.CreateDirectory(ruta + "/ENVIADOS/NOMINA");
            System.IO.Directory.CreateDirectory(ruta + "/ENVIADOS/NOTA CARGO");
            System.IO.Directory.CreateDirectory(ruta + "/ENVIADOS/NOTA CREDITO");
            System.IO.Directory.CreateDirectory(ruta + "/ENVIADOS/VALES");
            //Directorio de archivos con error
            System.IO.Directory.CreateDirectory(ruta + "/ERROR");
            //Directorio para log de archivos con error o mal estructurados
            System.IO.Directory.CreateDirectory(ruta + "/LOG");
            //Directorio para los logos de los emisores
            System.IO.Directory.CreateDirectory(ruta + "/LOGO");
            //Directorio de PDF
            System.IO.Directory.CreateDirectory(ruta + "/PDF");
            System.IO.Directory.CreateDirectory(ruta + "/PDF/FACTURAS");
            System.IO.Directory.CreateDirectory(ruta + "/PDF/NOMINA");
            System.IO.Directory.CreateDirectory(ruta + "/PDF/NOTA CARGO");
            System.IO.Directory.CreateDirectory(ruta + "/PDF/NOTA CREDITO");
            System.IO.Directory.CreateDirectory(ruta + "/PDF/VALES");
            //Directorio para XML Generados
            System.IO.Directory.CreateDirectory(ruta + "/XML");
            System.IO.Directory.CreateDirectory(ruta + "/XML/FACTURAS");
            System.IO.Directory.CreateDirectory(ruta + "/XML/NOMINA");
            System.IO.Directory.CreateDirectory(ruta + "/XML/NOTA CARGO");
            System.IO.Directory.CreateDirectory(ruta + "/XML/NOTA CREDITO");
            System.IO.Directory.CreateDirectory(ruta + "/XML/VALES");
            //Directorio para archivos XSLT
            System.IO.Directory.CreateDirectory(ruta + "/XSLT");
            copElementos(ruta + "/XSLT", "XSLT");
            System.IO.Directory.CreateDirectory(ruta + "/XSLT/3.2");
            copElementos(ruta + "/XSLT/3.2", "/XSLT/3.2");
            return resp;
        }

    }
}
