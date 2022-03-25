using System;
using System.Collections.Generic;
using System.Text;

namespace Capa4Entidades
{
    public class EntidadHorarioP
    {
        //atributos
        int id_horario;
        string id_profesor;
        string dia;
        DateTime horaEntrada;
        DateTime horasalida;
        //metodo contructor
        public EntidadHorarioP()
        {
           
        }

        public EntidadHorarioP(int id_horario, string id_profesor, string dia, DateTime horaEntrada, DateTime horasalida)
        {
            this.id_horario = id_horario;
            this.id_profesor = id_profesor;
            this.dia = dia;
            this.horaEntrada = horaEntrada;
            this.horasalida = horasalida;
        }

        //metodos get set
        public string Id_profesor { get => id_profesor; set => id_profesor = value; }
        public string Dia { get => dia; set => dia = value; }
        public DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public DateTime Horasalida { get => horasalida; set => horasalida = value; }
        public int Id_horario { get => id_horario; set => id_horario = value; }
    }
}
