
namespace Capa1Presentacion
{
    partial class FrmDiasNoLectivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiasNoLectivos));
            this.lstDias = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lstNolectivos = new System.Windows.Forms.DataGridView();
            this.COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDENTIFICACIONP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.timePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentificacionP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCOD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstDias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstNolectivos)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDias
            // 
            this.lstDias.Controls.Add(this.btnSelect);
            this.lstDias.Controls.Add(this.label5);
            this.lstDias.Controls.Add(this.txtBuscar);
            this.lstDias.Controls.Add(this.lstNolectivos);
            this.lstDias.Controls.Add(this.btnEliminar);
            this.lstDias.Controls.Add(this.btnIngresar);
            this.lstDias.Controls.Add(this.timePickerFecha);
            this.lstDias.Controls.Add(this.label4);
            this.lstDias.Controls.Add(this.txtMotivo);
            this.lstDias.Controls.Add(this.label3);
            this.lstDias.Controls.Add(this.txtIdentificacionP);
            this.lstDias.Controls.Add(this.label2);
            this.lstDias.Controls.Add(this.txtCOD);
            this.lstDias.Controls.Add(this.label1);
            this.lstDias.Location = new System.Drawing.Point(12, 4);
            this.lstDias.Name = "lstDias";
            this.lstDias.Size = new System.Drawing.Size(765, 665);
            this.lstDias.TabIndex = 0;
            this.lstDias.TabStop = false;
            this.lstDias.Text = "Dias No Lectivos";
            // 
            // btnSelect
            // 
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelect.Location = new System.Drawing.Point(354, 319);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(109, 52);
            this.btnSelect.TabIndex = 13;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID profesor";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(133, 335);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(215, 23);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // lstNolectivos
            // 
            this.lstNolectivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstNolectivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD,
            this.IDENTIFICACIONP,
            this.MOTIVO,
            this.FECHA});
            this.lstNolectivos.Location = new System.Drawing.Point(55, 377);
            this.lstNolectivos.Name = "lstNolectivos";
            this.lstNolectivos.RowTemplate.Height = 25;
            this.lstNolectivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstNolectivos.Size = new System.Drawing.Size(642, 273);
            this.lstNolectivos.TabIndex = 10;
            this.lstNolectivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstNolectivos_CellContentClick);
            // 
            // COD
            // 
            this.COD.DataPropertyName = "COD";
            this.COD.HeaderText = "COD";
            this.COD.Name = "COD";
            this.COD.Width = 150;
            // 
            // IDENTIFICACIONP
            // 
            this.IDENTIFICACIONP.DataPropertyName = "IDENTIFICACION_P";
            this.IDENTIFICACIONP.HeaderText = "IDENTIFICACION P";
            this.IDENTIFICACIONP.Name = "IDENTIFICACIONP";
            this.IDENTIFICACIONP.Width = 150;
            // 
            // MOTIVO
            // 
            this.MOTIVO.DataPropertyName = "MOTIVO";
            this.MOTIVO.HeaderText = "MOTIVO";
            this.MOTIVO.Name = "MOTIVO";
            this.MOTIVO.Width = 150;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.Width = 150;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(163, 198);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 61);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIngresar.Location = new System.Drawing.Point(29, 198);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(109, 61);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // timePickerFecha
            // 
            this.timePickerFecha.Location = new System.Drawing.Point(478, 106);
            this.timePickerFecha.Name = "timePickerFecha";
            this.timePickerFecha.Size = new System.Drawing.Size(200, 23);
            this.timePickerFecha.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(73, 109);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(215, 23);
            this.txtMotivo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Motivo";
            // 
            // txtIdentificacionP
            // 
            this.txtIdentificacionP.Location = new System.Drawing.Point(463, 48);
            this.txtIdentificacionP.Name = "txtIdentificacionP";
            this.txtIdentificacionP.Size = new System.Drawing.Size(215, 23);
            this.txtIdentificacionP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificacion P";
            // 
            // txtCOD
            // 
            this.txtCOD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCOD.Location = new System.Drawing.Point(73, 45);
            this.txtCOD.Name = "txtCOD";
            this.txtCOD.Size = new System.Drawing.Size(215, 23);
            this.txtCOD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "COD";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(679, 684);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 61);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmDiasNoLectivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 757);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstDias);
            this.Name = "FrmDiasNoLectivos";
            this.Text = "FrmDiasNoLectivos";
            this.Load += new System.EventHandler(this.FrmDiasNoLectivos_Load);
            this.lstDias.ResumeLayout(false);
            this.lstDias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstNolectivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lstDias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.DateTimePicker timePickerFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdentificacionP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCOD;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView lstNolectivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDENTIFICACIONP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSalir;
    }
}