namespace VistaForm
{
    partial class FormVistaCurso
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
            this.gpbDatosCurso = new System.Windows.Forms.GroupBox();
            this.gpbDatosAlumnos = new System.Windows.Forms.GroupBox();
            this.lblAñoCurso = new System.Windows.Forms.Label();
            this.lblDivisionCurso = new System.Windows.Forms.Label();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.lblApellidoCurso = new System.Windows.Forms.Label();
            this.lblDniCurso = new System.Windows.Forms.Label();
            this.lblIngresoCurso = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.nudAñoCurso = new System.Windows.Forms.NumericUpDown();
            this.nudAño = new System.Windows.Forms.NumericUpDown();
            this.cmbDivisionCurso = new System.Windows.Forms.ComboBox();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.txtNombreProfe = new System.Windows.Forms.TextBox();
            this.txtApellidoProfe = new System.Windows.Forms.TextBox();
            this.txtDniProfe = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.gpbDatosCurso.SuspendLayout();
            this.gpbDatosAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAñoCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDatosCurso
            // 
            this.gpbDatosCurso.Controls.Add(this.btnMostrar);
            this.gpbDatosCurso.Controls.Add(this.btnCrear);
            this.gpbDatosCurso.Controls.Add(this.dtpFechaIngreso);
            this.gpbDatosCurso.Controls.Add(this.txtDniProfe);
            this.gpbDatosCurso.Controls.Add(this.txtApellidoProfe);
            this.gpbDatosCurso.Controls.Add(this.txtNombreProfe);
            this.gpbDatosCurso.Controls.Add(this.cmbDivisionCurso);
            this.gpbDatosCurso.Controls.Add(this.nudAñoCurso);
            this.gpbDatosCurso.Controls.Add(this.lblIngresoCurso);
            this.gpbDatosCurso.Controls.Add(this.lblDniCurso);
            this.gpbDatosCurso.Controls.Add(this.lblApellidoCurso);
            this.gpbDatosCurso.Controls.Add(this.lblNombreCurso);
            this.gpbDatosCurso.Controls.Add(this.lblDivisionCurso);
            this.gpbDatosCurso.Controls.Add(this.lblAñoCurso);
            this.gpbDatosCurso.Location = new System.Drawing.Point(12, 12);
            this.gpbDatosCurso.Name = "gpbDatosCurso";
            this.gpbDatosCurso.Size = new System.Drawing.Size(258, 206);
            this.gpbDatosCurso.TabIndex = 0;
            this.gpbDatosCurso.TabStop = false;
            this.gpbDatosCurso.Text = "Datos Curso";
            // 
            // gpbDatosAlumnos
            // 
            this.gpbDatosAlumnos.Controls.Add(this.btnAgregar);
            this.gpbDatosAlumnos.Controls.Add(this.txtLegajo);
            this.gpbDatosAlumnos.Controls.Add(this.txtApellido);
            this.gpbDatosAlumnos.Controls.Add(this.txtNombre);
            this.gpbDatosAlumnos.Controls.Add(this.cmbDivision);
            this.gpbDatosAlumnos.Controls.Add(this.nudAño);
            this.gpbDatosAlumnos.Controls.Add(this.lblDivision);
            this.gpbDatosAlumnos.Controls.Add(this.lblLegajo);
            this.gpbDatosAlumnos.Controls.Add(this.lblAño);
            this.gpbDatosAlumnos.Controls.Add(this.lblApellido);
            this.gpbDatosAlumnos.Controls.Add(this.lblNombre);
            this.gpbDatosAlumnos.Location = new System.Drawing.Point(276, 12);
            this.gpbDatosAlumnos.Name = "gpbDatosAlumnos";
            this.gpbDatosAlumnos.Size = new System.Drawing.Size(261, 206);
            this.gpbDatosAlumnos.TabIndex = 1;
            this.gpbDatosAlumnos.TabStop = false;
            this.gpbDatosAlumnos.Text = "Datos Alumnos";
            // 
            // lblAñoCurso
            // 
            this.lblAñoCurso.AutoSize = true;
            this.lblAñoCurso.Location = new System.Drawing.Point(8, 33);
            this.lblAñoCurso.Name = "lblAñoCurso";
            this.lblAñoCurso.Size = new System.Drawing.Size(26, 13);
            this.lblAñoCurso.TabIndex = 2;
            this.lblAñoCurso.Text = "Año";
            // 
            // lblDivisionCurso
            // 
            this.lblDivisionCurso.AutoSize = true;
            this.lblDivisionCurso.Location = new System.Drawing.Point(6, 56);
            this.lblDivisionCurso.Name = "lblDivisionCurso";
            this.lblDivisionCurso.Size = new System.Drawing.Size(44, 13);
            this.lblDivisionCurso.TabIndex = 3;
            this.lblDivisionCurso.Text = "Division";
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Location = new System.Drawing.Point(6, 79);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(44, 13);
            this.lblNombreCurso.TabIndex = 4;
            this.lblNombreCurso.Text = "Nombre";
            // 
            // lblApellidoCurso
            // 
            this.lblApellidoCurso.AutoSize = true;
            this.lblApellidoCurso.Location = new System.Drawing.Point(6, 101);
            this.lblApellidoCurso.Name = "lblApellidoCurso";
            this.lblApellidoCurso.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoCurso.TabIndex = 5;
            this.lblApellidoCurso.Text = "Apellido";
            // 
            // lblDniCurso
            // 
            this.lblDniCurso.AutoSize = true;
            this.lblDniCurso.Location = new System.Drawing.Point(6, 125);
            this.lblDniCurso.Name = "lblDniCurso";
            this.lblDniCurso.Size = new System.Drawing.Size(26, 13);
            this.lblDniCurso.TabIndex = 6;
            this.lblDniCurso.Text = "DNI";
            // 
            // lblIngresoCurso
            // 
            this.lblIngresoCurso.AutoSize = true;
            this.lblIngresoCurso.Location = new System.Drawing.Point(6, 148);
            this.lblIngresoCurso.Name = "lblIngresoCurso";
            this.lblIngresoCurso.Size = new System.Drawing.Size(42, 13);
            this.lblIngresoCurso.TabIndex = 7;
            this.lblIngresoCurso.Text = "Ingreso";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 56);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(6, 79);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 9;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(6, 101);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 8;
            this.lblAño.Text = "Año";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(6, 125);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 9;
            this.lblDivision.Text = "Division";
            // 
            // nudAñoCurso
            // 
            this.nudAñoCurso.Location = new System.Drawing.Point(54, 26);
            this.nudAñoCurso.Name = "nudAñoCurso";
            this.nudAñoCurso.Size = new System.Drawing.Size(198, 20);
            this.nudAñoCurso.TabIndex = 8;
            // 
            // nudAño
            // 
            this.nudAño.Location = new System.Drawing.Point(57, 94);
            this.nudAño.Name = "nudAño";
            this.nudAño.Size = new System.Drawing.Size(183, 20);
            this.nudAño.TabIndex = 10;
            // 
            // cmbDivisionCurso
            // 
            this.cmbDivisionCurso.FormattingEnabled = true;
            this.cmbDivisionCurso.Location = new System.Drawing.Point(54, 48);
            this.cmbDivisionCurso.Name = "cmbDivisionCurso";
            this.cmbDivisionCurso.Size = new System.Drawing.Size(198, 21);
            this.cmbDivisionCurso.TabIndex = 9;
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(56, 117);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(184, 21);
            this.cmbDivision.TabIndex = 11;
            // 
            // txtNombreProfe
            // 
            this.txtNombreProfe.Location = new System.Drawing.Point(54, 72);
            this.txtNombreProfe.Name = "txtNombreProfe";
            this.txtNombreProfe.Size = new System.Drawing.Size(198, 20);
            this.txtNombreProfe.TabIndex = 10;
            // 
            // txtApellidoProfe
            // 
            this.txtApellidoProfe.Location = new System.Drawing.Point(54, 93);
            this.txtApellidoProfe.Name = "txtApellidoProfe";
            this.txtApellidoProfe.Size = new System.Drawing.Size(198, 20);
            this.txtApellidoProfe.TabIndex = 11;
            // 
            // txtDniProfe
            // 
            this.txtDniProfe.Location = new System.Drawing.Point(54, 117);
            this.txtDniProfe.Name = "txtDniProfe";
            this.txtDniProfe.Size = new System.Drawing.Size(198, 20);
            this.txtDniProfe.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(57, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(57, 48);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(183, 20);
            this.txtApellido.TabIndex = 13;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(57, 72);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(183, 20);
            this.txtLegajo.TabIndex = 14;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(54, 141);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(198, 20);
            this.dtpFechaIngreso.TabIndex = 13;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(9, 167);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(102, 33);
            this.btnCrear.TabIndex = 14;
            this.btnCrear.Text = "Crear Curso";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(138, 167);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(105, 33);
            this.btnMostrar.TabIndex = 15;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(152, 158);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 42);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(12, 218);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(525, 121);
            this.rtbDatos.TabIndex = 2;
            this.rtbDatos.Text = "";
            // 
            // FormVistaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 351);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.gpbDatosAlumnos);
            this.Controls.Add(this.gpbDatosCurso);
            this.Name = "FormVistaCurso";
            this.Text = "Vista Del Curso";
            this.Load += new System.EventHandler(this.FormVistaCurso_Load);
            this.gpbDatosCurso.ResumeLayout(false);
            this.gpbDatosCurso.PerformLayout();
            this.gpbDatosAlumnos.ResumeLayout(false);
            this.gpbDatosAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAñoCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatosCurso;
        private System.Windows.Forms.GroupBox gpbDatosAlumnos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.TextBox txtDniProfe;
        private System.Windows.Forms.TextBox txtApellidoProfe;
        private System.Windows.Forms.TextBox txtNombreProfe;
        private System.Windows.Forms.ComboBox cmbDivisionCurso;
        private System.Windows.Forms.NumericUpDown nudAñoCurso;
        private System.Windows.Forms.Label lblIngresoCurso;
        private System.Windows.Forms.Label lblDniCurso;
        private System.Windows.Forms.Label lblApellidoCurso;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblDivisionCurso;
        private System.Windows.Forms.Label lblAñoCurso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.NumericUpDown nudAño;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RichTextBox rtbDatos;
    }
}

