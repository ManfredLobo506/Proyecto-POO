
namespace Proyecto
{
    partial class FrmMateriasIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMateriasIngreso));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualzar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtTotalHoras = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCOD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMaterias = new System.Windows.Forms.DataGridView();
            this.CodigoMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualzar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.txtTotalHoras);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCOD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 255);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso Materias";
            // 
            // btnActualzar
            // 
            this.btnActualzar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnActualzar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualzar.Image")));
            this.btnActualzar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualzar.Location = new System.Drawing.Point(204, 168);
            this.btnActualzar.Name = "btnActualzar";
            this.btnActualzar.Size = new System.Drawing.Size(92, 61);
            this.btnActualzar.TabIndex = 13;
            this.btnActualzar.Text = "Actualizar";
            this.btnActualzar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualzar.UseVisualStyleBackColor = true;
            this.btnActualzar.Click += new System.EventHandler(this.btnActualzar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(111, 168);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 61);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(17, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total de Horas";
            // 
            // btnIngresar
            // 
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIngresar.Location = new System.Drawing.Point(20, 168);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 61);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTotalHoras
            // 
            this.txtTotalHoras.Location = new System.Drawing.Point(178, 120);
            this.txtTotalHoras.Name = "txtTotalHoras";
            this.txtTotalHoras.Size = new System.Drawing.Size(101, 27);
            this.txtTotalHoras.TabIndex = 8;
            this.txtTotalHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalHoras_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(555, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 27);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCOD
            // 
            this.txtCOD.Location = new System.Drawing.Point(178, 45);
            this.txtCOD.Name = "txtCOD";
            this.txtCOD.Size = new System.Drawing.Size(252, 27);
            this.txtCOD.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(446, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
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
            // lstMaterias
            // 
            this.lstMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoMateria,
            this.Nombre,
            this.TotalHoras});
            this.lstMaterias.Location = new System.Drawing.Point(175, 380);
            this.lstMaterias.Name = "lstMaterias";
            this.lstMaterias.RowTemplate.Height = 25;
            this.lstMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstMaterias.Size = new System.Drawing.Size(495, 315);
            this.lstMaterias.TabIndex = 2;
            this.lstMaterias.DoubleClick += new System.EventHandler(this.lstMaterias_DoubleClick);
            // 
            // CodigoMateria
            // 
            this.CodigoMateria.DataPropertyName = "COD_MATERIA";
            this.CodigoMateria.HeaderText = "COD";
            this.CodigoMateria.Name = "CodigoMateria";
            this.CodigoMateria.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NOMBRE_MATERIA";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // TotalHoras
            // 
            this.TotalHoras.DataPropertyName = "TOTAL_HORAS_MATERIA";
            this.TotalHoras.HeaderText = "Total Horas";
            this.TotalHoras.Name = "TotalHoras";
            this.TotalHoras.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(175, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(245, 343);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(101, 23);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(586, 335);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(84, 31);
            this.btnSeleccionar.TabIndex = 14;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(696, 760);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 61);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMateriasIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 833);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lstMaterias);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMateriasIngreso";
            this.Text = "FrmMateriasIngreso";
            this.Load += new System.EventHandler(this.FrmMateriasIngreso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtTotalHoras;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCOD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView lstMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHoras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnActualzar;
        private System.Windows.Forms.Button btnSalir;
    }
}