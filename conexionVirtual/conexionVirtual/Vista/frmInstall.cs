using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace conexionVirtual.Vista
{
    public partial class frmInstall : Form
    {
        Controlador.classComponentes com = new Controlador.classComponentes();
        Modelo.classAcceso acceso = new Modelo.classAcceso();
      
        public frmInstall()
        {
            InitializeComponent();
            Controlador.classFormularios.Indice = this;  
        }
        
        private void frmInstall_FormClosing(object sender, FormClosingEventArgs e)
        {     
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            //Muestra un icono en el área de notificaciones  
            try
            {
                Modelo.classConfiguracion.Timagen = "virtualcfdi.ico";
                notifyIcon1.Icon = new System.Drawing.Icon(Modelo.classConfiguracion.Path + "APP\\" + Modelo.classConfiguracion.Timagen);
                notifyIcon1.Visible = true;
                notifyIcon1.Text = "Comprobando Instalaciones..";
                notifyIcon1.ShowBalloonTip(2, "Plataformas", "Comprobando Instalaciones..", ToolTipIcon.Info);
            }
            catch 
            {                
            }
           string ruta = txtRuta.Text;
           com.softComponentes(ruta);                         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult dResulto = dialog.ShowDialog();
            if (dResulto == DialogResult.OK)
            {
                txtRuta.Text = dialog.SelectedPath;
            }
        }

    }   
}
