namespace AsistenciaDetalle.UI.Registro
{
    partial class rAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rAsistencia));
            this.AsistenciaIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AsignaaturacomboBox = new System.Windows.Forms.ComboBox();
            this.EstudiantegroupBox = new System.Windows.Forms.GroupBox();
            this.AgregarEstudiantebutton = new System.Windows.Forms.Button();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.NuevoGridEstudianteButton = new System.Windows.Forms.Button();
            this.AsistenciadataGridView = new System.Windows.Forms.DataGridView();
            this.PresentecheckBox = new System.Windows.Forms.CheckBox();
            this.EstudiantecomboBox = new System.Windows.Forms.ComboBox();
            this.AsistenciaerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.Cantidadlabel = new System.Windows.Forms.Label();
            this.AgregarAsignaturabutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaIdnumericUpDown)).BeginInit();
            this.EstudiantegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AsistenciaIdnumericUpDown
            // 
            this.AsistenciaIdnumericUpDown.Location = new System.Drawing.Point(86, 13);
            this.AsistenciaIdnumericUpDown.Name = "AsistenciaIdnumericUpDown";
            this.AsistenciaIdnumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.AsistenciaIdnumericUpDown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AsistenciaId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Asignatura:";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Location = new System.Drawing.Point(219, 13);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(149, 20);
            this.FechadateTimePicker.TabIndex = 6;
            // 
            // AsignaaturacomboBox
            // 
            this.AsignaaturacomboBox.FormattingEnabled = true;
            this.AsignaaturacomboBox.Location = new System.Drawing.Point(86, 48);
            this.AsignaaturacomboBox.Name = "AsignaaturacomboBox";
            this.AsignaaturacomboBox.Size = new System.Drawing.Size(229, 21);
            this.AsignaaturacomboBox.TabIndex = 7;
            // 
            // EstudiantegroupBox
            // 
            this.EstudiantegroupBox.Controls.Add(this.AgregarEstudiantebutton);
            this.EstudiantegroupBox.Controls.Add(this.Removerbutton);
            this.EstudiantegroupBox.Controls.Add(this.NuevoGridEstudianteButton);
            this.EstudiantegroupBox.Controls.Add(this.AsistenciadataGridView);
            this.EstudiantegroupBox.Controls.Add(this.PresentecheckBox);
            this.EstudiantegroupBox.Controls.Add(this.EstudiantecomboBox);
            this.EstudiantegroupBox.Location = new System.Drawing.Point(15, 77);
            this.EstudiantegroupBox.Name = "EstudiantegroupBox";
            this.EstudiantegroupBox.Size = new System.Drawing.Size(353, 210);
            this.EstudiantegroupBox.TabIndex = 8;
            this.EstudiantegroupBox.TabStop = false;
            this.EstudiantegroupBox.Text = "Estudiantes";
            // 
            // AgregarEstudiantebutton
            // 
            this.AgregarEstudiantebutton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarEstudiantebutton.Image")));
            this.AgregarEstudiantebutton.Location = new System.Drawing.Point(175, 30);
            this.AgregarEstudiantebutton.Name = "AgregarEstudiantebutton";
            this.AgregarEstudiantebutton.Size = new System.Drawing.Size(41, 23);
            this.AgregarEstudiantebutton.TabIndex = 18;
            this.AgregarEstudiantebutton.UseVisualStyleBackColor = true;
            this.AgregarEstudiantebutton.Click += new System.EventHandler(this.AgregarEstudiantebutton_Click);
            // 
            // Removerbutton
            // 
            this.Removerbutton.Image = global::AsistenciaDetalle.Properties.Resources._5555555;
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(6, 187);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(103, 20);
            this.Removerbutton.TabIndex = 17;
            this.Removerbutton.Text = "Remover Fila";
            this.Removerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Removerbutton.UseVisualStyleBackColor = true;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // NuevoGridEstudianteButton
            // 
            this.NuevoGridEstudianteButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoGridEstudianteButton.Image")));
            this.NuevoGridEstudianteButton.Location = new System.Drawing.Point(306, 30);
            this.NuevoGridEstudianteButton.Name = "NuevoGridEstudianteButton";
            this.NuevoGridEstudianteButton.Size = new System.Drawing.Size(41, 23);
            this.NuevoGridEstudianteButton.TabIndex = 3;
            this.NuevoGridEstudianteButton.UseVisualStyleBackColor = true;
            this.NuevoGridEstudianteButton.Click += new System.EventHandler(this.NuevoEstudianteButton_Click);
            // 
            // AsistenciadataGridView
            // 
            this.AsistenciadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsistenciadataGridView.Location = new System.Drawing.Point(6, 59);
            this.AsistenciadataGridView.Name = "AsistenciadataGridView";
            this.AsistenciadataGridView.Size = new System.Drawing.Size(341, 122);
            this.AsistenciadataGridView.TabIndex = 2;
            // 
            // PresentecheckBox
            // 
            this.PresentecheckBox.AutoSize = true;
            this.PresentecheckBox.Location = new System.Drawing.Point(232, 30);
            this.PresentecheckBox.Name = "PresentecheckBox";
            this.PresentecheckBox.Size = new System.Drawing.Size(68, 17);
            this.PresentecheckBox.TabIndex = 1;
            this.PresentecheckBox.Text = "Presente";
            this.PresentecheckBox.UseVisualStyleBackColor = true;
            // 
            // EstudiantecomboBox
            // 
            this.EstudiantecomboBox.FormattingEnabled = true;
            this.EstudiantecomboBox.Location = new System.Drawing.Point(6, 30);
            this.EstudiantecomboBox.Name = "EstudiantecomboBox";
            this.EstudiantecomboBox.Size = new System.Drawing.Size(163, 21);
            this.EstudiantecomboBox.TabIndex = 0;
            this.EstudiantecomboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // AsistenciaerrorProvider
            // 
            this.AsistenciaerrorProvider.ContainerControl = this;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(70, 290);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(100, 20);
            this.CantidadtextBox.TabIndex = 14;
            // 
            // Cantidadlabel
            // 
            this.Cantidadlabel.AutoSize = true;
            this.Cantidadlabel.Location = new System.Drawing.Point(12, 290);
            this.Cantidadlabel.Name = "Cantidadlabel";
            this.Cantidadlabel.Size = new System.Drawing.Size(52, 13);
            this.Cantidadlabel.TabIndex = 15;
            this.Cantidadlabel.Text = "Cantidad:";
            // 
            // AgregarAsignaturabutton
            // 
            this.AgregarAsignaturabutton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarAsignaturabutton.Image")));
            this.AgregarAsignaturabutton.Location = new System.Drawing.Point(321, 48);
            this.AgregarAsignaturabutton.Name = "AgregarAsignaturabutton";
            this.AgregarAsignaturabutton.Size = new System.Drawing.Size(41, 23);
            this.AgregarAsignaturabutton.TabIndex = 13;
            this.AgregarAsignaturabutton.UseVisualStyleBackColor = true;
            this.AgregarAsignaturabutton.Click += new System.EventHandler(this.AgregarAsignaturabutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.Location = new System.Drawing.Point(133, 13);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(37, 20);
            this.Buscarbutton.TabIndex = 9;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.Location = new System.Drawing.Point(165, 319);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(57, 58);
            this.Guardarbutton.TabIndex = 16;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.Location = new System.Drawing.Point(102, 319);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(57, 58);
            this.Nuevobutton.TabIndex = 17;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.Location = new System.Drawing.Point(228, 319);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(57, 58);
            this.Eliminarbutton.TabIndex = 18;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // rAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 379);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Cantidadlabel);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.AgregarAsignaturabutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.EstudiantegroupBox);
            this.Controls.Add(this.AsignaaturacomboBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AsistenciaIdnumericUpDown);
            this.Name = "rAsistencia";
            this.Text = "rAsistencia";
            this.Load += new System.EventHandler(this.RAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaIdnumericUpDown)).EndInit();
            this.EstudiantegroupBox.ResumeLayout(false);
            this.EstudiantegroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown AsistenciaIdnumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.ComboBox AsignaaturacomboBox;
        private System.Windows.Forms.GroupBox EstudiantegroupBox;
        private System.Windows.Forms.Button NuevoGridEstudianteButton;
        private System.Windows.Forms.DataGridView AsistenciadataGridView;
        private System.Windows.Forms.CheckBox PresentecheckBox;
        private System.Windows.Forms.ComboBox EstudiantecomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider AsistenciaerrorProvider;
        private System.Windows.Forms.Button AgregarAsignaturabutton;
        private System.Windows.Forms.Label Cantidadlabel;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button AgregarEstudiantebutton;
    }
}