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
    public partial class FrmDiasNoLectivos : Form
    {
        public FrmDiasNoLectivos()
        {
            InitializeComponent();
        }
        public EntidadDiasNoLectivos GeneraraEntidadDiasNoLectivos()
        {
            EntidadDiasNoLectivos diasNoLectivos = new EntidadDiasNoLectivos();

            diasNoLectivos.Id_profesor = txtIdentificacionP.Text;
            diasNoLectivos.Motivo = txtMotivo.Text;
            diasNoLectivos.Fecha = timePickerFecha.Value;


            return diasNoLectivos;
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLdiasNoLectivos Logica = new BLdiasNoLectivos(Configuracion.getConnetionString);
            DataSet DS;

            try
            {
                DS = Logica.Listardias(condicion, orden);
                lstNolectivos.DataSource = DS;
                lstNolectivos.DataMember = DS.Tables["DIAS_NO_LECTIVOS"].TableName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            EntidadDiasNoLectivos diasNoLectivos = new EntidadDiasNoLectivos();
            BLdiasNoLectivos logica = new BLdiasNoLectivos(Configuracion.getConnetionString);

            int resultado;

            try
            {
                if (string.IsNullOrEmpty(txtIdentificacionP.Text) ||
                    string.IsNullOrEmpty(txtMotivo.Text) 
                    )
                {
                    MessageBox.Show("Datos Incompletos. Favor Completar todos los datos", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    diasNoLectivos = GeneraraEntidadDiasNoLectivos();
                    resultado = logica.Insertar(diasNoLectivos);
                    MessageBox.Show("Operacion Realizada con Exito", "LISTO", MessageBoxButtons.OK);
                    CargarListaDataSet();


                }
            }

            catch (Exception EX)
            {

                MessageBox.Show(EX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntidadDiasNoLectivos diasNoLectivos = new EntidadDiasNoLectivos();
            diasNoLectivos.Cod = int.Parse(txtCOD.Text);
            int resultado;
            BLdiasNoLectivos logica = new BLdiasNoLectivos(Configuracion.getConnetionString);

            try
            {
                if (!string.IsNullOrEmpty(txtCOD.Text))
                {
                    resultado = logica.ElminarConSP(diasNoLectivos);
                    MessageBox.Show(logica.Mensaje, "aviso", MessageBoxButtons.OK);
                    CargarListaDataSet();

                }
                else
                {
                    MessageBox.Show("Debe seleccionar un dia no lectivo antes de eliminarlo", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDiasNoLectivos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
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

        private void lstNolectivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int COD = (int)lstNolectivos.SelectedRows[0].Cells[0].Value;
                string id_pro = (string)lstNolectivos.SelectedRows[0].Cells[1].Value;
                string motivo = (string)lstNolectivos.SelectedRows[0].Cells[2].Value;

                txtCOD.Text = COD.ToString();
                txtIdentificacionP.Text = id_pro;
                txtMotivo.Text = motivo;




            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int COD = (int)lstNolectivos.SelectedRows[0].Cells[0].Value;
                string id_pro = (string)lstNolectivos.SelectedRows[0].Cells[1].Value;
                string motivo = (string)lstNolectivos.SelectedRows[0].Cells[2].Value;

                txtCOD.Text = COD.ToString();
                txtIdentificacionP.Text = id_pro;
                txtMotivo.Text = motivo;




            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
