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


namespace Capa1Presentacion
{
    public partial class FrmMatricula : Form
    {
        public FrmMatricula()
        {  
            InitializeComponent();
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLmatricula Logica = new BLmatricula(Configuracion.getConnetionString);
            DataSet DScliente;

            try
            {
                DScliente = Logica.ListarMatricula(condicion, orden);
                lstMatriculas.DataSource = DScliente;
                lstMatriculas.DataMember = DScliente.Tables["MATRICULAS"].TableName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public EntidadMatricula GeneraraEntidadMatricula()
        {
            EntidadMatricula matricula = new EntidadMatricula();
            matricula.Id_estudiante =txtidEstudiante.Text;
            matricula.Encargado = txtEncargado.Text;
            matricula.Fecha = DateTime.Now;

            return matricula;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntidadMatricula matricula = new EntidadMatricula();
            matricula.Id_matricula=int.Parse(txtID.Text);
            int resultado;
           BLmatricula logica = new BLmatricula(Configuracion.getConnetionString);

            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    resultado = logica.ElminarConSP(matricula);
                    MessageBox.Show(logica.Mensaje, "aviso", MessageBoxButtons.OK);
                    CargarListaDataSet();


                }
                else
                {
                    MessageBox.Show("Debe ingresar un codigo de matricula", "Aviso", MessageBoxButtons.OK);
                }
                CargarListaDataSet();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            EntidadMatricula matricula = new EntidadMatricula();
            BLmatricula logica = new BLmatricula(Configuracion.getConnetionString);

            int resultado;

            try
            {
                if (string.IsNullOrEmpty(txtEncargado.Text) ||
                    string.IsNullOrEmpty(txtidEstudiante.Text) ||
                    string.IsNullOrEmpty(txtEncargado.Text))
                {
                    MessageBox.Show("Datos Incompletos. Favor Completar todos los datos", "Aviso", MessageBoxButtons.OK);
                   
                }
                else
                {
                    matricula = GeneraraEntidadMatricula();
                    resultado = logica.CorroborarEstadoConSP(matricula);
                    if (resultado==0)
                    {
                        MessageBox.Show("El estudiante esta moroso", "LISTO", MessageBoxButtons.OK);
                    }
                    else
                    {
                        resultado = logica.Insertar(matricula);
                        MessageBox.Show("Operacion Realizada con Exito", "LISTO", MessageBoxButtons.OK);
                        CargarListaDataSet();
                    }
                   

                }
                CargarListaDataSet();
            }

            catch (Exception EX)
            {

                MessageBox.Show(EX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

    

        private void FrmMatricula_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstMatriculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string condicion = "";
            try
            {
                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {
                    condicion = string.Format("ID_MATRICULA like '%{0}%'", txtBuscar.Text.Trim());
                }
               
                CargarListaDataSet(condicion);


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lstMatriculas_DoubleClick(object sender, EventArgs e)
        {
            string id = lstMatriculas.SelectedRows[0].Cells[0].Value.ToString();
            string id_Est = (string)lstMatriculas.SelectedRows[0].Cells[1].Value;
            string Encargado = (string)lstMatriculas.SelectedRows[0].Cells[3].Value;

            txtID.Text = id;
            txtidEstudiante.Text = id_Est;
            txtEncargado.Text = Encargado;

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            EntidadMatricula matricula = new EntidadMatricula();
            matricula = GeneraraEntidadMatricula();
            matricula.Id_matricula =int.Parse(txtID.Text);
            int resultado;
            BLmatricula logica = new BLmatricula(Configuracion.getConnetionString);

            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    resultado = logica.ActualizarConSP(matricula);
                    MessageBox.Show(logica.Mensaje, "aviso", MessageBoxButtons.OK);
                    CargarListaDataSet();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una matricula antes de actualizarla", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
