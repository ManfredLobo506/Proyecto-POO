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
    public partial class FrmCertificado : Form
    {
        public FrmCertificado()
        {
            InitializeComponent();
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLcertificadosP Logica = new BLcertificadosP(Configuracion.getConnetionString);
            DataSet DS;

            try
            {
                DS = Logica.ListarCertificados(condicion, orden);
                lstCertificado.DataSource = DS;
                lstCertificado.DataMember = DS.Tables["CERTIFICADOS_PROFESORES"].TableName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public EntidadCertificadosP GeneraraEntidadCertificado()
        {
            EntidadCertificadosP certificadosP = new EntidadCertificadosP();

            certificadosP.Cod_certificado = txtIDcertfificado.Text.ToString();
            certificadosP.Nombre_certificado = txtNombre.Text.ToString();
            certificadosP.Id_profesor = txtIDp.Text.ToString();


            return certificadosP;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntidadCertificadosP certificadosP = new EntidadCertificadosP();
            BLcertificadosP logica = new BLcertificadosP(Configuracion.getConnetionString);

            string resultado;

            try
            {
                if (string.IsNullOrEmpty(txtIDcertfificado.Text) ||
                    string.IsNullOrEmpty(txtIDp.Text) ||
                    string.IsNullOrEmpty(txtNombre.Text) 
                    )
                {
                    MessageBox.Show("Datos Incompletos. Favor Completar todos los datos", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    certificadosP= GeneraraEntidadCertificado();
                    resultado = logica.Insertar(certificadosP);
                    MessageBox.Show("Operacion Realizada con Exito", "LISTO", MessageBoxButtons.OK);
                    CargarListaDataSet();

                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadCertificadosP certificadosP = new EntidadCertificadosP();
            certificadosP.Cod_certificado = txtIDcertfificado.Text;
            int resultado;
            BLcertificadosP logica = new BLcertificadosP(Configuracion.getConnetionString);

            try
            {
                if (!string.IsNullOrEmpty(txtIDcertfificado.Text))
                {
                    resultado = logica.ElminarConSP(certificadosP);
                    MessageBox.Show(logica.Mensaje, "aviso", MessageBoxButtons.OK);
                    CargarListaDataSet();

                }
                else
                {
                    MessageBox.Show("Debe seleccionar un certificado antes de eliminarlo", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCertificado_Load(object sender, EventArgs e)
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

        private void lstCertificado_DoubleClick(object sender, EventArgs e)
        {
            txtIDcertfificado.Text=(string)lstCertificado.SelectedRows[0].Cells[0].Value;
            txtNombre.Text=(string)lstCertificado.SelectedRows[0].Cells[1].Value;
            txtIDp.Text=(string)lstCertificado.SelectedRows[0].Cells[2].Value;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            txtIDcertfificado.Text = (string)lstCertificado.SelectedRows[0].Cells[0].Value;
            txtNombre.Text = (string)lstCertificado.SelectedRows[0].Cells[1].Value;
            txtIDp.Text = (string)lstCertificado.SelectedRows[0].Cells[2].Value;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string condicion = "";
            try
            {
                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {
                    condicion = string.Format("IDENTIFICACION_P like '%{0}%'", txtBuscar.Text.Trim());
                }

                CargarListaDataSet(condicion);


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
