
namespace chevesian_tparchivos
{
    partial class frmFactura
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
            this.lblArchivoSeleccionado = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btmModificarDatos = new System.Windows.Forms.Button();
            this.btmCargarArchivo = new System.Windows.Forms.Button();
            this.btmEliminarFactura = new System.Windows.Forms.Button();
            this.lblFactura = new System.Windows.Forms.Label();
            this.btmAgregarFactura = new System.Windows.Forms.Button();
            this.lblNumFactura = new System.Windows.Forms.Label();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.lstFactura = new System.Windows.Forms.ListBox();
            this.lblNumCaja = new System.Windows.Forms.Label();
            this.txtNumCaja = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblArchivoSeleccionado
            // 
            this.lblArchivoSeleccionado.AutoSize = true;
            this.lblArchivoSeleccionado.Font = new System.Drawing.Font("Arial", 8F);
            this.lblArchivoSeleccionado.Location = new System.Drawing.Point(228, 523);
            this.lblArchivoSeleccionado.Name = "lblArchivoSeleccionado";
            this.lblArchivoSeleccionado.Size = new System.Drawing.Size(23, 14);
            this.lblArchivoSeleccionado.TabIndex = 24;
            this.lblArchivoSeleccionado.Text = "null";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(228, 497);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 18);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Archivo Seleccionado:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(23, 223);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(55, 18);
            this.lblMonto.TabIndex = 22;
            this.lblMonto.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(26, 244);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(172, 20);
            this.txtMonto.TabIndex = 21;
            // 
            // btmModificarDatos
            // 
            this.btmModificarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btmModificarDatos.Enabled = false;
            this.btmModificarDatos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmModificarDatos.ForeColor = System.Drawing.Color.White;
            this.btmModificarDatos.Location = new System.Drawing.Point(22, 485);
            this.btmModificarDatos.Name = "btmModificarDatos";
            this.btmModificarDatos.Size = new System.Drawing.Size(176, 55);
            this.btmModificarDatos.TabIndex = 20;
            this.btmModificarDatos.Text = "Modificar Datos";
            this.btmModificarDatos.UseVisualStyleBackColor = false;
            this.btmModificarDatos.Click += new System.EventHandler(this.btmModificarDatos_Click);
            // 
            // btmCargarArchivo
            // 
            this.btmCargarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btmCargarArchivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCargarArchivo.ForeColor = System.Drawing.Color.White;
            this.btmCargarArchivo.Location = new System.Drawing.Point(22, 288);
            this.btmCargarArchivo.Name = "btmCargarArchivo";
            this.btmCargarArchivo.Size = new System.Drawing.Size(176, 55);
            this.btmCargarArchivo.TabIndex = 19;
            this.btmCargarArchivo.Text = "Cargar Archivo";
            this.btmCargarArchivo.UseVisualStyleBackColor = false;
            this.btmCargarArchivo.Click += new System.EventHandler(this.btmCargarArchivo_Click);
            // 
            // btmEliminarFactura
            // 
            this.btmEliminarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btmEliminarFactura.Enabled = false;
            this.btmEliminarFactura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmEliminarFactura.ForeColor = System.Drawing.Color.White;
            this.btmEliminarFactura.Location = new System.Drawing.Point(22, 424);
            this.btmEliminarFactura.Name = "btmEliminarFactura";
            this.btmEliminarFactura.Size = new System.Drawing.Size(176, 55);
            this.btmEliminarFactura.TabIndex = 18;
            this.btmEliminarFactura.Text = "Eliminar Factura";
            this.btmEliminarFactura.UseVisualStyleBackColor = false;
            this.btmEliminarFactura.Click += new System.EventHandler(this.btmEliminarFactura_Click);
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFactura.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.ForeColor = System.Drawing.Color.White;
            this.lblFactura.Location = new System.Drawing.Point(26, 19);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(198, 56);
            this.lblFactura.TabIndex = 17;
            this.lblFactura.Text = "Factura";
            // 
            // btmAgregarFactura
            // 
            this.btmAgregarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btmAgregarFactura.Enabled = false;
            this.btmAgregarFactura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAgregarFactura.ForeColor = System.Drawing.Color.White;
            this.btmAgregarFactura.Location = new System.Drawing.Point(22, 358);
            this.btmAgregarFactura.Name = "btmAgregarFactura";
            this.btmAgregarFactura.Size = new System.Drawing.Size(176, 55);
            this.btmAgregarFactura.TabIndex = 16;
            this.btmAgregarFactura.Text = "Agregar Factura";
            this.btmAgregarFactura.UseVisualStyleBackColor = false;
            this.btmAgregarFactura.Click += new System.EventHandler(this.btmAgregarFactura_Click);
            // 
            // lblNumFactura
            // 
            this.lblNumFactura.AutoSize = true;
            this.lblNumFactura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFactura.Location = new System.Drawing.Point(23, 98);
            this.lblNumFactura.Name = "lblNumFactura";
            this.lblNumFactura.Size = new System.Drawing.Size(142, 18);
            this.lblNumFactura.TabIndex = 15;
            this.lblNumFactura.Text = "Numero de Factura";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Location = new System.Drawing.Point(26, 119);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(172, 20);
            this.txtNumFactura.TabIndex = 14;
            // 
            // lstFactura
            // 
            this.lstFactura.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFactura.FormattingEnabled = true;
            this.lstFactura.ItemHeight = 22;
            this.lstFactura.Location = new System.Drawing.Point(231, 119);
            this.lstFactura.Name = "lstFactura";
            this.lstFactura.Size = new System.Drawing.Size(242, 356);
            this.lstFactura.TabIndex = 13;
            this.lstFactura.SelectedIndexChanged += new System.EventHandler(this.lstFactura_SelectedIndexChanged);
            // 
            // lblNumCaja
            // 
            this.lblNumCaja.AutoSize = true;
            this.lblNumCaja.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCaja.Location = new System.Drawing.Point(23, 161);
            this.lblNumCaja.Name = "lblNumCaja";
            this.lblNumCaja.Size = new System.Drawing.Size(126, 18);
            this.lblNumCaja.TabIndex = 26;
            this.lblNumCaja.Text = "Numero de Caja:";
            // 
            // txtNumCaja
            // 
            this.txtNumCaja.Location = new System.Drawing.Point(26, 182);
            this.txtNumCaja.Name = "txtNumCaja";
            this.txtNumCaja.Size = new System.Drawing.Size(172, 20);
            this.txtNumCaja.TabIndex = 25;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Txt Files|*.txt";
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 573);
            this.Controls.Add(this.lblNumCaja);
            this.Controls.Add(this.txtNumCaja);
            this.Controls.Add(this.lblArchivoSeleccionado);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btmModificarDatos);
            this.Controls.Add(this.btmCargarArchivo);
            this.Controls.Add(this.btmEliminarFactura);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.btmAgregarFactura);
            this.Controls.Add(this.lblNumFactura);
            this.Controls.Add(this.txtNumFactura);
            this.Controls.Add(this.lstFactura);
            this.Name = "frmFactura";
            this.Text = "frmFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArchivoSeleccionado;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btmModificarDatos;
        private System.Windows.Forms.Button btmCargarArchivo;
        private System.Windows.Forms.Button btmEliminarFactura;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Button btmAgregarFactura;
        private System.Windows.Forms.Label lblNumFactura;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.ListBox lstFactura;
        private System.Windows.Forms.Label lblNumCaja;
        private System.Windows.Forms.TextBox txtNumCaja;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}