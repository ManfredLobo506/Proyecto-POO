using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Capa4Entidades;
using Capa2Logica;
using Capa1Presentacion;

namespace Proyecto
{
    public partial class FrmProfesor : Form
    {
        public FrmProfesor()
        {
            InitializeComponent();
        }

        public EntidadesProfesor GeneraraEntidadProfesor()
        {
            EntidadesProfesor profesor = new EntidadesProfesor();

            profesor.Nombre=(txtName.Text);
            profesor.Apellido1=(txtAp1.Text);
            profesor.Apellido2=(txtAp2.Text);
            profesor.Identificacion=(txtID.Text);
            profesor.NumeroTelefonico=(txtTel1.Text);
            profesor.CorreoElectronico=(txtEmail.Text);


            return profesor;
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLprofesor Logica = new BLprofesor(Configuracion.getConnetionString);
            DataSet DS;

            try
            {
                DS = Logica.ListarProfesores(condicion, orden);
               LstProfesores.DataSource = DS;
                LstProfesores.DataMember = DS.Tables["PROFESORES"].TableName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntidadesProfesor profesor = new EntidadesProfesor();
            BLprofesor logica = new BLprofesor(Configuracion.getConnetionString);

            string resultado;

            try
            {
                if (string.IsNullOrEmpty(txtName.Text) ||
                    string.IsNullOrEmpty(txtAp1.Text) ||
                    string.IsNullOrEmpty(txtAp2.Text) ||
                    string.IsNullOrEmpty(txtID.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtTel1.Text))
                {
                    MessageBox.Show("Datos Incompletos. Favor Completar todos los datos", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    profesor = GeneraraEntidadProfesor();
                    resultado = logica.Insertar(profesor);
                    MessageBox.Show("Operacion Realizada con Exito", "LISTO", MessageBoxButtons.OK);
                    CargarListaDataSet();

                }
            }

            catch (Exception EX)
            {

                MessageBox.Show(EX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void btnEliminarProfesor_Click(object sender, EventArgs e)
        {
            EntidadesProfesor profesor = new EntidadesProfesor();
            profesor.Identificacion=(txtID.Text);
            int resultado;
            BLprofesor logica = new BLprofesor(Configuracion.getConnetionString);

            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))//Verificamos que no este NULL
                {
                    resultado = logica.ElminarConSP(profesor);
                    MessageBox.Show(logica.Mensaje, "aviso", MessageBoxButtons.OK);
                    CargarListaDataSet();

                }
                else
                {
                    MessageBox.Show("Debe seleccionar un profesor antes de eliminarlo", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            try
            {
                //Cargamos la lista
                CargarListaDataSet();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string condicion = "";
            try
            {
                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {
                    //La informacion se filtrara mediante la id del profesor
                    condicion = string.Format("IDENTIFICACION_P like '%{0}%'", txtBuscar.Text.Trim());
                }

                CargarListaDataSet(condicion);


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //Tomamos los elementos de la lstProfesores y los asignamos a los text box
            txtID.Text = (string)LstProfesores.SelectedRows[0].Cells[0].Value;
            txtName.Text = (string)LstProfesores.SelectedRows[0].Cells[1].Value;
            txtAp1.Text = (string)LstProfesores.SelectedRows[0].Cells[2].Value;
            txtAp2.Text = (string)LstProfesores.SelectedRows[0].Cells[3].Value;
            txtTel1.Text = (string)LstProfesores.SelectedRows[0].Cells[4].Value;
            txtEmail.Text = (string)LstProfesores.SelectedRows[0].Cells[5].Value;
        }

        private void LstProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Tomamos los elementos de la lstProfesores y los asignamos a los text box
            txtID.Text = (string)LstProfesores.SelectedRows[0].Cells[0].Value;
            txtName.Text = (string)LstProfesores.SelectedRows[0].Cells[1].Value;
            txtAp1.Text = (string)LstProfesores.SelectedRows[0].Cells[2].Value;
            txtAp2.Text = (string)LstProfesores.SelectedRows[0].Cells[3].Value;
            txtTel1.Text = (string)LstProfesores.SelectedRows[0].Cells[4].Value;
            txtEmail.Text = (string)LstProfesores.SelectedRows[0].Cells[5].Value;
        }

        private void LstProfesores_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = (string)LstProfesores.SelectedRows[0].Cells[0].Value;
            txtName.Text = (string)LstProfesores.SelectedRows[0].Cells[1].Value;
            txtAp1.Text = (string)LstProfesores.SelectedRows[0].Cells[2].Value;
            txtAp2.Text = (string)LstProfesores.SelectedRows[0].Cells[3].Value;
            txtTel1.Text = (string)LstProfesores.SelectedRows[0].Cells[4].Value;
            txtEmail.Text = (string)LstProfesores.SelectedRows[0].Cells[5].Value;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EntidadesProfesor profesor = new EntidadesProfesor();
            profesor = GeneraraEntidadProfesor();
            int resultado;
            BLprofesor logica = new BLprofesor(Configuracion.getConnetionString);

            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    resultado = logica.ActualizarConSP(profesor);
                    MessageBox.Show(logica.Mensaje, "aviso", MessageBoxButtons.OK);
                    CargarListaDataSet();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un profesor antes de actualizarlo", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTel1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
