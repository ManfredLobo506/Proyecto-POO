
namespace Capa1Presentacion
{
    partial class FrmMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMatricula));
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnELiminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtidEstudiante = new System.Windows.Forms.TextBox();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMatriculas = new System.Windows.Forms.DataGridView();
            this.idMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmensaje
            // 
            this.txtmensaje.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtmensaje.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtmensaje.Location = new System.Drawing.Point(63, 103);
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(666, 50);
            this.txtmensaje.TabIndex = 9;
            this.txtmensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(370, 701);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 66);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIngresar.Location = new System.Drawing.Point(109, 169);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 58);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnELiminar
            // 
            this.btnELiminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnELiminar.Image = ((System.Drawing.Image)(resources.GetObject("btnELiminar.Image")));
            this.btnELiminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnELiminar.Location = new System.Drawing.Point(10, 169);
            this.btnELiminar.Name = "btnELiminar";
            this.btnELiminar.Size = new System.Drawing.Size(75, 58);
            this.btnELiminar.TabIndex = 6;
            this.btnELiminar.Text = "Eliminar";
            this.btnELiminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnELiminar.UseVisualStyleBackColor = true;
            this.btnELiminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnActualizar);
            this.groupBox1.Controls.Add(this.txtmensaje);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.btnELiminar);
            this.groupBox1.Controls.Add(this.txtidEstudiante);
            this.groupBox1.Controls.Add(this.txtEncargado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 234);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matricula";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.Image")));
            this.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnActualizar.Location = new System.Drawing.Point(203, 169);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(91, 58);
            this.BtnActualizar.TabIndex = 12;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(131, 34);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(115, 27);
            this.txtID.TabIndex = 11;
            // 
            // txtidEstudiante
            // 
            this.txtidEstudiante.Location = new System.Drawing.Point(359, 34);
            this.txtidEstudiante.Name = "txtidEstudiante";
            this.txtidEstudiante.Size = new System.Drawing.Size(135, 27);
            this.txtidEstudiante.TabIndex = 10;
            // 
            // txtEncargado
            // 
            this.txtEncargado.Location = new System.Drawing.Point(614, 34);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(115, 27);
            this.txtEncargado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(537, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Encargado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(270, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Estudiante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Matricula";
            // 
            // lstMatriculas
            // 
            this.lstMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstMatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMatricula,
            this.IdEst,
            this.Fecha,
            this.Encargado});
            this.lstMatriculas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.lstMatriculas.Location = new System.Drawing.Point(86, 329);
            this.lstMatriculas.Name = "lstMatriculas";
            this.lstMatriculas.RowTemplate.Height = 25;
            this.lstMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstMatriculas.Size = new System.Drawing.Size(641, 339);
            this.lstMatriculas.TabIndex = 9;
            this.lstMatriculas.DoubleClick += new System.EventHandler(this.lstMatriculas_DoubleClick);
            // 
            // idMatricula
            // 
            this.idMatricula.DataPropertyName = "ID_MATRICULA";
            this.idMatricula.HeaderText = "ID Matricula";
            this.idMatricula.Name = "idMatricula";
            this.idMatricula.Width = 150;
            // 
            // IdEst
            // 
            this.IdEst.DataPropertyName = "ID_ESTUDIANTE";
            this.IdEst.HeaderText = "Identificacion E";
            this.IdEst.Name = "IdEst";
            this.IdEst.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FECHA";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 150;
            // 
            // Encargado
            // 
            this.Encargado.DataPropertyName = "ENCARGADO";
            this.Encargado.HeaderText = "Encargado";
            this.Encargado.Name = "Encargado";
            this.Encargado.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID Matricula";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(98, 263);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(135, 23);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 779);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstMatriculas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMatricula";
            this.Text = "FrmMatricula";
            this.Load += new System.EventHandler(this.FrmMatricula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstMatriculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnELiminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtidEstudiante;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView lstMatriculas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encargado;
    }
}