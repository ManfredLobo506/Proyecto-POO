
namespace Proyecto
{
    partial class FrmMaterias
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LSTmaterias = new System.Windows.Forms.DataGridView();
            this.COD_MATERIA_ABIERTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDENTIFICACIONP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CodMateriaAbierta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSTmaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.LSTmaterias);
            this.groupBox1.Controls.Add(this.txtNombreM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 550);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materias";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LSTmaterias
            // 
            this.LSTmaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LSTmaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_MATERIA_ABIERTA,
            this.dataGridViewTextBoxColumn1,
            this.CUPO,
            this.dataGridViewTextBoxColumn2,
            this.IDENTIFICACIONP});
            this.LSTmaterias.Location = new System.Drawing.Point(-6, 155);
            this.LSTmaterias.Name = "LSTmaterias";
            this.LSTmaterias.RowTemplate.Height = 25;
            this.LSTmaterias.Size = new System.Drawing.Size(841, 253);
            this.LSTmaterias.TabIndex = 2;
            // 
            // COD_MATERIA_ABIERTA
            // 
            this.COD_MATERIA_ABIERTA.DataPropertyName = "COD_MATERIA_ABIERTA";
            this.COD_MATERIA_ABIERTA.HeaderText = "COD MATERIA ABIERTA";
            this.COD_MATERIA_ABIERTA.Name = "COD_MATERIA_ABIERTA";
            this.COD_MATERIA_ABIERTA.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE_MATERIA";
            this.dataGridViewTextBoxColumn1.HeaderText = "NOMBRE MATERIA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // CUPO
            // 
            this.CUPO.DataPropertyName = "CUPO";
            this.CUPO.HeaderText = "CUPO";
            this.CUPO.Name = "CUPO";
            this.CUPO.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "COSTO";
            this.dataGridViewTextBoxColumn2.HeaderText = "COSTO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // IDENTIFICACIONP
            // 
            this.IDENTIFICACIONP.DataPropertyName = "IDENTIFICACION_P";
            this.IDENTIFICACIONP.HeaderText = "IDENTIFICACION PROFESOR";
            this.IDENTIFICACIONP.Name = "IDENTIFICACIONP";
            this.IDENTIFICACIONP.Width = 150;
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(153, 47);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(303, 29);
            this.txtNombreM.TabIndex = 1;
            this.txtNombreM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Materia:";
            // 
            // CodMateriaAbierta
            // 
            this.CodMateriaAbierta.DataPropertyName = " COD_MATERIA_ABIERTA";
            this.CodMateriaAbierta.HeaderText = "Codigo Materia Abierta";
            this.CodMateriaAbierta.Name = "CodMateriaAbierta";
            this.CodMateriaAbierta.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NOMBRE_MATERIA";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 370;
            // 
            // Cupos
            // 
            this.Cupos.DataPropertyName = "CUPO";
            this.Cupos.HeaderText = "Cupos";
            this.Cupos.Name = "Cupos";
            this.Cupos.Width = 150;
            // 
            // COSTO
            // 
            this.COSTO.HeaderText = "COSTO";
            this.COSTO.Name = "COSTO";
            // 
            // FrmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 603);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMaterias";
            this.Text = "FrmMaterias";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSTmaterias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView LSTmaterias;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodMateriaAbierta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupos;
        private System.Windows.Forms.DataGridViewTextBoxColumn COSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_MATERIA_ABIERTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDENTIFICACIONP;
    }
}