
namespace Capa1Presentacion
{
    partial class FrmHorarioP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHorarioP));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDia = new System.Windows.Forms.ComboBox();
            this.txtHoraEntrada = new System.Windows.Forms.ComboBox();
            this.txtHoraSalida = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LstHorarios = new System.Windows.Forms.DataGridView();
            this.CodHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDENTIFICACION_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LstHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDia);
            this.groupBox2.Controls.Add(this.txtHoraEntrada);
            this.groupBox2.Controls.Add(this.txtHoraSalida);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtBuscar);
            this.groupBox2.Controls.Add(this.LstHorarios);
            this.groupBox2.Controls.Add(this.txtCod);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TxtIdentificacion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 716);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horario Profesor";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtDia
            // 
            this.txtDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDia.FormattingEnabled = true;
            this.txtDia.Items.AddRange(new object[] {
            "lunes",
            "martes",
            "miércoles",
            "jueves",
            "viernes"});
            this.txtDia.Location = new System.Drawing.Point(319, 70);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(121, 28);
            this.txtDia.TabIndex = 34;
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtHoraEntrada.FormattingEnabled = true;
            this.txtHoraEntrada.Items.AddRange(new object[] {
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
            this.txtHoraEntrada.Location = new System.Drawing.Point(590, 70);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(121, 28);
            this.txtHoraEntrada.TabIndex = 33;
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
            this.txtHoraSalida.Location = new System.Drawing.Point(95, 134);
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(121, 28);
            this.txtHoraSalida.TabIndex = 32;
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(95, 194);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 59);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(607, 637);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 66);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(42, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Identificacion Profesor:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(189, 275);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(177, 27);
            this.TxtBuscar.TabIndex = 27;
            this.TxtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // LstHorarios
            // 
            this.LstHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LstHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodHorario,
            this.IDENTIFICACION_P,
            this.dia,
            this.Column1,
            this.HoraSalida});
            this.LstHorarios.Location = new System.Drawing.Point(42, 322);
            this.LstHorarios.Name = "LstHorarios";
            this.LstHorarios.RowTemplate.Height = 25;
            this.LstHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LstHorarios.Size = new System.Drawing.Size(693, 309);
            this.LstHorarios.TabIndex = 26;
            this.LstHorarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LstHorarios_CellContentClick);
            // 
            // CodHorario
            // 
            this.CodHorario.DataPropertyName = "ID_HORARIO";
            this.CodHorario.FillWeight = 150F;
            this.CodHorario.HeaderText = "Cod Horario";
            this.CodHorario.Name = "CodHorario";
            this.CodHorario.Width = 150;
            // 
            // IDENTIFICACION_P
            // 
            this.IDENTIFICACION_P.DataPropertyName = "IDENTIFICACION_P";
            this.IDENTIFICACION_P.FillWeight = 150F;
            this.IDENTIFICACION_P.HeaderText = "Identificacion P";
            this.IDENTIFICACION_P.Name = "IDENTIFICACION_P";
            this.IDENTIFICACION_P.Width = 150;
            // 
            // dia
            // 
            this.dia.DataPropertyName = "DIA";
            this.dia.FillWeight = 150F;
            this.dia.HeaderText = "Dia";
            this.dia.Name = "dia";
            this.dia.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HORA_ENTRADA";
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "Hora Entrada";
            this.Column1.Name = "Column1";
            // 
            // HoraSalida
            // 
            this.HoraSalida.DataPropertyName = "HORA_SALIDA";
            this.HoraSalida.FillWeight = 150F;
            this.HoraSalida.HeaderText = "Hora Salida";
            this.HoraSalida.Name = "HoraSalida";
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(131, 26);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(115, 27);
            this.txtCod.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Codigo Horario:";
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(14, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 59);
            this.button4.TabIndex = 21;
            this.button4.Text = "Ingresar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label10.Location = new System.Drawing.Point(10, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Hora Salida:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label9.Location = new System.Drawing.Point(495, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Hora Entrada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Location = new System.Drawing.Point(283, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dia:";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(131, 70);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(115, 27);
            this.TxtIdentificacion.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Location = new System.Drawing.Point(10, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Identificación:";
            // 
            // FrmHorarioP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 727);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmHorarioP";
            this.Text = "FrmHorarioP";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LstHorarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView LstHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDENTIFICACION_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSalida;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox txtHoraEntrada;
        private System.Windows.Forms.ComboBox txtHoraSalida;
        private System.Windows.Forms.ComboBox txtDia;
    }
}