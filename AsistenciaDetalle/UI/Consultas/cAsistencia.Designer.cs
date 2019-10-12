namespace AsistenciaDetalle.UI.Consultas
{
    partial class cAsistencia
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
            this.Filtrolabel = new System.Windows.Forms.Label();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.Criteriolabel = new System.Windows.Forms.Label();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.Consultabutton = new System.Windows.Forms.Button();
            this.Hastalabel = new System.Windows.Forms.Label();
            this.Desdelabel = new System.Windows.Forms.Label();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Filtrolabel
            // 
            this.Filtrolabel.AutoSize = true;
            this.Filtrolabel.Location = new System.Drawing.Point(421, 5);
            this.Filtrolabel.Name = "Filtrolabel";
            this.Filtrolabel.Size = new System.Drawing.Size(29, 13);
            this.Filtrolabel.TabIndex = 19;
            this.Filtrolabel.Text = "Filtro";
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Todo",
            "ID"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(424, 20);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrocomboBox.TabIndex = 18;
            // 
            // Criteriolabel
            // 
            this.Criteriolabel.AutoSize = true;
            this.Criteriolabel.Location = new System.Drawing.Point(548, 5);
            this.Criteriolabel.Name = "Criteriolabel";
            this.Criteriolabel.Size = new System.Drawing.Size(39, 13);
            this.Criteriolabel.TabIndex = 17;
            this.Criteriolabel.Text = "Criterio";
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(551, 21);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(149, 20);
            this.CriteriotextBox.TabIndex = 16;
            // 
            // Consultabutton
            // 
            this.Consultabutton.Image = global::AsistenciaDetalle.Properties.Resources.icons8_borrar_búsqueda_24;
            this.Consultabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultabutton.Location = new System.Drawing.Point(706, 18);
            this.Consultabutton.Name = "Consultabutton";
            this.Consultabutton.Size = new System.Drawing.Size(82, 23);
            this.Consultabutton.TabIndex = 15;
            this.Consultabutton.Text = "Consulta";
            this.Consultabutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Consultabutton.UseVisualStyleBackColor = true;
            this.Consultabutton.Click += new System.EventHandler(this.Consultabutton_Click);
            // 
            // Hastalabel
            // 
            this.Hastalabel.AutoSize = true;
            this.Hastalabel.Location = new System.Drawing.Point(215, 5);
            this.Hastalabel.Name = "Hastalabel";
            this.Hastalabel.Size = new System.Drawing.Size(35, 13);
            this.Hastalabel.TabIndex = 14;
            this.Hastalabel.Text = "Hasta";
            // 
            // Desdelabel
            // 
            this.Desdelabel.AutoSize = true;
            this.Desdelabel.Location = new System.Drawing.Point(12, 5);
            this.Desdelabel.Name = "Desdelabel";
            this.Desdelabel.Size = new System.Drawing.Size(38, 13);
            this.Desdelabel.TabIndex = 13;
            this.Desdelabel.Text = "Desde";
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Location = new System.Drawing.Point(218, 21);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.HastadateTimePicker.TabIndex = 12;
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(12, 47);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.Size = new System.Drawing.Size(776, 387);
            this.ConsultadataGridView.TabIndex = 11;
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Location = new System.Drawing.Point(12, 21);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DesdedateTimePicker.TabIndex = 10;
            // 
            // cAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 444);
            this.Controls.Add(this.Filtrolabel);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.Criteriolabel);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.Consultabutton);
            this.Controls.Add(this.Hastalabel);
            this.Controls.Add(this.Desdelabel);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.ConsultadataGridView);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Name = "cAsistencia";
            this.Text = "ConsusltaAsistencia";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Filtrolabel;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Label Criteriolabel;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Button Consultabutton;
        private System.Windows.Forms.Label Hastalabel;
        private System.Windows.Forms.Label Desdelabel;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
    }
}