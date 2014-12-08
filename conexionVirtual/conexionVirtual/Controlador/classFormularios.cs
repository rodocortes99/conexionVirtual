using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Configuration;

namespace conexionVirtual.Controlador
{    
    class classFormularios
    {
        private static Control indice;
        public static Control Indice
        {
            get { return classFormularios.indice; }
            set { classFormularios.indice = value; }
        }        
        public void formActivo(string nombreFrm)
        {
            try
            {
                foreach (Control ctrl in indice.Controls)
                {
                    if (ctrl.Name == "pContenedor")
                    {
                        if (ctrl.Controls.Count > 0)
                        {
                            ctrl.Controls.RemoveAt(0);
                        }
                        else
                        {
                           switch(nombreFrm)
                           {
                               case "i1":
                                   Vista.frmInstall install = new Vista.frmInstall();
                                   install.TopLevel = false;
                                   install.FormBorderStyle = FormBorderStyle.None;
                                   install.Dock = DockStyle.Fill;
                                   ctrl.Controls.Add(install);
                                   ctrl.Tag = install;
                                   install.Show();
                                     
                                   break;
                           }
                        }
                    }
                }
            }
            catch
            {
                Modelo.classControlErrores.NombreErrror += "Error al insertar los formularios";
            }
        }
        public void activaComponente(string pb)
        {
            try
            {
                foreach(Control ctrl in indice.Controls)
                {
                    if ((ctrl.Name == "pbFramework") && (pb == "pbFramework"))
                    {
                        ((PictureBox)indice.Controls[ctrl.Name]).Image = Image.FromFile(Modelo.classConfiguracion.Path + "APP\\" + Modelo.classConfiguracion.Timagen);
                        break;
                    }
                    if ((ctrl.Name == "pbRutas") && (pb == "pbRutas"))
                    {
                        ((PictureBox)indice.Controls[ctrl.Name]).Image = Image.FromFile(Modelo.classConfiguracion.Path + "APP\\"+Modelo.classConfiguracion.Timagen);
                        break;
                    }
                    if ((ctrl.Name == "pbCrystal") && (pb == "pbCrystal"))
                    {
                        ((PictureBox)indice.Controls[ctrl.Name]).Image = Image.FromFile(Modelo.classConfiguracion.Path + "APP\\" + Modelo.classConfiguracion.Timagen);
                        break;
                    } if ((ctrl.Name == "pbPruebas") && (pb == "pbPruebas"))
                    {
                        ((PictureBox)indice.Controls[ctrl.Name]).Image = Image.FromFile(Modelo.classConfiguracion.Path + "APP\\" + Modelo.classConfiguracion.Timagen);
                        break;
                    } if ((ctrl.Name == "pbProduccion") && (pb == "pbProduccion"))
                    {
                        ((PictureBox)indice.Controls[ctrl.Name]).Image = Image.FromFile(Modelo.classConfiguracion.Path + "APP\\" + Modelo.classConfiguracion.Timagen);
                        break;
                    }
                }
            }
            catch
            {
            }
            
        }

        public bool frmActivo()
        {
            bool val = false;
            try
            {
                    formActivo("i1");
                    val = true;
            }
            catch
            {
                val = false;
            }
            return val;
        }
    }
}
