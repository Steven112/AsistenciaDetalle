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
            this.AsistenciaIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AsignaaturacomboBox = new System.Windows.Forms.ComboBox();
            this.EstudiantegroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NuevoEstudianteButton = new System.Windows.Forms.Button();
            this.AsistenciadataGridView = new System.Windows.Forms.DataGridView();
            this.PresentecheckBox = new System.Windows.Forms.CheckBox();
            this.EstudiantecomboBox = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaIdnumericUpDown)).BeginInit();
            this.EstudiantegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AsistenciaIdnumericUpDown
            // 
            this.AsistenciaIdnumericUpDown.Location = new System.Drawing.Point(77, 13);
            this.AsistenciaIdnumericUpDown.Name = "AsistenciaIdnumericUpDown";
            this.AsistenciaIdnumericUpDown.Size = new System.Drawing.Size(52, 20);
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
            this.AsignaaturacomboBox.Location = new System.Drawing.Point(77, 48);
            this.AsignaaturacomboBox.Name = "AsignaaturacomboBox";
            this.AsignaaturacomboBox.Size = new System.Drawing.Size(291, 21);
            this.AsignaaturacomboBox.TabIndex = 7;
            // 
            // EstudiantegroupBox
            // 
            this.EstudiantegroupBox.Controls.Add(this.label4);
            this.EstudiantegroupBox.Controls.Add(this.NuevoEstudianteButton);
            this.EstudiantegroupBox.Controls.Add(this.AsistenciadataGridView);
            this.EstudiantegroupBox.Controls.Add(this.PresentecheckBox);
            this.EstudiantegroupBox.Controls.Add(this.EstudiantecomboBox);
            this.EstudiantegroupBox.Location = new System.Drawing.Point(15, 90);
            this.EstudiantegroupBox.Name = "EstudiantegroupBox";
            this.EstudiantegroupBox.Size = new System.Drawing.Size(353, 187);
            this.EstudiantegroupBox.TabIndex = 8;
            this.EstudiantegroupBox.TabStop = false;
            this.EstudiantegroupBox.Text = "Estudiantes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estudiante:";
            // 
            // NuevoEstudianteButton
            // 
            this.NuevoEstudianteButton.Image = global::AsistenciaDetalle.Properties.Resources.icons8_más_26;
            this.NuevoEstudianteButton.Location = new System.Drawing.Point(278, 30);
            this.NuevoEstudianteButton.Name = "NuevoEstudianteButton";
            this.NuevoEstudianteButton.Size = new System.Drawing.Size(69, 23);
            this.NuevoEstudianteButton.TabIndex = 3;
            this.NuevoEstudianteButton.UseVisualStyleBackColor = true;
            this.NuevoEstudianteButton.Click += new System.EventHandler(this.NuevoEstudianteButton_Click);
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
            this.PresentecheckBox.Location = new System.Drawing.Point(204, 30);
            this.PresentecheckBox.Name = "PresentecheckBox";
            this.PresentecheckBox.Size = new System.Drawing.Size(68, 17);
            this.PresentecheckBox.TabIndex = 1;
            this.PresentecheckBox.Text = "Presente";
            this.PresentecheckBox.UseVisualStyleBackColor = true;
            // 
            // EstudiantecomboBox
            // 
            this.EstudiantecomboBox.FormattingEnabled = true;
            this.EstudiantecomboBox.Location = new System.Drawing.Point(77, 30);
            this.EstudiantecomboBox.Name = "EstudiantecomboBox";
            this.EstudiantecomboBox.Size = new System.Drawing.Size(121, 21);
            this.EstudiantecomboBox.TabIndex = 0;
            this.EstudiantecomboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Image = global::AsistenciaDetalle.Properties.Resources.icons8_eliminar_24;
            this.button5.Location = new System.Drawing.Point(228, 283);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 58);
            this.button5.TabIndex = 12;
            this.button5.Text = "Eliminar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::AsistenciaDetalle.Properties.Resources.icons8_guardar_30;
            this.button4.Location = new System.Drawing.Point(165, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 58);
            this.button4.TabIndex = 11;
            this.button4.Text = "Guardar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::AsistenciaDetalle.Properties.Resources.icons8_agregar_archivo_32;
            this.button3.Location = new System.Drawing.Point(102, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 60);
            this.button3.TabIndex = 10;
            this.button3.Text = "Nuevo";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::AsistenciaDetalle.Properties.Resources.icons8_borrar_búsqueda_24;
            this.Buscarbutton.Location = new System.Drawing.Point(135, 13);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(37, 23);
            this.Buscarbutton.TabIndex = 9;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // rAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 353);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
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
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaIdnumericUpDown)).EndInit();
            this.EstudiantegroupBox.ResumeLayout(false);
            this.EstudiantegroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciadataGridView)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button NuevoEstudianteButton;
        private System.Windows.Forms.DataGridView AsistenciadataGridView;
        private System.Windows.Forms.CheckBox PresentecheckBox;
        private System.Windows.Forms.ComboBox EstudiantecomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}