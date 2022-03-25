
namespace Capa1Presentacion
{
    partial class FrmMateriasAbiertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMateriasAbiertas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDp = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.txtCodMateriaA = new System.Windows.Forms.TextBox();
            this.TxtCodMateria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstMateriasAbiertas = new System.Windows.Forms.DataGridView();
            this.CodmateriaAbierta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentificacionP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstMateriasAbiertas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCosto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIDp);
            this.groupBox1.Controls.Add(this.BtnEliminar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.txtCupo);
            this.groupBox1.Controls.Add(this.txtCodMateriaA);
            this.groupBox1.Controls.Add(this.TxtCodMateria);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 257);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso Materias";
            // 
            // btnActualizar
            // 
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizar.Location = new System.Drawing.Point(180, 190);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(88, 58);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(379, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(429, 99);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(101, 27);
            this.txtCosto.TabIndex = 17;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Identificacion P";
            // 
            // txtIDp
            // 
            this.txtIDp.Location = new System.Drawing.Point(129, 143);
            this.txtIDp.Name = "txtIDp";
            this.txtIDp.Size = new System.Drawing.Size(208, 27);
            this.txtIDp.TabIndex = 15;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminar.Location = new System.Drawing.Point(97, 190);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 58);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cupo";
            // 
            // btnIngresar
            // 
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIngresar.Location = new System.Drawing.Point(6, 190);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 58);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCupo
            // 
            this.txtCupo.Location = new System.Drawing.Point(129, 95);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(101, 27);
            this.txtCupo.TabIndex = 8;
            this.txtCupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCupo_KeyPress);
            // 
            // txtCodMateriaA
            // 
            this.txtCodMateriaA.Location = new System.Drawing.Point(429, 48);
            this.txtCodMateriaA.Name = "txtCodMateriaA";
            this.txtCodMateriaA.Size = new System.Drawing.Size(208, 27);
            this.txtCodMateriaA.TabIndex = 6;
            // 
            // TxtCodMateria
            // 
            this.TxtCodMateria.Location = new System.Drawing.Point(129, 45);
            this.TxtCodMateria.Name = "TxtCodMateria";
            this.TxtCodMateria.Size = new System.Drawing.Size(122, 27);
            this.TxtCodMateria.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(257, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo Materia Abierta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Materia ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(132, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "COD Materia Abierta";
            // 
            // lstMateriasAbiertas
            // 
            this.lstMateriasAbiertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstMateriasAbiertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodmateriaAbierta,
            this.CodMateria,
            this.Cupo,
            this.Costo,
            this.IdentificacionP});
            this.lstMateriasAbiertas.Location = new System.Drawing.Point(132, 334);
            this.lstMateriasAbiertas.Name = "lstMateriasAbiertas";
            this.lstMateriasAbiertas.RowTemplate.Height = 25;
            this.lstMateriasAbiertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstMateriasAbiertas.Size = new System.Drawing.Size(546, 242);
            this.lstMateriasAbiertas.TabIndex = 3;
            this.lstMateriasAbiertas.DoubleClick += new System.EventHandler(this.lstMateriasAbiertas_DoubleClick);
            // 
            // CodmateriaAbierta
            // 
            this.CodmateriaAbierta.DataPropertyName = "COD_MATERIA_ABIERTA";
            this.CodmateriaAbierta.HeaderText = "Cod Materia Abierta";
            this.CodmateriaAbierta.Name = "CodmateriaAbierta";
            // 
            // CodMateria
            // 
            this.CodMateria.DataPropertyName = "COD_MATERIA";
            this.CodMateria.HeaderText = "Cod Materia";
            this.CodMateria.Name = "CodMateria";
            // 
            // Cupo
            // 
            this.Cupo.DataPropertyName = "CUPO";
            this.Cupo.HeaderText = "Cupo";
            this.Cupo.Name = "Cupo";
            // 
            // Costo
            // 
            this.Costo.DataPropertyName = "COSTO";
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // IdentificacionP
            // 
            this.IdentificacionP.DataPropertyName = "IDENTIFICACION_P";
            this.IdentificacionP.HeaderText = "Identificacion P";
            this.IdentificacionP.Name = "IdentificacionP";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(286, 294);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(129, 23);
            this.txtBuscar.TabIndex = 16;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(603, 288);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 34);
            this.BtnSelect.TabIndex = 17;
            this.BtnSelect.Text = "Seleccionar";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir.Location = new System.Drawing.Point(700, 632);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(88, 55);
            this.BtnSalir.TabIndex = 20;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmMateriasAbiertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 699);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lstMateriasAbiertas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "FrmMateriasAbiertas";
            this.Text = "FrmMateriasAbiertas";
            this.Load += new System.EventHandler(this.FrmMateriasAbiertas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstMateriasAbiertas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.TextBox txtCodMateriaA;
        private System.Windows.Forms.TextBox TxtCodMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDp;
        private System.Windows.Forms.DataGridView lstMateriasAbiertas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodmateriaAbierta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificacionP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button BtnSalir;
    }
}