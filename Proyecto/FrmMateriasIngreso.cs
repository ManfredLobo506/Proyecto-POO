using Capa1Presentacion;
using Capa2Logica;
using Capa4Entidades;
using System;
using System.Windows.Forms;
using System.Data;
namespace Proyecto
{
    public partial class FrmMateriasIngreso : Form
    {
        public FrmMateriasIngreso()
        {
            InitializeComponent();
        }
        public EntidadMateria GeneraraEntidadMateria()
        {
            EntidadMateria materia = new EntidadMateria();


           materia.Cod_materia = txtCOD.Text;
            materia.Nombre_materia = txtNombre.Text;
            materia.Total_horas = txtTotalHoras.Text;


            return materia;
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLmateria Logica = new BLmateria(Configuracion.getConnetionString);
            DataSet DS;

            try
            {
                DS = Logica.ListarMaterias(condicion, orden);
                lstMaterias.DataSource = DS;
                lstMaterias.DataMember = DS.Tables["MATERIAS"].TableName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntidadMateria materia = new EntidadMateria();
           BLmateria logica = new BLmateria(Configuracion.getConnetionString);

            string resultado;

            try
            {
                if (string.IsNullOrEmpty(txtCOD.Text) ||
                    string.IsNullOrEmpty(txtTotalHoras.Text) ||
                    string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Datos Incompletos. Favor Completar todos los datos", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    materia = GeneraraEntidadMateria();
                    resultado = logica.Insertar(materia);
                    MessageBox.Show("Operacion Realizada con Exito", "LISTO", MessageBoxButtons.OK);
                    CargarListaDataSet();


                }
            }

            catch (Exception EX)
            {

                MessageBox.Show(EX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EntidadMateria materia = new EntidadMateria();
            materia.Cod_materia=txtCOD.Text;
            int resultado;
            BLmateria logica = new BLmateria(Configuracion.getConnetionString);

            try
            {
                if (!string.IsNullOrEmpty(txtCOD.Text))
                {
                    resultado = logica.ElminarConSP(materia);
                    MessageBox.Show(logica.Mensaje, "aviso", MessageBoxButtons.OK);
                    CargarListaDataSet();

                }
                else
                {
                    MessageBox.Show("Debe ingresar un codigo de materia", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMateriasIngreso_Load(object sender, EventArgs e)
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

        private void lstMaterias_DoubleClick(object sender, EventArgs e)
        {
            txtCOD.Text= (string)lstMaterias.SelectedRows[0].Cells[0].Value;
            txtNombre.Text=(string)lstMaterias.SelectedRows[0].Cells[1].Value;
            txtTotalHoras.Text=lstMaterias.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            txtCOD.Text = (string)lstMaterias.SelectedRows[0].Cells[0].Value;
            txtNombre.Text = (string)lstMaterias.SelectedRows[0].Cells[1].Value;
            txtTotalHoras.Text = lstMaterias.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string condicion = "";
            try
            {
                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {
                    condicion = string.Format("NOMBRE_MATERIA like '%{0}%'", txtBuscar.Text.Trim());
                }

                CargarListaDataSet(condicion);


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnActualzar_Click(object sender, EventArgs e)
        {
            EntidadMateria materia = new EntidadMateria();
            materia = GeneraraEntidadMateria();

            int resultado;
            BLdetalleMatricula logica = new BLdetalleMatricula(Configuracion.getConnetionString);

            try
            {
                if (!string.IsNullOrEmpty(txtCOD.Text))
                {
                    materia.Cod_materia = (string)txtCOD.Text;
                    resultado = logica.ActualizarConSP(materia);
                    MessageBox.Show(logica.Mensaje, "aviso", MessageBoxButtons.OK);
                    CargarListaDataSet();
                }
                else
                {
                    MessageBox.Show("Debe seleccione una materia antes de actualizarla", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTotalHoras_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
