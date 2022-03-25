
namespace Proyecto
{
    partial class FrmDetalleMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleMatricula));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDdetalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtCodMateriaA = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.LSTdetalle = new System.Windows.Forms.DataGridView();
            this.IDdetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodMateriaAbierta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSTdetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtNota);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIDdetalle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.txtCodMateriaA);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(19, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(990, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Matriculas";
            // 
            // btnActualizar
            // 
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizar.Location = new System.Drawing.Point(227, 156);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 80);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFecha.Location = new System.Drawing.Point(802, 99);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(177, 27);
            this.txtFecha.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(642, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Finalizacion del curso:";
            // 
            // txtEstado
            // 
            this.txtEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Items.AddRange(new object[] {
            "CANCELADO",
            "PENDIENTE"});
            this.txtEstado.Location = new System.Drawing.Point(483, 99);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(121, 28);
            this.txtEstado.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(384, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(117, 156);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 80);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(153, 102);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(216, 27);
            this.txtNota.TabIndex = 8;
            this.txtNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(11, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nota:";
            // 
            // txtIDdetalle
            // 
            this.txtIDdetalle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIDdetalle.Location = new System.Drawing.Point(153, 52);
            this.txtIDdetalle.Name = "txtIDdetalle";
            this.txtIDdetalle.Size = new System.Drawing.Size(216, 27);
            this.txtIDdetalle.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(11, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID Detalle Matricula:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIngresar.Location = new System.Drawing.Point(7, 156);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(104, 80);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCodMateriaA
            // 
            this.txtCodMateriaA.Location = new System.Drawing.Point(880, 52);
            this.txtCodMateriaA.Name = "txtCodMateriaA";
            this.txtCodMateriaA.Size = new System.Drawing.Size(99, 27);
            this.txtCodMateriaA.TabIndex = 5;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(483, 53);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(216, 27);
            this.txtMatricula.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(705, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo Materia Abierta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(384, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Matricula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Detalle Matricula:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(160, 42);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(216, 27);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Controls.Add(this.LSTdetalle);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(21, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(987, 430);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notas";
            // 
            // btnSelect
            // 
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelect.Location = new System.Drawing.Point(584, 130);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(104, 55);
            this.btnSelect.TabIndex = 13;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // LSTdetalle
            // 
            this.LSTdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LSTdetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDdetalle,
            this.ID_Matricula,
            this.CodMateriaAbierta,
            this.Nota,
            this.Estado});
            this.LSTdetalle.Location = new System.Drawing.Point(20, 130);
            this.LSTdetalle.Name = "LSTdetalle";
            this.LSTdetalle.RowTemplate.Height = 25;
            this.LSTdetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LSTdetalle.Size = new System.Drawing.Size(545, 211);
            this.LSTdetalle.TabIndex = 4;
            this.LSTdetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LSTdetalle_CellContentClick);
            // 
            // IDdetalle
            // 
            this.IDdetalle.DataPropertyName = "ID_DETALLEMATRICULA";
            this.IDdetalle.HeaderText = "ID detalle";
            this.IDdetalle.Name = "IDdetalle";
            // 
            // ID_Matricula
            // 
            this.ID_Matricula.DataPropertyName = "ID_MATRICULA";
            this.ID_Matricula.HeaderText = "ID Matricula";
            this.ID_Matricula.Name = "ID_Matricula";
            // 
            // CodMateriaAbierta
            // 
            this.CodMateriaAbierta.DataPropertyName = "COD_MATERIA_ABIERTA";
            this.CodMateriaAbierta.HeaderText = "Cod Materia Abierta";
            this.CodMateriaAbierta.Name = "CodMateriaAbierta";
            // 
            // Nota
            // 
            this.Nota.DataPropertyName = "NOTA";
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "CANCELADO";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(926, 709);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 62);
            this.button3.TabIndex = 7;
            this.button3.Text = "Salir";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmDetalleMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 817);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDetalleMatricula";
            this.Text = "FrmNotas";
            this.Load += new System.EventHandler(this.FrmDetalleMatricula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSTdetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIDdetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtCodMateriaA;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView LSTdetalle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDdetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodMateriaAbierta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnActualizar;
    }
}