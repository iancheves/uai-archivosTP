
namespace chevesian_tparchivos
{
    partial class frmCaja
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
            this.lstCaja = new System.Windows.Forms.ListBox();
            this.txtNumCaja = new System.Windows.Forms.TextBox();
            this.lblNumCaja = new System.Windows.Forms.Label();
            this.btmAgregarCaja = new System.Windows.Forms.Button();
            this.lblCaja = new System.Windows.Forms.Label();
            this.lblCaja1 = new System.Windows.Forms.Label();
            this.btmEliminarCaja = new System.Windows.Forms.Button();
            this.btmCargarArchivo = new System.Windows.Forms.Button();
            this.btmModificarDatos = new System.Windows.Forms.Button();
            this.lblNombreCaja = new System.Windows.Forms.Label();
            this.txtNombreCaja = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArchivoSeleccionado = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lstCaja
            // 
            this.lstCaja.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCaja.FormattingEnabled = true;
            this.lstCaja.ItemHeight = 22;
            this.lstCaja.Location = new System.Drawing.Point(234, 114);
            this.lstCaja.Name = "lstCaja";
            this.lstCaja.Size = new System.Drawing.Size(242, 334);
            this.lstCaja.TabIndex = 0;
            // 
            // txtNumCaja
            // 
            this.txtNumCaja.Location = new System.Drawing.Point(29, 120);
            this.txtNumCaja.Name = "txtNumCaja";
            this.txtNumCaja.Size = new System.Drawing.Size(172, 20);
            this.txtNumCaja.TabIndex = 1;
            // 
            // lblNumCaja
            // 
            this.lblNumCaja.AutoSize = true;
            this.lblNumCaja.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCaja.Location = new System.Drawing.Point(26, 99);
            this.lblNumCaja.Name = "lblNumCaja";
            this.lblNumCaja.Size = new System.Drawing.Size(126, 18);
            this.lblNumCaja.TabIndex = 2;
            this.lblNumCaja.Text = "Numero de Caja:";
            this.lblNumCaja.Click += new System.EventHandler(this.lblNumCaja_Click);
            // 
            // btmAgregarCaja
            // 
            this.btmAgregarCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btmAgregarCaja.Enabled = false;
            this.btmAgregarCaja.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAgregarCaja.ForeColor = System.Drawing.Color.White;
            this.btmAgregarCaja.Location = new System.Drawing.Point(25, 280);
            this.btmAgregarCaja.Name = "btmAgregarCaja";
            this.btmAgregarCaja.Size = new System.Drawing.Size(176, 55);
            this.btmAgregarCaja.TabIndex = 4;
            this.btmAgregarCaja.Text = "Agregar Caja";
            this.btmAgregarCaja.UseVisualStyleBackColor = false;
            this.btmAgregarCaja.Click += new System.EventHandler(this.btmAgregarCaja_Click);
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCaja.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.ForeColor = System.Drawing.Color.White;
            this.lblCaja.Location = new System.Drawing.Point(10, 583);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(126, 56);
            this.lblCaja.TabIndex = 3;
            this.lblCaja.Text = "Caja";
            // 
            // lblCaja1
            // 
            this.lblCaja1.AutoSize = true;
            this.lblCaja1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCaja1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja1.ForeColor = System.Drawing.Color.White;
            this.lblCaja1.Location = new System.Drawing.Point(30, 20);
            this.lblCaja1.Name = "lblCaja1";
            this.lblCaja1.Size = new System.Drawing.Size(126, 56);
            this.lblCaja1.TabIndex = 5;
            this.lblCaja1.Text = "Caja";
            // 
            // btmEliminarCaja
            // 
            this.btmEliminarCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btmEliminarCaja.Enabled = false;
            this.btmEliminarCaja.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmEliminarCaja.ForeColor = System.Drawing.Color.White;
            this.btmEliminarCaja.Location = new System.Drawing.Point(25, 341);
            this.btmEliminarCaja.Name = "btmEliminarCaja";
            this.btmEliminarCaja.Size = new System.Drawing.Size(176, 55);
            this.btmEliminarCaja.TabIndex = 6;
            this.btmEliminarCaja.Text = "Eliminar Caja";
            this.btmEliminarCaja.UseVisualStyleBackColor = false;
            this.btmEliminarCaja.Click += new System.EventHandler(this.btmEliminarCaja_Click);
            // 
            // btmCargarArchivo
            // 
            this.btmCargarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btmCargarArchivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCargarArchivo.ForeColor = System.Drawing.Color.White;
            this.btmCargarArchivo.Location = new System.Drawing.Point(25, 219);
            this.btmCargarArchivo.Name = "btmCargarArchivo";
            this.btmCargarArchivo.Size = new System.Drawing.Size(176, 55);
            this.btmCargarArchivo.TabIndex = 7;
            this.btmCargarArchivo.Text = "Cargar Archivo";
            this.btmCargarArchivo.UseVisualStyleBackColor = false;
            this.btmCargarArchivo.Click += new System.EventHandler(this.btmCargarArchivo_Click);
            // 
            // btmModificarDatos
            // 
            this.btmModificarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btmModificarDatos.Enabled = false;
            this.btmModificarDatos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmModificarDatos.ForeColor = System.Drawing.Color.White;
            this.btmModificarDatos.Location = new System.Drawing.Point(25, 402);
            this.btmModificarDatos.Name = "btmModificarDatos";
            this.btmModificarDatos.Size = new System.Drawing.Size(176, 55);
            this.btmModificarDatos.TabIndex = 8;
            this.btmModificarDatos.Text = "Modificar Datos";
            this.btmModificarDatos.UseVisualStyleBackColor = false;
            this.btmModificarDatos.Click += new System.EventHandler(this.btmModificarDatos_Click);
            // 
            // lblNombreCaja
            // 
            this.lblNombreCaja.AutoSize = true;
            this.lblNombreCaja.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCaja.Location = new System.Drawing.Point(26, 158);
            this.lblNombreCaja.Name = "lblNombreCaja";
            this.lblNombreCaja.Size = new System.Drawing.Size(68, 18);
            this.lblNombreCaja.TabIndex = 10;
            this.lblNombreCaja.Text = "Nombre:";
            // 
            // txtNombreCaja
            // 
            this.txtNombreCaja.Location = new System.Drawing.Point(29, 179);
            this.txtNombreCaja.Name = "txtNombreCaja";
            this.txtNombreCaja.Size = new System.Drawing.Size(172, 20);
            this.txtNombreCaja.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(231, 64);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 18);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Archivo Seleccionado:";
            // 
            // lblArchivoSeleccionado
            // 
            this.lblArchivoSeleccionado.AutoSize = true;
            this.lblArchivoSeleccionado.Font = new System.Drawing.Font("Arial", 8F);
            this.lblArchivoSeleccionado.Location = new System.Drawing.Point(231, 90);
            this.lblArchivoSeleccionado.Name = "lblArchivoSeleccionado";
            this.lblArchivoSeleccionado.Size = new System.Drawing.Size(23, 14);
            this.lblArchivoSeleccionado.TabIndex = 12;
            this.lblArchivoSeleccionado.Text = "null";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Txt Files|*.txt";
            // 
            // frmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 489);
            this.Controls.Add(this.lblArchivoSeleccionado);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNombreCaja);
            this.Controls.Add(this.txtNombreCaja);
            this.Controls.Add(this.btmModificarDatos);
            this.Controls.Add(this.btmCargarArchivo);
            this.Controls.Add(this.btmEliminarCaja);
            this.Controls.Add(this.lblCaja1);
            this.Controls.Add(this.btmAgregarCaja);
            this.Controls.Add(this.lblCaja);
            this.Controls.Add(this.lblNumCaja);
            this.Controls.Add(this.txtNumCaja);
            this.Controls.Add(this.lstCaja);
            this.Name = "frmCaja";
            this.Text = "Caja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCaja;
        private System.Windows.Forms.TextBox txtNumCaja;
        private System.Windows.Forms.Label lblNumCaja;
        private System.Windows.Forms.Button btmAgregarCaja;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.Label lblCaja1;
        private System.Windows.Forms.Button btmEliminarCaja;
        private System.Windows.Forms.Button btmCargarArchivo;
        private System.Windows.Forms.Button btmModificarDatos;
        private System.Windows.Forms.Label lblNombreCaja;
        private System.Windows.Forms.TextBox txtNombreCaja;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArchivoSeleccionado;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}