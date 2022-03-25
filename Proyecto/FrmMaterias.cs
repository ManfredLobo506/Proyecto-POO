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
    public partial class FrmMaterias : Form
    {
        public FrmMaterias()
        {
            InitializeComponent();
        }
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLmateriaAbierta Logica = new BLmateriaAbierta(Configuracion.getConnetionString);
            DataSet DS;

            try
            {
                DS = Logica.ListarMateriasAbiertasNombres(condicion, orden);
                LSTmaterias.DataSource = DS;
                LSTmaterias.DataMember = DS.Tables["MATERIAS"].TableName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Aviso",MessageBoxButtons.OK);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string condicion = "";
            try
            {
                if (!string.IsNullOrEmpty(txtNombreM.Text))
                {
                    condicion = string.Format("NOMBRE_MATERIA like '%{0}%'", txtNombreM.Text.Trim());
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
