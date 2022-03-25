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
    public partial class FrmProgramarClase : Form
    {
        public FrmProgramarClase()
        {
            InitializeComponent();
        }





        EntidadProgramarClase cargarEntidad()
        {
            EntidadProgramarClase programarClase = new EntidadProgramarClase();
            programarClase.Id_estudiante = txtIDEstudiante.Text;
            programarClase.Cod_materia_a = txtCodMateriaAbierta.Text;
            programarClase.Dia = Convert.ToDateTime(DPfecha.Text);
            programarClase.Hora = Convert.ToDateTime(txtHoraSalida.Text);
            return programarClase;
        }






        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLprogramarClase Logica = new BLprogramarClase(Configuracion.getConnetionString);
            DataSet DS;

            try
            {
                DS = Logica.ListarClases(condicion, orden);
                LSTclases.DataSource = DS;
                LSTclases.DataMember = DS.Tables["CLASES"].TableName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void button1_Click(object sender, EventArgs e)
        {
            EntidadProgramarClase programarClase = new EntidadProgramarClase();
            BLprogramarClase logica = new BLprogramarClase(Configuracion.getConnetionString);

            int resultado;
            
            try
            {
                if (string.IsNullOrEmpty(txtIDEstudiante.Text) ||
                    string.IsNullOrEmpty(txtHoraSalida.Text) ||
                    string.IsNullOrEmpty(txtCodMateriaAbierta.Text) ||
                    string.IsNullOrEmpty(DPfecha.Text) 
                    )
                {
                    MessageBox.Show("Datos Incompletos. Favor Completar todos los datos", "Aviso", MessageBoxButtons.OK);
                }
                
                else
                {
                    programarClase = cargarEntidad();
                    resultado = logica.REVISAR_DISPONIBILIDAD(programarClase);
                    if (programarClase.Dia.ToString("dddd")=="domingo"|| programarClase.Dia.ToString("dddd") == "sábado")//verificamos que no ingresen una fecha invalida
                    {
                        MessageBox.Show("No se trabaja los fines de semana", "Aviso", MessageBoxButtons.OK);
                    }
                    else if (resultado==1)
                    {
                        MessageBox.Show(logica.Mensaje, "Aviso", MessageBoxButtons.OK) ;
                    }
                    else
                    {
                        resultado = logica.Insertar(programarClase);
                        MessageBox.Show("Operacion Realizada con Exito", "LISTO", MessageBoxButtons.OK);

                    }
                    CargarListaDataSet();
                }
            }

            catch (Exception EX)
            {

                MessageBox.Show(EX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }





        private void FrmProgramarClase_Load(object sender, EventArgs e)
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





        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }





        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            string condicion = "";
            try
            {
                if (!string.IsNullOrEmpty(txtBuscar.Text))//Filtramos informacion mediante el codigo de materia abierta
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




    }
}
