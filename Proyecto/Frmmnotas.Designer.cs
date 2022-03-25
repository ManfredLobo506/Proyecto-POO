
namespace Capa1Presentacion
{
    partial class Frmmnotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmmnotas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstNotas = new System.Windows.Forms.DataGridView();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstNotas);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Estudiante:";
            // 
            // lstNotas
            // 
            this.lstNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificacion,
            this.NombreMateria,
            this.Nota});
            this.lstNotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.lstNotas.Location = new System.Drawing.Point(13, 91);
            this.lstNotas.Name = "lstNotas";
            this.lstNotas.RowTemplate.Height = 25;
            this.lstNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstNotas.Size = new System.Drawing.Size(593, 325);
            this.lstNotas.TabIndex = 1;
            // 
            // Identificacion
            // 
            this.Identificacion.DataPropertyName = "IDENTIFICACION_E";
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Width = 150;
            // 
            // NombreMateria
            // 
            this.NombreMateria.DataPropertyName = "NOMBRE_MATERIA";
            this.NombreMateria.HeaderText = "Nombre Materia";
            this.NombreMateria.Name = "NombreMateria";
            this.NombreMateria.Width = 250;
            // 
            // Nota
            // 
            this.Nota.DataPropertyName = "NOTA";
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            this.Nota.Width = 150;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(98, 42);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(228, 23);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(541, 451);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 67);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frmmnotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 530);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frmmnotas";
            this.Text = "Frmmnotas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView lstNotas;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.Button btnSalir;
    }
}