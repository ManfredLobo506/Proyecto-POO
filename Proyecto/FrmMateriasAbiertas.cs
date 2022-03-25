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
    public partial class FrmMateriasAbiertas : Form
    {
        public FrmMateriasAbiertas()
        {
            InitializeComponent();
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLmateriaAbierta Logica = new BLmateriaAbierta(Configuracion.getConnetionString);
            DataSet DS;

            try
            {
                DS = Logica.ListarMateriasAbiertas(condicion, orden);
                lstMateriasAbiertas.DataSource = DS;
                lstMateriasAbiertas.DataMember = DS.Tables["MATERIAS_ABIERTAS"].TableName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public EntidadMateriaAbierta GeneraraEntidadMateriaA()
        {
            EntidadMateriaAbierta detalle = new EntidadMateriaAbierta();

            detalle.Cod_materia = TxtCodMateria.Text;
            detalle.Cod_MateriaA = txtCodMateriaA.Text;
            detalle.IdentificacionP = txtIDp.Text;
            detalle.Costo=int.Parse(txtCosto.Text);
            detalle.Cupo = int.Parse(txtCupo.Text);


            return detalle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntidadMateriaAbierta materiaA = new EntidadMateriaAbierta();
            BLmateriaAbierta logica = new BLmateriaAbierta(Configuracion.getConnetionString);

            string resultado;

            try
            {
                if (string.IsNullOrEmpty(txtCodMateriaA.Text) ||
                    string.IsNullOrEmpty(TxtCodMateria.Text) ||
                    string.IsNullOrEmpty(txtIDp.Text) ||
                    string.IsNullOrEmpty(txtCupo.Text) ||
                    string.IsNullOrEmpty(txtCosto.Text) )
                {
                    MessageBox.Show("Datos Incompletos. Favor Completar todos los datos", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    materiaA = GeneraraEntidadMateriaA();
                    resultado = logica.Insertar(materiaA);
                    MessageBox.Show("Operacion Realizada con Exito", "LISTO", MessageBoxButtons.OK);
                    CargarListaDataSet();

                }
            }

            catch (Exception EX)
            {

                MessageBox.Show(EX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void FrmMateriasAbiertas_Load(object sender, EventArgs e)
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

        private void lstMateriasAbiertas_DoubleClick(object sender, EventArgs e)
        {
            txtCodMateriaA.Text=(string)lstMateriasAbiertas.SelectedRows[0].Cells[0].Value;
            TxtCodMateria.Text =(string)lstMateriasAbiertas.SelectedRows[0].Cells[1].Value;
            txtCosto.Text = lstMateriasAbiertas.SelectedRows[0].Cells[2].Value.ToString();
            txtCupo.Text = lstMateriasAbiertas.SelectedRows[0].Cells[3].Value.ToString();
            txtIDp.Text = (string)lstMateriasAbiertas.SelectedRows[0].Cells[4].Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCodMateriaA.Text = (string)lstMateriasAbiertas.SelectedRows[0].Cells[0].Value;
            TxtCodMateria.Text = (string)lstMateriasAbiertas.SelectedRows[0].Cells[1].Value;
            txtCosto.Text = lstMateriasAbiertas.SelectedRows[0].Cells[2].Value.ToString();
            txtCupo.Text = lstMateriasAbiertas.SelectedRows[0].Cells[3].Value.ToString();
            txtIDp.Text = (string)lstMateriasAbiertas.SelectedRows[0].Cells[4].Value;
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string condicion = "";
            try
            {
                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {
                    condicion = string.Format("COD_MATERIA_ABIERTA like '%{0}%'", txtBuscar.Text.Trim());
                }

                CargarListaDataSet(condicion);


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EntidadMateriaAbierta materiaAbierta = new EntidadMateriaAbierta();
            materiaAbierta =GeneraraEntidadMateriaA();
            int resultado;
            BLmateriaAbierta logica = new BLmateriaAbierta(Configuracion.getConnetionString);

            try
            {
                if (!string.IsNullOrEmpty(txtCodMateriaA.Text))
                {
                    resultado = logica.ActualizarConSP(materiaAbierta);
                    MessageBox.Show(logica.Mensaje, "aviso", MessageBoxButtons.OK);
                    CargarListaDataSet();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una materia abierta antes de actualizarla", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EntidadMateriaAbierta materiaAbierta = new EntidadMateriaAbierta();
            materiaAbierta.Cod_MateriaA = txtCodMateriaA.Text;
            int resultado;
            BLmateriaAbierta logica = new BLmateriaAbierta(Configuracion.getConnetionString);

            try
            {
                if (!string.IsNullOrEmpty(txtCodMateriaA.Text))
                {
                    resultado = logica.ElminarConSP(materiaAbierta);
                    MessageBox.Show(logica.Mensaje, "aviso", MessageBoxButtons.OK);
                    CargarListaDataSet();

                }
                else
                {
                    MessageBox.Show("Debe seleccionar una materia abierta antes de eliminarla", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtCupo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
