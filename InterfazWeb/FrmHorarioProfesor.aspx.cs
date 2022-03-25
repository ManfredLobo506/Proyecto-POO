using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa4Entidades;
using Capa2Logica;
using System.Data;

namespace InterfazWeb
{
    public partial class FrmHorarioProfesor : System.Web.UI.Page
    {
        string mensajeScript = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarListaDataSet();
        }

        

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            //carga el datagridview con el dataset
            BLhorarioP logica = new BLhorarioP(clsConfiguracion.getConnectionString);
            DataSet DSHorario;
            try
            {
                DSHorario = logica.ListarHorario(condicion, orden);
                GrdHorarios.DataSource = DSHorario;
                GrdHorarios.DataMember = DSHorario.Tables[0].TableName;
                GrdHorarios.DataBind();
                //en la tabla con nombre Clientes del dataset
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void LnkModificar_Command(object sender, CommandEventArgs e)
        {

            string id = e.CommandArgument.ToString();//Realizamos una actulizacion mediante linq
            Bd_POODataContext dataContext = new Bd_POODataContext();


            var consulta = from horario in dataContext.HORARIO_P
                           where horario.ID_HORARIO == int.Parse(id)
                           select new { id = horario.ID_HORARIO, id_P = horario.IDENTIFICACION_P, dia = horario.DIA, salida = horario.HORA_SALIDA, entrada = horario.HORA_ENTRADA };

            foreach (var item in consulta)
            {
                TxtId.Text = item.id_P.ToString();
                TxtIdHorario.Text = item.id.ToString();
                LstDia.Text = item.dia;
                LstEntrada.Text = item.entrada.ToString();
                LstSalida.Text = item.salida.ToString();
            }

        }

        public EntidadHorarioP GeneraraEntidadHorarioP()//Generamos la entidad  del horario
        {
           


            EntidadHorarioP horarioP = new EntidadHorarioP();
            horarioP.Id_profesor = TxtId.Text;
            horarioP.Dia = LstDia.Text;
            horarioP.HoraEntrada = Convert.ToDateTime(LstEntrada.Text);
            horarioP.Horasalida = Convert.ToDateTime(LstSalida.Text);

            return horarioP;
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            EntidadHorarioP horarioP = new EntidadHorarioP();
            BLhorarioP logica = new BLhorarioP(clsConfiguracion.getConnectionString);

            int resultado;

            Bd_POODataContext dataContext = new Bd_POODataContext();
            int id; 
            if (TxtIdHorario.Text=="")
            {
                id = -1;//Para no tener conflictos mas adelante
            }
            else
            {
               id= int.Parse(TxtIdHorario.Text);
            }

            try
            {
               
                    horarioP = GeneraraEntidadHorarioP();
                    resultado = logica.ComprobarConSP(horarioP);

                    if (horarioP.Horasalida < horarioP.HoraEntrada)//Realizamos la verificacion de las horas
                    {
                        mensajeScript = string.Format("javascript:mostrarMensaje('La hora de salida no puede ser menor a la de entrada')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                     }
                    else if ((from hor in dataContext.HORARIO_P//Revisamos si ya existe un horario y si existe realizamos un actualizacion mediante linq
                                where hor.ID_HORARIO == id
                                select hor).Count()>=1)
                    {
                        var update = from hor in dataContext.HORARIO_P
                                     where hor.ID_HORARIO == Convert.ToInt32(TxtIdHorario.Text)
                                     select hor;
                        foreach (var item in update)
                        {
                            item.DIA = LstDia.Text;
                            item.HORA_ENTRADA = TimeSpan.Parse(LstEntrada.Text);
                            item.HORA_SALIDA = TimeSpan.Parse(LstSalida.Text);
                        }
                        dataContext.SubmitChanges();
                        mensajeScript = string.Format("javascript:mostrarMensaje('Modificacion realizada con exito')");//Enviamos un mensaje de que la operacion se completo correctamente
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                        CargarListaDataSet();
                    }
                    else if (resultado == 1)
                        {
                        mensajeScript = string.Format("javascript:mostrarMensaje('{0}')",logica.Mensaje);//Mostramos el mensaje enviado
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                        }
               
                    else
                    {
                            resultado = logica.Insertar(horarioP);//Realizamos un insert


                        mensajeScript = string.Format("javascript:mostrarMensaje('Operacion realizada con exito')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                        CargarListaDataSet();
                    }



            }

            catch (Exception )
            {

                mensajeScript = string.Format("javascript:mostrarMensaje('No se pudo completar la operacion')");
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }

        protected void LnkEliminar_Command(object sender, CommandEventArgs e)
        {
            string id = e.CommandArgument.ToString();//Tomamos el dato del commandArgument
            Bd_POODataContext dataContext = new Bd_POODataContext();


            var delete = (from x in dataContext.HORARIO_P
                          where x.ID_HORARIO == Convert.ToInt32(id)
                          select x).ToList();//Realizamos una consulta y la guardamos como list
            foreach (var item in delete)
            {
                dataContext.HORARIO_P.DeleteOnSubmit(item);//Eliminamos el item
            }
            try
            {
                dataContext.SubmitChanges();//Completamos los campos
            }
            catch (Exception)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('No se pudo completar la operacion')"); //En caso de que no se pueda completar la accion enviamos un mensaje
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);


            }
            mensajeScript = string.Format("javascript:mostrarMensaje('Accion completada con exito')");//En caso de que todo fluyera bien mostramos esto
            ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);



            CargarListaDataSet();
        }
    }
}