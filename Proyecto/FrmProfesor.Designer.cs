
namespace Proyecto
{
    partial class FrmProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfesor));
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnEliminarProfesor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.LstProfesores = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.txtAp1 = new System.Windows.Forms.TextBox();
            this.txtAp2 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LstProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(75, 203);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(666, 50);
            this.textBox7.TabIndex = 9;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIngresar
            // 
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIngresar.Location = new System.Drawing.Point(116, 272);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(87, 62);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminarProfesor
            // 
            this.btnEliminarProfesor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarProfesor.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProfesor.Image")));
            this.btnEliminarProfesor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarProfesor.Location = new System.Drawing.Point(10, 272);
            this.btnEliminarProfesor.Name = "btnEliminarProfesor";
            this.btnEliminarProfesor.Size = new System.Drawing.Size(87, 62);
            this.btnEliminarProfesor.TabIndex = 6;
            this.btnEliminarProfesor.Text = "Eliminar";
            this.btnEliminarProfesor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarProfesor.UseVisualStyleBackColor = true;
            this.btnEliminarProfesor.Click += new System.EventHandler(this.btnEliminarProfesor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.LstProfesores);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.btnEliminarProfesor);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.txtTel1);
            this.groupBox1.Controls.Add(this.txtAp1);
            this.groupBox1.Controls.Add(this.txtAp2);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 838);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profesor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(645, 338);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(107, 31);
            this.btnSeleccionar.TabIndex = 16;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizar.Location = new System.Drawing.Point(219, 272);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(91, 62);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(131, 34);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(115, 27);
            this.txtID.TabIndex = 11;
            // 
            // LstProfesores
            // 
            this.LstProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LstProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.PrimerApellido,
            this.SegundoApellido,
            this.Telefono,
            this.correo});
            this.LstProfesores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.LstProfesores.Location = new System.Drawing.Point(10, 432);
            this.LstProfesores.Name = "LstProfesores";
            this.LstProfesores.RowTemplate.Height = 25;
            this.LstProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LstProfesores.Size = new System.Drawing.Size(757, 333);
            this.LstProfesores.TabIndex = 15;
            this.LstProfesores.DoubleClick += new System.EventHandler(this.LstProfesores_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IDENTIFICACION_P";
            this.Id.HeaderText = "IDENTIFICACION";
            this.Id.Name = "Id";
            this.Id.Width = 120;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NOMBRE_P";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 120;
            // 
            // PrimerApellido
            // 
            this.PrimerApellido.DataPropertyName = "APELLIDO1_P";
            this.PrimerApellido.HeaderText = "Primer Apellido";
            this.PrimerApellido.Name = "PrimerApellido";
            this.PrimerApellido.Width = 120;
            // 
            // SegundoApellido
            // 
            this.SegundoApellido.DataPropertyName = "APELLIDO2_P";
            this.SegundoApellido.HeaderText = "Segundo Apellido";
            this.SegundoApellido.Name = "SegundoApellido";
            this.SegundoApellido.Width = 120;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "NUMERO_TELEFONICO_P";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 120;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "CORREO_ELECTRONICO_P";
            this.correo.HeaderText = "Correo Electronico";
            this.correo.Name = "correo";
            this.correo.Width = 120;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(336, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 27);
            this.txtName.TabIndex = 10;
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(336, 92);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(135, 27);
            this.txtTel1.TabIndex = 9;
            this.txtTel1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel1_KeyPress);
            // 
            // txtAp1
            // 
            this.txtAp1.Location = new System.Drawing.Point(614, 34);
            this.txtAp1.Name = "txtAp1";
            this.txtAp1.Size = new System.Drawing.Size(115, 27);
            this.txtAp1.TabIndex = 8;
            // 
            // txtAp2
            // 
            this.txtAp2.Location = new System.Drawing.Point(131, 92);
            this.txtAp2.Name = "txtAp2";
            this.txtAp2.Size = new System.Drawing.Size(115, 27);
            this.txtAp2.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(614, 92);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(115, 27);
            this.txtEmail.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(269, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(488, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo Electronico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(507, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Primer Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(270, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(115, 364);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(115, 23);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Location = new System.Drawing.Point(22, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID Profesor:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(707, 783);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 59);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 849);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProfesor";
            this.Text = "Profesor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LstProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnEliminarProfesor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTel1;
        private System.Windows.Forms.TextBox txtAp1;
        private System.Windows.Forms.TextBox txtAp2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView LstProfesores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
    }
}