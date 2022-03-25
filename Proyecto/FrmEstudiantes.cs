using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa4Entidades;
using Capa2Logica;
using Capa1Presentacion;



namespace Proyecto
{
    public partial class FrmEstudiantes : Form
    {
        public FrmEstudiantes()
        {
            InitializeComponent();
        }

        public EntidadEstudiantes GeneraraEntidadEstudiante()
        {
            EntidadEstudiantes estudiante = new EntidadEstudiantes();
            
            estudiante.Nombre=(txtName.Text);
            estudiante.Apellido1=(txtlstname1.Text);
            estudiante.Apellido2=(txtlstname2.Text);
            estudiante.Identificacion=(txtID.Text);
            estudiante.NumeroTelefonico=(txtphoneN.Text);
            estudiante.CorreoElectronico=(txtmail.Text);


            return estudiante;
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLestudiante Logica = new BLestudiante(Configuracion.getConnetionString);
            DataSet DS;

            try
            {
                DS = Logica.ListarEstudiante(condicion, orden);
                LstEstudiantes.DataSource = DS;
                LstEstudiantes.DataMember = DS.Tables["ESTUDIANTES"].TableName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void limpiar()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtlstname1.Text = "";
            txtlstname2.Text = "";
            txtmail.Text = "";
            txtphoneN.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntidadEstudiantes estudiante = new EntidadEstudiantes();
           BLestudiante logica = new BLestudiante(Configuracion.getConnetionString);

            int resultado;

            try
            {
                if (string.IsNullOrEmpty(txtName.Text) ||
                    string.IsNullOrEmpty(txtlstname1.Text) ||
                    string.IsNullOrEmpty(txtlstname2.Text) || 
                    string.IsNullOrEmpty(txtID.Text) ||
                    string.IsNullOrEmpty(txtmail.Text) ||
                    string.IsNullOrEmpty(txtphoneN.Text))
                {
                    MessageBox.Show("Datos Incompletos. Favor Completar todos los datos", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    estudiante = GeneraraEntidadEstudiante();
                    resultado = logica.Insertar(estudiante);
                    MessageBox.Show("Operacion Realizada con Exito", "LISTO", MessageBoxButtons.OK);
                    CargarListaDataSet();
                    limpiar();

                }
            }
           
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EntidadEstudiantes estudiante = new EntidadEstudiantes();
            estudiante.Identificacion=(txtID.Text);
            int resultado;
            BLestudiante logica = new BLestudiante(Configuracion.getConnetionString);

            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    resultado = logica.ElminarConSP(estudiante);
                    MessageBox.Show(logica.Mensaje, "aviso", MessageBoxButtons.OK);
                    CargarListaDataSet();


                }
                else
                {
                    MessageBox.Show("Debe seleccionar un producto antes de eliminarlo", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string condicion = "";
            try
            {
                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {
                    condicion = string.Format("IDENTIFICACION_E like '%{0}%'", txtBuscar.Text.Trim());
                }

                CargarListaDataSet(condicion);


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LstEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = (string)LstEstudiantes.SelectedRows[0].Cells[0].Value;
            txtName.Text = (string)LstEstudiantes.SelectedRows[0].Cells[1].Value;
            txtlstname1.Text = (string)LstEstudiantes.SelectedRows[0].Cells[2].Value;
            txtlstname2.Text = (string)LstEstudiantes.SelectedRows[0].Cells[3].Value;
            txtphoneN.Text = (string)LstEstudiantes.SelectedRows[0].Cells[4].Value;
            txtmail.Text = (string)LstEstudiantes.SelectedRows[0].Cells[5].Value;

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            txtID.Text = (string)LstEstudiantes.SelectedRows[0].Cells[0].Value;
            txtName.Text = (string)LstEstudiantes.SelectedRows[0].Cells[1].Value;
            txtlstname1.Text = (string)LstEstudiantes.SelectedRows[0].Cells[2].Value;
            txtlstname2.Text = (string)LstEstudiantes.SelectedRows[0].Cells[3].Value;
            txtphoneN.Text = (string)LstEstudiantes.SelectedRows[0].Cells[4].Value;
            txtmail.Text = (string)LstEstudiantes.SelectedRows[0].Cells[5].Value;
        }

        private void LstEstudiantes_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = (string)LstEstudiantes.SelectedRows[0].Cells[0].Value;
            txtName.Text = (string)LstEstudiantes.SelectedRows[0].Cells[1].Value;
            txtlstname1.Text = (string)LstEstudiantes.SelectedRows[0].Cells[2].Value;
            txtlstname2.Text = (string)LstEstudiantes.SelectedRows[0].Cells[3].Value;
            txtphoneN.Text = (string)LstEstudiantes.SelectedRows[0].Cells[4].Value;
            txtmail.Text = (string)LstEstudiantes.SelectedRows[0].Cells[5].Value;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EntidadEstudiantes estudiante = new EntidadEstudiantes();
            estudiante=GeneraraEntidadEstudiante();
            int resultado;
            BLestudiante logica = new BLestudiante(Configuracion.getConnetionString);

            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    resultado = logica.ActualizarConSP(estudiante);
                    MessageBox.Show(logica.Mensaje, "aviso", MessageBoxButtons.OK);
                    CargarListaDataSet();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un estudiante antes de actualizarlo", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtphoneN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 44)
            {

                e.Handled = false;

            }
            else
            {
                e.Handled = true;//cancela el evento /presionar la tecla
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

  
}
