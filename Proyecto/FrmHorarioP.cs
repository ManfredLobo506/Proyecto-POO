using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Capa4Entidades;
using Capa3AccesoDatos;
using Capa2Logica;
using System.Data.SqlClient;




namespace Capa1Presentacion
{
    public partial class FrmHorarioP : Form
    {
        public FrmHorarioP()
        {
            InitializeComponent();
        }
        public EntidadHorarioP GeneraraEntidadHorarioP()
        {
            DateTime hora_entrada = Convert.ToDateTime(txtHoraEntrada.Text);
          

            EntidadHorarioP horarioP = new EntidadHorarioP();
            horarioP.Id_profesor = TxtIdentificacion.Text;
            horarioP.Dia = txtDia.Text;
            horarioP.HoraEntrada = Convert.ToDateTime(txtHoraEntrada.Text);
            horarioP.Horasalida = Convert.ToDateTime(txtHoraSalida.Text);

            return horarioP;
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLhorarioP Logica = new BLhorarioP(Configuracion.getConnetionString);
            DataSet DS;

            try
            {
                DS= Logica.ListarHorario(condicion, orden);
                LstHorarios.DataSource = DS;
                LstHorarios.DataMember = DS.Tables["HORARIO_P"].TableName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EntidadHorarioP horarioP = new EntidadHorarioP();
            BLhorarioP logica = new BLhorarioP(Configuracion.getConnetionString);

            int resultado;

            try
            {
                if (string.IsNullOrEmpty(txtDia.Text) ||
                    string.IsNullOrEmpty(txtHoraEntrada.Text) ||
                    string.IsNullOrEmpty(txtHoraSalida.Text))
                {
                    MessageBox.Show("Datos Incompletos. Favor Completar todos los datos", "Aviso", MessageBoxButtons.OK);

                }
                else
                {
                    horarioP = GeneraraEntidadHorarioP();
                    resultado = logica.ComprobarConSP(horarioP);

                    if (horarioP.Horasalida<horarioP.HoraEntrada)
                    {
                        MessageBox.Show("La hora de salida no puede ser mayor", "aviso", MessageBoxButtons.OK);
                    }
                  else if (resultado==1)
                    {
                        MessageBox.Show(logica.Mensaje, "aviso", MessageBoxButtons.OK);
                    }
                
                    else {
                        resultado = logica.Insertar(horarioP);

                       
                        MessageBox.Show("Operacion Realizada con Exito", "LISTO", MessageBoxButtons.OK);
                    }
                    


                }
                CargarListaDataSet();
            }
            
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message, "Aviso", MessageBoxButtons.OK);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string condicion = "";
            try
            {
                if (!string.IsNullOrEmpty(TxtBuscar.Text))
                {
                    condicion = string.Format("IDENTIFICACION_P like '%{0}%'", TxtBuscar.Text.Trim());
                }

                CargarListaDataSet(condicion);


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LstHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = LstHorarios.SelectedRows[0].Cells[0].Value.ToString();
            string id_P = LstHorarios.SelectedRows[0].Cells[1].Value.ToString();
            string dia = LstHorarios.SelectedRows[0].Cells[2].Value.ToString();

            txtCod.Text = id;
            TxtIdentificacion.Text = id_P;
            txtDia.Text = dia;

        }

       

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                EntidadHorarioP horarioP = new EntidadHorarioP();
                horarioP.Id_horario = int.Parse(txtCod.Text);
                int resultado;
                BLhorarioP logica = new BLhorarioP(Configuracion.getConnetionString);

                try
                {
                    if (!string.IsNullOrEmpty(txtCod.Text))
                    {
                        resultado = logica.ElminarConSP(horarioP);
                        MessageBox.Show(logica.Mensaje, "aviso", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un codigo de horario", "Aviso", MessageBoxButtons.OK);
                    }
                    CargarListaDataSet();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Seleccione un horario", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            string id = LstHorarios.SelectedRows[0].Cells[0].Value.ToString();
            string id_P = LstHorarios.SelectedRows[0].Cells[1].Value.ToString();
            string dia = LstHorarios.SelectedRows[0].Cells[2].Value.ToString();

            txtCod.Text = id;
            TxtIdentificacion.Text = id_P;
            txtDia.Text = dia;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
