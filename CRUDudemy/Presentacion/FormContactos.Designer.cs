namespace CRUDudemy.Presentacion
{
    partial class FormContactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContactos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTareas = new System.Windows.Forms.Panel();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonReporte = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonActualizar = new System.Windows.Forms.Button();
            this.botonNuevo = new System.Windows.Forms.Button();
            this.panelTrabajo = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.Listado = new System.Windows.Forms.DataGridView();
            this.Cargo = new System.Windows.Forms.ComboBox();
            this.FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTareas.SuspendLayout();
            this.panelTrabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Listado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "Panel titulo";
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 61);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(66, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mantenimiento de Contactos";
            // 
            // panelTareas
            // 
            this.panelTareas.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panelTareas.Controls.Add(this.botonSalir);
            this.panelTareas.Controls.Add(this.botonReporte);
            this.panelTareas.Controls.Add(this.botonEliminar);
            this.panelTareas.Controls.Add(this.botonActualizar);
            this.panelTareas.Controls.Add(this.botonNuevo);
            this.panelTareas.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTareas.Location = new System.Drawing.Point(764, 61);
            this.panelTareas.Name = "panelTareas";
            this.panelTareas.Size = new System.Drawing.Size(200, 395);
            this.panelTareas.TabIndex = 1;
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.Color.Firebrick;
            this.botonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSalir.FlatAppearance.BorderSize = 2;
            this.botonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSalir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonSalir.Location = new System.Drawing.Point(44, 322);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(115, 51);
            this.botonSalir.TabIndex = 4;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = false;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonReporte
            // 
            this.botonReporte.BackColor = System.Drawing.Color.DarkSlateGray;
            this.botonReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonReporte.FlatAppearance.BorderSize = 2;
            this.botonReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonReporte.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonReporte.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonReporte.Location = new System.Drawing.Point(44, 195);
            this.botonReporte.Name = "botonReporte";
            this.botonReporte.Size = new System.Drawing.Size(115, 51);
            this.botonReporte.TabIndex = 3;
            this.botonReporte.Text = "Reporte";
            this.botonReporte.UseVisualStyleBackColor = false;
            this.botonReporte.Click += new System.EventHandler(this.botonReporte_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.botonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonEliminar.FlatAppearance.BorderSize = 2;
            this.botonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEliminar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonEliminar.Location = new System.Drawing.Point(44, 138);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(115, 51);
            this.botonEliminar.TabIndex = 2;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = false;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonActualizar
            // 
            this.botonActualizar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.botonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonActualizar.FlatAppearance.BorderSize = 2;
            this.botonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonActualizar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonActualizar.Location = new System.Drawing.Point(44, 81);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(115, 51);
            this.botonActualizar.TabIndex = 1;
            this.botonActualizar.Text = "Actualizar";
            this.botonActualizar.UseVisualStyleBackColor = false;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // botonNuevo
            // 
            this.botonNuevo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.botonNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonNuevo.FlatAppearance.BorderSize = 2;
            this.botonNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonNuevo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonNuevo.Location = new System.Drawing.Point(44, 24);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(115, 51);
            this.botonNuevo.TabIndex = 0;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = false;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // panelTrabajo
            // 
            this.panelTrabajo.BackColor = System.Drawing.Color.LightBlue;
            this.panelTrabajo.Controls.Add(this.btnGuardar);
            this.panelTrabajo.Controls.Add(this.btnCancelar);
            this.panelTrabajo.Controls.Add(this.botonBuscar);
            this.panelTrabajo.Controls.Add(this.Buscar);
            this.panelTrabajo.Controls.Add(this.TelefonoLabel);
            this.panelTrabajo.Controls.Add(this.Listado);
            this.panelTrabajo.Controls.Add(this.Cargo);
            this.panelTrabajo.Controls.Add(this.FechaNacimiento);
            this.panelTrabajo.Controls.Add(this.label6);
            this.panelTrabajo.Controls.Add(this.label5);
            this.panelTrabajo.Controls.Add(this.Correo);
            this.panelTrabajo.Controls.Add(this.label4);
            this.panelTrabajo.Controls.Add(this.Telefono);
            this.panelTrabajo.Controls.Add(this.label3);
            this.panelTrabajo.Controls.Add(this.Nombre);
            this.panelTrabajo.Controls.Add(this.label2);
            this.panelTrabajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrabajo.Location = new System.Drawing.Point(0, 61);
            this.panelTrabajo.Name = "panelTrabajo";
            this.panelTrabajo.Size = new System.Drawing.Size(764, 395);
            this.panelTrabajo.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.Location = new System.Drawing.Point(549, 124);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 51);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(549, 22);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 51);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscar.Location = new System.Drawing.Point(268, 211);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 16;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(124, 213);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(127, 20);
            this.Buscar.TabIndex = 15;
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoLabel.Location = new System.Drawing.Point(48, 213);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(56, 20);
            this.TelefonoLabel.TabIndex = 14;
            this.TelefonoLabel.Text = "Buscar";
            // 
            // Listado
            // 
            this.Listado.AllowUserToAddRows = false;
            this.Listado.AllowUserToDeleteRows = false;
            this.Listado.AllowUserToOrderColumns = true;
            this.Listado.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listado.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Listado.Location = new System.Drawing.Point(52, 240);
            this.Listado.Name = "Listado";
            this.Listado.ReadOnly = true;
            this.Listado.Size = new System.Drawing.Size(660, 133);
            this.Listado.TabIndex = 13;
            this.Listado.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Listado_CellMouseClick);
            // 
            // Cargo
            // 
            this.Cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cargo.FormattingEnabled = true;
            this.Cargo.Location = new System.Drawing.Point(141, 93);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(272, 21);
            this.Cargo.TabIndex = 3;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimiento.Location = new System.Drawing.Point(241, 155);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(172, 20);
            this.FechaNacimiento.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cargo(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(141, 59);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(272, 20);
            this.Correo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Correo";
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(141, 126);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(272, 20);
            this.Telefono.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(141, 24);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(272, 20);
            this.Nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre(*)";
            // 
            // FormContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(964, 456);
            this.Controls.Add(this.panelTrabajo);
            this.Controls.Add(this.panelTareas);
            this.Controls.Add(this.panel1);
            this.Name = "FormContactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormContactos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTareas.ResumeLayout(false);
            this.panelTrabajo.ResumeLayout(false);
            this.panelTrabajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Listado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTareas;
        private System.Windows.Forms.Panel panelTrabajo;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonReporte;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonActualizar;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cargo;
        private System.Windows.Forms.DateTimePicker FechaNacimiento;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.DataGridView Listado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button botonBuscar;
    }
}