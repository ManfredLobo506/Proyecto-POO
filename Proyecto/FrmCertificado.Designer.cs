
namespace Capa1Presentacion
{
    partial class FrmCertificado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCertificado));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDcertfificado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lstCertificado = new System.Windows.Forms.DataGridView();
            this.CODCERTIFICADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCertificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstCertificado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod Certificado";
            // 
            // txtIDcertfificado
            // 
            this.txtIDcertfificado.Location = new System.Drawing.Point(115, 58);
            this.txtIDcertfificado.Name = "txtIDcertfificado";
            this.txtIDcertfificado.Size = new System.Drawing.Size(199, 23);
            this.txtIDcertfificado.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(502, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtIDp
            // 
            this.txtIDp.Location = new System.Drawing.Point(115, 112);
            this.txtIDp.Name = "txtIDp";
            this.txtIDp.Size = new System.Drawing.Size(199, 23);
            this.txtIDp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id Profesor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.txtIDp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIDcertfificado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 271);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Certificados Profesores";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(142, 172);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 63);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIngresar.Location = new System.Drawing.Point(19, 172);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(108, 63);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstCertificado
            // 
            this.lstCertificado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstCertificado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODCERTIFICADO,
            this.NombreCertificado,
            this.idProfesor});
            this.lstCertificado.Location = new System.Drawing.Point(155, 359);
            this.lstCertificado.Name = "lstCertificado";
            this.lstCertificado.RowTemplate.Height = 25;
            this.lstCertificado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstCertificado.Size = new System.Drawing.Size(493, 241);
            this.lstCertificado.TabIndex = 7;
            this.lstCertificado.DoubleClick += new System.EventHandler(this.lstCertificado_DoubleClick);
            // 
            // CODCERTIFICADO
            // 
            this.CODCERTIFICADO.DataPropertyName = "COD_CERTIFICADO";
            this.CODCERTIFICADO.HeaderText = "COD ";
            this.CODCERTIFICADO.Name = "CODCERTIFICADO";
            this.CODCERTIFICADO.Width = 150;
            // 
            // NombreCertificado
            // 
            this.NombreCertificado.DataPropertyName = "NOMBRE_CERTIFICADO";
            this.NombreCertificado.HeaderText = "Nombre Certificado";
            this.NombreCertificado.Name = "NombreCertificado";
            this.NombreCertificado.Width = 150;
            // 
            // idProfesor
            // 
            this.idProfesor.DataPropertyName = "IDENTIFICACION_P";
            this.idProfesor.HeaderText = "ID Profesor";
            this.idProfesor.Name = "idProfesor";
            this.idProfesor.Width = 150;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(225, 313);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(128, 23);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Id Profesor";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(680, 620);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 63);
            this.button2.TabIndex = 10;
            this.button2.Text = "Salir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(763, 761);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 23);
            this.textBox1.TabIndex = 11;
            // 
            // FrmCertificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 695);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lstCertificado);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCertificado";
            this.Text = "FrmCertificado";
            this.Load += new System.EventHandler(this.FrmCertificado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstCertificado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDcertfificado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView lstCertificado;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODCERTIFICADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCertificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfesor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}