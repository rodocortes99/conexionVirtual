using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;
using System.IO;
using System.Configuration;

namespace conexionVirtual.Vista
{
    public partial class tarea : Form
    {
        public tarea()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (var tarea = new TaskService())
            {
                try
                {
                    int tiempo = Convert.ToInt32(txtTiempo.Text);
                    // Se Crea nueva tarea en el task manager
                    TaskDefinition td = tarea.NewTask();
                    td.Settings.MultipleInstances = TaskInstancesPolicy.IgnoreNew;
                    // Se ejecuta cada 1 minuto, es necesario modificcar el APP.config
                    var trigger = new TimeTrigger();
                    trigger.Repetition.Interval = TimeSpan.FromMinutes(tiempo);
                    td.Triggers.Add(trigger);                  
                    // Toma la ruta de el ejecutable, del App.congig                    
                    td.Actions.Add(new ExecAction((ConfigurationManager.AppSettings["ruta"].ToString()), null, null));
                    // Nombre de la tarea
                    tarea.RootFolder.RegisterTaskDefinition(@"PlataformasDigitales", td);
                }
                catch (System.Exception excep)
                {
                    MessageBox.Show(excep.Message,"ERROR");
                }
                this.Close();
            }
        }
        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsPunctuation(pE.KeyChar))
            {
                pE.Handled = false;
            }

            else
            {
                pE.Handled = true;
            }
        }

        private void txtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTiempo.Focus();
            }
        }
    }
}
