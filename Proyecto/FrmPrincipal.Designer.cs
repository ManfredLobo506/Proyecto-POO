
namespace Capa1Presentacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diasNoLectivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarMateriaAbiertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matriculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horarioProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleMatriculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programarClaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiantesToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.matriculasToolStripMenuItem,
            this.horarioProfesorToolStripMenuItem,
            this.detalleMatriculasToolStripMenuItem,
            this.programarClaseToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem.Click += new System.EventHandler(this.estudiantesToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.certificadosToolStripMenuItem,
            this.diasNoLectivosToolStripMenuItem,
            this.profesoresToolStripMenuItem1});
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // certificadosToolStripMenuItem
            // 
            this.certificadosToolStripMenuItem.Name = "certificadosToolStripMenuItem";
            this.certificadosToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.certificadosToolStripMenuItem.Text = "Certificados";
            this.certificadosToolStripMenuItem.Click += new System.EventHandler(this.certificadosToolStripMenuItem_Click);
            // 
            // diasNoLectivosToolStripMenuItem
            // 
            this.diasNoLectivosToolStripMenuItem.Name = "diasNoLectivosToolStripMenuItem";
            this.diasNoLectivosToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.diasNoLectivosToolStripMenuItem.Text = "Dias no lectivos";
            this.diasNoLectivosToolStripMenuItem.Click += new System.EventHandler(this.diasNoLectivosToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem1
            // 
            this.profesoresToolStripMenuItem1.Name = "profesoresToolStripMenuItem1";
            this.profesoresToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.profesoresToolStripMenuItem1.Text = "Profesores";
            this.profesoresToolStripMenuItem1.Click += new System.EventHandler(this.profesoresToolStripMenuItem1_Click);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarMateriaToolStripMenuItem,
            this.ingresarMateriaAbiertaToolStripMenuItem});
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // ingresarMateriaToolStripMenuItem
            // 
            this.ingresarMateriaToolStripMenuItem.Name = "ingresarMateriaToolStripMenuItem";
            this.ingresarMateriaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ingresarMateriaToolStripMenuItem.Text = "Ingresar Materia";
            this.ingresarMateriaToolStripMenuItem.Click += new System.EventHandler(this.ingresarMateriaToolStripMenuItem_Click);
            // 
            // ingresarMateriaAbiertaToolStripMenuItem
            // 
            this.ingresarMateriaAbiertaToolStripMenuItem.Name = "ingresarMateriaAbiertaToolStripMenuItem";
            this.ingresarMateriaAbiertaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ingresarMateriaAbiertaToolStripMenuItem.Text = "Ingresar Materia Abierta";
            this.ingresarMateriaAbiertaToolStripMenuItem.Click += new System.EventHandler(this.ingresarMateriaAbiertaToolStripMenuItem_Click);
            // 
            // matriculasToolStripMenuItem
            // 
            this.matriculasToolStripMenuItem.Name = "matriculasToolStripMenuItem";
            this.matriculasToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.matriculasToolStripMenuItem.Text = "Matriculas";
            this.matriculasToolStripMenuItem.Click += new System.EventHandler(this.matriculasToolStripMenuItem_Click);
            // 
            // horarioProfesorToolStripMenuItem
            // 
            this.horarioProfesorToolStripMenuItem.Name = "horarioProfesorToolStripMenuItem";
            this.horarioProfesorToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.horarioProfesorToolStripMenuItem.Text = "Horario Profesor";
            this.horarioProfesorToolStripMenuItem.Click += new System.EventHandler(this.horarioProfesorToolStripMenuItem_Click);
            // 
            // detalleMatriculasToolStripMenuItem
            // 
            this.detalleMatriculasToolStripMenuItem.Name = "detalleMatriculasToolStripMenuItem";
            this.detalleMatriculasToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.detalleMatriculasToolStripMenuItem.Text = "Detalle Matriculas";
            this.detalleMatriculasToolStripMenuItem.Click += new System.EventHandler(this.detalleMatriculasToolStripMenuItem_Click);
            // 
            // programarClaseToolStripMenuItem
            // 
            this.programarClaseToolStripMenuItem.Name = "programarClaseToolStripMenuItem";
            this.programarClaseToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.programarClaseToolStripMenuItem.Text = "Programar Clase";
            this.programarClaseToolStripMenuItem.Click += new System.EventHandler(this.programarClaseToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            this.notasToolStripMenuItem.Click += new System.EventHandler(this.notasToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(242, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 227);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarMateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarMateriaAbiertaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matriculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horarioProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleMatriculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diasNoLectivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem programarClaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}