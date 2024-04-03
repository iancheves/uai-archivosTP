
namespace chevesian_tparchivos
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMenu = new System.Windows.Forms.Label();
            this.btmCaja = new System.Windows.Forms.Button();
            this.btmFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMenu.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(64, 11);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(150, 56);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu";
            // 
            // btmCaja
            // 
            this.btmCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btmCaja.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCaja.ForeColor = System.Drawing.Color.White;
            this.btmCaja.Location = new System.Drawing.Point(27, 81);
            this.btmCaja.Name = "btmCaja";
            this.btmCaja.Size = new System.Drawing.Size(219, 69);
            this.btmCaja.TabIndex = 1;
            this.btmCaja.Text = "Abrir Caja";
            this.btmCaja.UseVisualStyleBackColor = false;
            this.btmCaja.Click += new System.EventHandler(this.btmCaja_Click);
            // 
            // btmFactura
            // 
            this.btmFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btmFactura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmFactura.ForeColor = System.Drawing.Color.White;
            this.btmFactura.Location = new System.Drawing.Point(27, 165);
            this.btmFactura.Name = "btmFactura";
            this.btmFactura.Size = new System.Drawing.Size(219, 69);
            this.btmFactura.TabIndex = 2;
            this.btmFactura.Text = "Abrir Factura";
            this.btmFactura.UseVisualStyleBackColor = false;
            this.btmFactura.Click += new System.EventHandler(this.btmFactura_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 258);
            this.Controls.Add(this.btmFactura);
            this.Controls.Add(this.btmCaja);
            this.Controls.Add(this.lblMenu);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btmCaja;
        private System.Windows.Forms.Button btmFactura;
    }
}

