
namespace Capa1Presentacion
{
    partial class FrmParaEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParaEstudiantes));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programarClaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notasToolStripMenuItem,
            this.programarClaseToolStripMenuItem,
            this.catalogoMateriasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            this.notasToolStripMenuItem.Click += new System.EventHandler(this.notasToolStripMenuItem_Click);
            // 
            // programarClaseToolStripMenuItem
            // 
            this.programarClaseToolStripMenuItem.Name = "programarClaseToolStripMenuItem";
            this.programarClaseToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.programarClaseToolStripMenuItem.Text = "Programar Clase";
            this.programarClaseToolStripMenuItem.Click += new System.EventHandler(this.programarClaseToolStripMenuItem_Click);
            // 
            // catalogoMateriasToolStripMenuItem
            // 
            this.catalogoMateriasToolStripMenuItem.Name = "catalogoMateriasToolStripMenuItem";
            this.catalogoMateriasToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.catalogoMateriasToolStripMenuItem.Text = "Catalogo Materias";
            this.catalogoMateriasToolStripMenuItem.Click += new System.EventHandler(this.catalogoMateriasToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(268, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 297);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmParaEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmParaEstudiantes";
            this.Text = "FrmParaEstudiantes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programarClaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoMateriasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}