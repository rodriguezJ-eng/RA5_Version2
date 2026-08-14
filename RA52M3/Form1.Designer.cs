namespace RA52M3
{
    partial class frmEstudiante
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
            this.gbDatosEstudiante = new System.Windows.Forms.GroupBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbEstudianteRegistrados = new System.Windows.Forms.GroupBox();
            this.rbApellidos = new System.Windows.Forms.RadioButton();
            this.rbNombres = new System.Windows.Forms.RadioButton();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.dgvEstudiante = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbOrden = new System.Windows.Forms.ComboBox();
            this.cmbSexob = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbDatosEstudiante.SuspendLayout();
            this.gbEstudianteRegistrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosEstudiante
            // 
            this.gbDatosEstudiante.Controls.Add(this.txtNombres);
            this.gbDatosEstudiante.Controls.Add(this.txtTelefono);
            this.gbDatosEstudiante.Controls.Add(this.txtApellidos);
            this.gbDatosEstudiante.Controls.Add(this.txtCarnet);
            this.gbDatosEstudiante.Controls.Add(this.cmbSexo);
            this.gbDatosEstudiante.Controls.Add(this.btnBuscar);
            this.gbDatosEstudiante.Controls.Add(this.label5);
            this.gbDatosEstudiante.Controls.Add(this.label4);
            this.gbDatosEstudiante.Controls.Add(this.label3);
            this.gbDatosEstudiante.Controls.Add(this.label2);
            this.gbDatosEstudiante.Controls.Add(this.label1);
            this.gbDatosEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosEstudiante.ForeColor = System.Drawing.Color.Navy;
            this.gbDatosEstudiante.Location = new System.Drawing.Point(12, 12);
            this.gbDatosEstudiante.Name = "gbDatosEstudiante";
            this.gbDatosEstudiante.Size = new System.Drawing.Size(776, 173);
            this.gbDatosEstudiante.TabIndex = 0;
            this.gbDatosEstudiante.TabStop = false;
            this.gbDatosEstudiante.Text = "Datos del Estudiante";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(63, 71);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(203, 20);
            this.txtNombres.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(477, 37);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(203, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(63, 101);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(203, 18);
            this.txtApellidos.TabIndex = 8;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(63, 37);
            this.txtCarnet.Multiline = true;
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(203, 26);
            this.txtCarnet.TabIndex = 7;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(477, 84);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(203, 21);
            this.cmbSexo.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Image = global::RA52M3.Properties.Resources.Buscar;
            this.btnBuscar.Location = new System.Drawing.Point(272, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 30);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(425, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(413, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(8, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carnet";
            // 
            // gbEstudianteRegistrados
            // 
            this.gbEstudianteRegistrados.Controls.Add(this.rbApellidos);
            this.gbEstudianteRegistrados.Controls.Add(this.rbNombres);
            this.gbEstudianteRegistrados.Controls.Add(this.txtFiltrar);
            this.gbEstudianteRegistrados.Controls.Add(this.dgvEstudiante);
            this.gbEstudianteRegistrados.Controls.Add(this.label7);
            this.gbEstudianteRegistrados.Controls.Add(this.cmbOrden);
            this.gbEstudianteRegistrados.Controls.Add(this.cmbSexob);
            this.gbEstudianteRegistrados.Controls.Add(this.label6);
            this.gbEstudianteRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstudianteRegistrados.ForeColor = System.Drawing.Color.Navy;
            this.gbEstudianteRegistrados.Location = new System.Drawing.Point(12, 254);
            this.gbEstudianteRegistrados.Name = "gbEstudianteRegistrados";
            this.gbEstudianteRegistrados.Size = new System.Drawing.Size(776, 213);
            this.gbEstudianteRegistrados.TabIndex = 15;
            this.gbEstudianteRegistrados.TabStop = false;
            this.gbEstudianteRegistrados.Text = "Estudiantes registrados";
            // 
            // rbApellidos
            // 
            this.rbApellidos.AutoSize = true;
            this.rbApellidos.Location = new System.Drawing.Point(416, 77);
            this.rbApellidos.Name = "rbApellidos";
            this.rbApellidos.Size = new System.Drawing.Size(70, 17);
            this.rbApellidos.TabIndex = 18;
            this.rbApellidos.TabStop = true;
            this.rbApellidos.Text = "Apellido";
            this.rbApellidos.UseVisualStyleBackColor = true;
            // 
            // rbNombres
            // 
            this.rbNombres.AutoSize = true;
            this.rbNombres.Location = new System.Drawing.Point(287, 77);
            this.rbNombres.Name = "rbNombres";
            this.rbNombres.Size = new System.Drawing.Size(68, 17);
            this.rbNombres.TabIndex = 17;
            this.rbNombres.TabStop = true;
            this.rbNombres.Text = "Nombre";
            this.rbNombres.UseVisualStyleBackColor = true;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(83, 74);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(198, 20);
            this.txtFiltrar.TabIndex = 10;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // dgvEstudiante
            // 
            this.dgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiante.Location = new System.Drawing.Point(9, 100);
            this.dgvEstudiante.Name = "dgvEstudiante";
            this.dgvEstudiante.RowHeadersWidth = 51;
            this.dgvEstudiante.Size = new System.Drawing.Size(746, 107);
            this.dgvEstudiante.TabIndex = 16;
            this.dgvEstudiante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiante_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(413, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ordenar Por";
            // 
            // cmbOrden
            // 
            this.cmbOrden.FormattingEnabled = true;
            this.cmbOrden.Location = new System.Drawing.Point(500, 38);
            this.cmbOrden.Name = "cmbOrden";
            this.cmbOrden.Size = new System.Drawing.Size(198, 21);
            this.cmbOrden.TabIndex = 12;
            this.cmbOrden.SelectedIndexChanged += new System.EventHandler(this.cmbOrden_SelectedIndexChanged);
            // 
            // cmbSexob
            // 
            this.cmbSexob.FormattingEnabled = true;
            this.cmbSexob.Location = new System.Drawing.Point(83, 38);
            this.cmbSexob.Name = "cmbSexob";
            this.cmbSexob.Size = new System.Drawing.Size(198, 21);
            this.cmbSexob.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(24, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sexo";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimir.Image = global::RA52M3.Properties.Resources.Imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(601, 191);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(130, 44);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Image = global::RA52M3.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(465, 191);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(130, 44);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Image = global::RA52M3.Properties.Resources.Eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(329, 191);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 44);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Image = global::RA52M3.Properties.Resources.Editar;
            this.btnEditar.Location = new System.Drawing.Point(193, 191);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 44);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Image = global::RA52M3.Properties.Resources.Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(57, 191);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 44);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.gbEstudianteRegistrados);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbDatosEstudiante);
            this.Name = "frmEstudiante";
            this.Text = "Registro de Estudiante";
            this.Load += new System.EventHandler(this.frmEstudiante_Load);
            this.gbDatosEstudiante.ResumeLayout(false);
            this.gbDatosEstudiante.PerformLayout();
            this.gbEstudianteRegistrados.ResumeLayout(false);
            this.gbEstudianteRegistrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosEstudiante;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox gbEstudianteRegistrados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbOrden;
        private System.Windows.Forms.ComboBox cmbSexob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.DataGridView dgvEstudiante;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.RadioButton rbApellidos;
        private System.Windows.Forms.RadioButton rbNombres;
    }
}

