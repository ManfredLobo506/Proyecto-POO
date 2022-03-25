
namespace Proyecto
{
    partial class FrmProgramarClase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProgramarClase));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDclase = new System.Windows.Forms.TextBox();
            this.txtHoraSalida = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DPfecha = new System.Windows.Forms.DateTimePicker();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtCodMateriaAbierta = new System.Windows.Forms.TextBox();
            this.txtIDEstudiante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LSTclases = new System.Windows.Forms.DataGridView();
            this.IDclase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDestudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_MATERIA_ABIERTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSTclases)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIDclase);
            this.groupBox1.Controls.Add(this.txtHoraSalida);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DPfecha);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.txtCodMateriaAbierta);
            this.groupBox1.Controls.Add(this.txtIDEstudiante);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programar Clase";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(4, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "ID Clase:";
            // 
            // txtIDclase
            // 
            this.txtIDclase.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIDclase.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIDclase.Location = new System.Drawing.Point(110, 26);
            this.txtIDclase.Multiline = true;
            this.txtIDclase.Name = "txtIDclase";
            this.txtIDclase.Size = new System.Drawing.Size(149, 27);
            this.txtIDclase.TabIndex = 34;
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtHoraSalida.FormattingEnabled = true;
            this.txtHoraSalida.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00"});
            this.txtHoraSalida.Location = new System.Drawing.Point(110, 127);
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(121, 28);
            this.txtHoraSalida.TabIndex = 33;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(270, 179);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(581, 56);
            this.textBox4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(477, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha:";
            // 
            // DPfecha
            // 
            this.DPfecha.Location = new System.Drawing.Point(556, 125);
            this.DPfecha.Name = "DPfecha";
            this.DPfecha.Size = new System.Drawing.Size(295, 27);
            this.DPfecha.TabIndex = 7;
            this.DPfecha.Value = new System.DateTime(2022, 2, 12, 0, 0, 0, 0);
            // 
            // btnIngresar
            // 
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIngresar.Location = new System.Drawing.Point(6, 172);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 65);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCodMateriaAbierta
            // 
            this.txtCodMateriaAbierta.Location = new System.Drawing.Point(652, 77);
            this.txtCodMateriaAbierta.Name = "txtCodMateriaAbierta";
            this.txtCodMateriaAbierta.Size = new System.Drawing.Size(199, 27);
            this.txtCodMateriaAbierta.TabIndex = 4;
            // 
            // txtIDEstudiante
            // 
            this.txtIDEstudiante.Location = new System.Drawing.Point(110, 73);
            this.txtIDEstudiante.Name = "txtIDEstudiante";
            this.txtIDEstudiante.Size = new System.Drawing.Size(199, 27);
            this.txtIDEstudiante.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(477, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Materia Abierta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Estudiante:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.LSTclases);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(10, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(866, 541);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clases Programadas";
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(752, 466);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 69);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(154, 40);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(199, 29);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(9, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cod Materia Abierta:";
            // 
            // LSTclases
            // 
            this.LSTclases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LSTclases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDclase,
            this.IDestudiante,
            this.COD_MATERIA_ABIERTA,
            this.DIA,
            this.HORA});
            this.LSTclases.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.LSTclases.Location = new System.Drawing.Point(45, 89);
            this.LSTclases.Name = "LSTclases";
            this.LSTclases.RowTemplate.Height = 25;
            this.LSTclases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LSTclases.Size = new System.Drawing.Size(793, 256);
            this.LSTclases.TabIndex = 0;
            // 
            // IDclase
            // 
            this.IDclase.DataPropertyName = "ID_CLASE";
            this.IDclase.HeaderText = "ID Clase";
            this.IDclase.Name = "IDclase";
            this.IDclase.Width = 150;
            // 
            // IDestudiante
            // 
            this.IDestudiante.DataPropertyName = "ID_ESTUDIANTE";
            this.IDestudiante.HeaderText = "ID Estudiante";
            this.IDestudiante.Name = "IDestudiante";
            this.IDestudiante.Width = 150;
            // 
            // COD_MATERIA_ABIERTA
            // 
            this.COD_MATERIA_ABIERTA.DataPropertyName = "COD_MATERIA_ABIERTA";
            this.COD_MATERIA_ABIERTA.HeaderText = "COD MATERIA ABIERTA";
            this.COD_MATERIA_ABIERTA.Name = "COD_MATERIA_ABIERTA";
            this.COD_MATERIA_ABIERTA.Width = 150;
            // 
            // DIA
            // 
            this.DIA.DataPropertyName = "DIA";
            this.DIA.HeaderText = "Dia";
            this.DIA.Name = "DIA";
            this.DIA.Width = 150;
            // 
            // HORA
            // 
            this.HORA.DataPropertyName = "HORA";
            this.HORA.HeaderText = "Hora";
            this.HORA.Name = "HORA";
            this.HORA.Width = 150;
            // 
            // FrmProgramarClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 817);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProgramarClase";
            this.Text = "FrmProgramarClase";
            this.Load += new System.EventHandler(this.FrmProgramarClase_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSTclases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DPfecha;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtCodMateriaAbierta;
        private System.Windows.Forms.TextBox txtIDEstudiante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView LSTclases;
        private System.Windows.Forms.ComboBox txtHoraSalida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDclase;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDclase;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDestudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_MATERIA_ABIERTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
    }
}