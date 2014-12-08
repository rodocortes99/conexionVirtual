using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace conexionVirtual
{
    public partial class frmMain : Form
    {
        Controlador.classFormularios frm = new Controlador.classFormularios();
        public frmMain()
        {
            InitializeComponent();
            Controlador.classFormularios.Indice = this;
            Modelo.classConfiguracion.Path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (frm.frmActivo())
            {
            }
            else { MessageBox.Show("Error al cargar el formulario"+"Datos de soporte"); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
