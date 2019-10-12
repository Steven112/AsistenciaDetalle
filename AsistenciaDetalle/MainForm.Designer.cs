namespace AsistenciaDetalle
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroAsignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaAsignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroAsistenciaToolStripMenuItem,
            this.registroEstudianteToolStripMenuItem,
            this.registroAsignaturaToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registroAsistenciaToolStripMenuItem
            // 
            this.registroAsistenciaToolStripMenuItem.Name = "registroAsistenciaToolStripMenuItem";
            this.registroAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroAsistenciaToolStripMenuItem.Text = "Registro Asistencia";
            this.registroAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.RegistroAsistenciaToolStripMenuItem_Click);
            // 
            // registroEstudianteToolStripMenuItem
            // 
            this.registroEstudianteToolStripMenuItem.Name = "registroEstudianteToolStripMenuItem";
            this.registroEstudianteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroEstudianteToolStripMenuItem.Text = "Registro Estudiante";
            this.registroEstudianteToolStripMenuItem.Click += new System.EventHandler(this.RegistroEstudianteToolStripMenuItem_Click);
            // 
            // registroAsignaturaToolStripMenuItem
            // 
            this.registroAsignaturaToolStripMenuItem.Name = "registroAsignaturaToolStripMenuItem";
            this.registroAsignaturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroAsignaturaToolStripMenuItem.Text = "Registro Asignatura";
            this.registroAsignaturaToolStripMenuItem.Click += new System.EventHandler(this.RegistroAsignaturaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaAsistenciaToolStripMenuItem,
            this.consultaEstudianteToolStripMenuItem,
            this.consultaAsignaturaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaAsistenciaToolStripMenuItem
            // 
            this.consultaAsistenciaToolStripMenuItem.Name = "consultaAsistenciaToolStripMenuItem";
            this.consultaAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultaAsistenciaToolStripMenuItem.Text = "Consulta Asistencia";
            this.consultaAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.ConsultaAsistenciaToolStripMenuItem_Click);
            // 
            // consultaEstudianteToolStripMenuItem
            // 
            this.consultaEstudianteToolStripMenuItem.Name = "consultaEstudianteToolStripMenuItem";
            this.consultaEstudianteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultaEstudianteToolStripMenuItem.Text = "Consulta Estudiante";
            this.consultaEstudianteToolStripMenuItem.Click += new System.EventHandler(this.ConsultaEstudianteToolStripMenuItem_Click);
            // 
            // consultaAsignaturaToolStripMenuItem
            // 
            this.consultaAsignaturaToolStripMenuItem.Name = "consultaAsignaturaToolStripMenuItem";
            this.consultaAsignaturaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultaAsignaturaToolStripMenuItem.Text = "Consulta Asignatura";
            this.consultaAsignaturaToolStripMenuItem.Click += new System.EventHandler(this.ConsultaAsignaturaToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroAsignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaAsignaturaToolStripMenuItem;
    }
}

