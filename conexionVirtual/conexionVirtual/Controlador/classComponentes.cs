using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Diagnostics;
using System.Configuration;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace conexionVirtual.Controlador
{    
    class classComponentes
    {
        private static bool framework;
        public static bool Framework
        {
            get { return classComponentes.framework; }
            set { classComponentes.framework = value; }
        }
        private static bool crystal;
        public static bool Crystal
        {
            get { return classComponentes.crystal; }
            set { classComponentes.crystal = value; }
        }
        Modelo.classConfiguracion conf = new Modelo.classConfiguracion();
        Controlador.classFormularios frm = new classFormularios();
        Modelo.classAcceso acceso = new Modelo.classAcceso();

        public void softComponentes(string ruta)
        {
            crystal = false;
            framework = false;
            #region rutas
            conf.preinstalado(ruta);
            #endregion
            #region componentes
            try
            {
                complementos();
                if (!framework)
                {
                    Modelo.classConfiguracion.Timagen = "mal.ico";
                    frm.activaComponente("pbFramework");
                    
                    if (MessageBox.Show("Esta seguro que desea descargar Framework??", "Framework", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process.Start(ConfigurationManager.AppSettings["rutaFramework"].ToString());
                    }
                                                      
                }
                if (!crystal)
                {
                    Modelo.classConfiguracion.Timagen = "mal.ico";
                    frm.activaComponente("pbCrystal");                                                                          
                    if (MessageBox.Show("Esta seguro que desea descargar Crystal Reports??", "Crystal Reports", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process.Start(ConfigurationManager.AppSettings["rutaCrystal"].ToString());
                    }                                                  
                }                         
            }
            catch
            {
            }
            #endregion
            #region conectividad
            try
            {
                if (acceso.conectividad("http://virtualcfdi.dyndns.org:9000/VirtualCFDIWS/WSTimbreVirtual.asmx"))
                {
                    Modelo.classConfiguracion.Timagen = "bien.ico";
                }
                else
                {
                    Modelo.classConfiguracion.Timagen = "mal.ico";
                }
                frm.activaComponente("pbPruebas");
            }
            catch
            {
            }
            
            try
            {
                if (acceso.conectividad("http://www.timbrevirtual.com/VirtualCFDIWS/WSTimbreVirtual.asmx"))
                {
                    Modelo.classConfiguracion.Timagen = "bien.ico";
                    frm.activaComponente("pbProduccion");
                }
                else
                {
                    Modelo.classConfiguracion.Timagen = "mal.ico";
                }
                frm.activaComponente("pbProduccion");
            }
            catch
            {
            }
            #endregion
            #region Tarea programada
            if (MessageBox.Show("Desea Agregar tarea programada al conector??", "Conector", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Vista.tarea tarea = new Vista.tarea();
               
                tarea.FormBorderStyle = FormBorderStyle.FixedSingle;
               
                tarea.Show();
            }
            #endregion 
        }
   
        //Funcion para crear directorios
        public static bool creaDirectorios()
        {
            bool resp = false;
            return resp;
        }
        //Funcion para verificar que esten instalados los elementos necesarios
        public bool complementos()
        {
            bool resp = false;
            String sRegKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            RegistryKey Keys = Registry.LocalMachine.OpenSubKey(sRegKey);
            foreach (String sNombreKey in Keys.GetSubKeyNames())
            {
                RegistryKey Key = Keys.OpenSubKey(sNombreKey);
                if (Key.GetValue("DisplayName") != null)
                {
                    string nomComponente = Key.GetValue("DisplayName").ToString();
                    if (nomComponente.Contains("Microsoft .NET Framework"))
                    {
                        Modelo.classConfiguracion.Timagen = "bien.ico";
                        frm.activaComponente("pbFramework");
                        framework = true;
                    }
                    if (nomComponente.Contains("SAP Crystal Reports"))
                    {
                        Modelo.classConfiguracion.Timagen = "bien.ico";
                        frm.activaComponente("pbCrystal");
                        crystal = true;
                    }
                }
            }
            return resp;
        }
    }
}
