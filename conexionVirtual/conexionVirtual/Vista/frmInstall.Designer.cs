namespace conexionVirtual.Vista
{
    partial class frmInstall
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.pbProduccion = new System.Windows.Forms.PictureBox();
            this.pbPruebas = new System.Windows.Forms.PictureBox();
            this.pbRutas = new System.Windows.Forms.PictureBox();
            this.pbCrystal = new System.Windows.Forms.PictureBox();
            this.pbFramework = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPruebas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrystal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFramework)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(663, 212);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Validar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Framework .NET";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Crystal Reports";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rutas ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Conectividad WS Pruebas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(290, 12);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(368, 23);
            this.txtRuta.TabIndex = 7;
            this.txtRuta.Text = "C://Virtual Bridge";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(663, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Directorio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Conectividad WS Produccion";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbProduccion
            // 
            this.pbProduccion.BackColor = System.Drawing.Color.Transparent;
            this.pbProduccion.Location = new System.Drawing.Point(241, 177);
            this.pbProduccion.Name = "pbProduccion";
            this.pbProduccion.Size = new System.Drawing.Size(28, 26);
            this.pbProduccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduccion.TabIndex = 14;
            this.pbProduccion.TabStop = false;
            // 
            // pbPruebas
            // 
            this.pbPruebas.BackColor = System.Drawing.Color.Transparent;
            this.pbPruebas.Location = new System.Drawing.Point(241, 136);
            this.pbPruebas.Name = "pbPruebas";
            this.pbPruebas.Size = new System.Drawing.Size(28, 26);
            this.pbPruebas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPruebas.TabIndex = 12;
            this.pbPruebas.TabStop = false;
            // 
            // pbRutas
            // 
            this.pbRutas.BackColor = System.Drawing.Color.Transparent;
            this.pbRutas.Location = new System.Drawing.Point(241, 11);
            this.pbRutas.Name = "pbRutas";
            this.pbRutas.Size = new System.Drawing.Size(28, 26);
            this.pbRutas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRutas.TabIndex = 11;
            this.pbRutas.TabStop = false;
            // 
            // pbCrystal
            // 
            this.pbCrystal.BackColor = System.Drawing.Color.Transparent;
            this.pbCrystal.Location = new System.Drawing.Point(241, 94);
            this.pbCrystal.Name = "pbCrystal";
            this.pbCrystal.Size = new System.Drawing.Size(28, 26);
            this.pbCrystal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCrystal.TabIndex = 10;
            this.pbCrystal.TabStop = false;
            // 
            // pbFramework
            // 
            this.pbFramework.BackColor = System.Drawing.Color.Transparent;
            this.pbFramework.Location = new System.Drawing.Point(241, 54);
            this.pbFramework.Name = "pbFramework";
            this.pbFramework.Size = new System.Drawing.Size(28, 26);
            this.pbFramework.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFramework.TabIndex = 9;
            this.pbFramework.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmInstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 283);
            this.Controls.Add(this.pbProduccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbPruebas);
            this.Controls.Add(this.pbRutas);
            this.Controls.Add(this.pbCrystal);
            this.Controls.Add(this.pbFramework);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmInstall";
            this.Text = "Instalador";
            ((System.ComponentModel.ISupportInitialize)(this.pbProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPruebas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrystal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFramework)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbFramework;
        private System.Windows.Forms.PictureBox pbCrystal;
        private System.Windows.Forms.PictureBox pbPruebas;
        private System.Windows.Forms.PictureBox pbRutas;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pbProduccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NotifyIcon notifyIcon1;

    }
}