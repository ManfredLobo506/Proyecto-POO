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
    public partial class Frmmnotas : Form
    {
        public Frmmnotas()
        {
            InitializeComponent();
        }
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLdetalleMatricula Logica = new BLdetalleMatricula(Configuracion.getConnetionString);
            DataSet DS;

            try
            {
                DS = Logica.ListarNotas(condicion, orden);
                lstNotas.DataSource = DS;
                lstNotas.DataMember = DS.Tables["NOTAS"].TableName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            CargarListaDataSet();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string condicion = "";
            try
            {
                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {
                    condicion = string.Format("ESTUDIANTES.IDENTIFICACION_E like '%{0}%'", txtBuscar.Text.Trim());
                }

                CargarListaDataSet(condicion);


            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
