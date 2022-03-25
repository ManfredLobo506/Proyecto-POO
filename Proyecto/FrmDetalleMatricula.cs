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
    public partial class FrmDetalleMatricula : Form
    {
        public FrmDetalleMatricula()
        {
            InitializeComponent();
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLdetalleMatricula Logica = new BLdetalleMatricula(Configuracion.getConnetionString);
            DataSet DS;

            try
            {
                DS = Logica.ListarDetalle(condicion, orden);
                LSTdetalle.DataSource = DS;
                LSTdetalle.DataMember = DS.Tables["DETALLE_MATRICULA"].TableName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public EntidadDetalleMatricula GeneraraEntidadDetalle()
        {
            EntidadDetalleMatricula detalle = new EntidadDetalleMatricula();

            detalle.Id_matricula = int.Parse(txtMatricula.Text);
            detalle.Cod_materiaA = txtCodMateriaA.Text;
            detalle.Cancelado = txtEstado.Text;
            detalle.Nota = int.Parse(txtNota.Text);


            return detalle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntidadDetalleMatricula Detalle = new EntidadDetalleMatricula();
            BLdetalleMatricula logica = new BLdetalleMatricula(Configuracion.getConnetionString);

            int resultado;

            try
            {
                if (string.IsNullOrEmpty(txtMatricula.Text) ||
                    string.IsNullOrEmpty(txtCodMateriaA.Text) ||
                    string.IsNullOrEmpty(txtNota.Text) ||
                    string.IsNullOrEmpty(txtEstado.Text)
                    )
                {
                    MessageBox.Show("Datos Incompletos. Favor Completar todos los datos", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    Detalle = GeneraraEntidadDetalle();
                    resultado = logica.CorroborarCupoConSP(Detalle);
                    if (resultado == 0)
                    {
                        MessageBox.Show("No hay cupos para la materia", "LISTO", MessageBoxButtons.OK);
                    }
                    else
                    {
                        resultado = logica.Insertar(Detalle);
                        MessageBox.Show("Operacion Realizada con Exito", "LISTO", MessageBoxButtons.OK);
                        CargarListaDataSet();
                    }
                }

            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EntidadDetalleMatricula detalleMatricula = new EntidadDetalleMatricula();
            detalleMatricula.Id_detalle_matricula=int.Parse(txtIDdetalle.Text);
            int resultado;
           BLdetalleMatricula logica = new BLdetalleMatricula(Configuracion.getConnetionString);

            try
            {
                if (!string.IsNullOrEmpty(txtIDdetalle.Text))
                {
                    resultado = logica.ElminarConSP(detalleMatricula);
                    MessageBox.Show(logica.Mensaje, "aviso", MessageBoxButtons.OK);
                    CargarListaDataSet();

                }
                else
                {
                    MessageBox.Show("Debe seleccionar un detalle matricula antes de eliminarlo", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDetalleMatricula_Load(object sender, EventArgs e)
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
                    condicion = string.Format("ID_DETALLEMATRICULA like '%{0}%'", txtBuscar.Text.Trim());
                }

                CargarListaDataSet(condicion);


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LSTdetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDdetalle.Text = LSTdetalle.SelectedRows[0].Cells[0].Value.ToString();
            txtMatricula.Text = LSTdetalle.SelectedRows[0].Cells[1].Value.ToString();
            txtCodMateriaA.Text = LSTdetalle.SelectedRows[0].Cells[2].Value.ToString();
            txtNota.Text = LSTdetalle.SelectedRows[0].Cells[3].Value.ToString();
            txtEstado.Text = LSTdetalle.SelectedRows[0].Cells[4].Value.ToString();


            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtIDdetalle.Text = LSTdetalle.SelectedRows[0].Cells[0].Value.ToString();
            txtMatricula.Text = LSTdetalle.SelectedRows[0].Cells[1].Value.ToString();
            txtCodMateriaA.Text = LSTdetalle.SelectedRows[0].Cells[2].Value.ToString();
            txtNota.Text = LSTdetalle.SelectedRows[0].Cells[3].Value.ToString();
            txtEstado.Text = LSTdetalle.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EntidadDetalleMatricula detalleMatricula = new EntidadDetalleMatricula();
            detalleMatricula = GeneraraEntidadDetalle();
            
            int resultado;
            BLdetalleMatricula logica = new BLdetalleMatricula(Configuracion.getConnetionString);

            try
            {
                if (!string.IsNullOrEmpty(txtIDdetalle.Text))
                {
                    detalleMatricula.Id_detalle_matricula = int.Parse(txtIDdetalle.Text);
                    resultado = logica.ActualizarConSP(detalleMatricula);
                    MessageBox.Show(logica.Mensaje, "aviso", MessageBoxButtons.OK);
                    CargarListaDataSet();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un detalle matricula antes de actualizarlo", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
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
