namespace Centralita
{
    partial class FormMenu
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
            this.btnGenerarLlamada = new System.Windows.Forms.Button();
            this.btnFacTotal = new System.Windows.Forms.Button();
            this.btnFactLocal = new System.Windows.Forms.Button();
            this.btnFactProv = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarLlamada
            // 
            this.btnGenerarLlamada.Location = new System.Drawing.Point(12, 12);
            this.btnGenerarLlamada.Name = "btnGenerarLlamada";
            this.btnGenerarLlamada.Size = new System.Drawing.Size(211, 50);
            this.btnGenerarLlamada.TabIndex = 0;
            this.btnGenerarLlamada.Text = "Generar Llamada";
            this.btnGenerarLlamada.UseVisualStyleBackColor = true;
            this.btnGenerarLlamada.Click += new System.EventHandler(this.btnGenerarLlamada_Click);
            // 
            // btnFacTotal
            // 
            this.btnFacTotal.Location = new System.Drawing.Point(12, 62);
            this.btnFacTotal.Name = "btnFacTotal";
            this.btnFacTotal.Size = new System.Drawing.Size(211, 50);
            this.btnFacTotal.TabIndex = 1;
            this.btnFacTotal.Text = "Facturacion Total";
            this.btnFacTotal.UseVisualStyleBackColor = true;
            // 
            // btnFactLocal
            // 
            this.btnFactLocal.Location = new System.Drawing.Point(12, 113);
            this.btnFactLocal.Name = "btnFactLocal";
            this.btnFactLocal.Size = new System.Drawing.Size(211, 50);
            this.btnFactLocal.TabIndex = 2;
            this.btnFactLocal.Text = "Facturacion Local";
            this.btnFactLocal.UseVisualStyleBackColor = true;
            // 
            // btnFactProv
            // 
            this.btnFactProv.Location = new System.Drawing.Point(12, 164);
            this.btnFactProv.Name = "btnFactProv";
            this.btnFactProv.Size = new System.Drawing.Size(211, 50);
            this.btnFactProv.TabIndex = 3;
            this.btnFactProv.Text = "Facturacion Provincial";
            this.btnFactProv.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 215);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(211, 50);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 298);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFactProv);
            this.Controls.Add(this.btnFactLocal);
            this.Controls.Add(this.btnFacTotal);
            this.Controls.Add(this.btnGenerarLlamada);
            this.Name = "FormMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarLlamada;
        private System.Windows.Forms.Button btnFacTotal;
        private System.Windows.Forms.Button btnFactLocal;
        private System.Windows.Forms.Button btnFactProv;
        private System.Windows.Forms.Button btnSalir;
    }
}

