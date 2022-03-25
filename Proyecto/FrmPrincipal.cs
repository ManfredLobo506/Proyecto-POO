using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proyecto;

namespace Capa1Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstudiantes frm = new FrmEstudiantes();
            frm.Show();
        }

        private void ingresarMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMateriasIngreso frm = new FrmMateriasIngreso();
            frm.Show();
        }

        private void matriculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatricula frm = new FrmMatricula();
            frm.Show();
        }

        private void horarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

     
        private void horarioProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHorarioP frm = new FrmHorarioP();
            frm.Show();
        }

        private void detalleMatriculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetalleMatricula frm = new FrmDetalleMatricula();
            frm.Show();
        }

        private void ingresarMateriaAbiertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMateriasAbiertas frm = new FrmMateriasAbiertas();
            frm.Show();
        }

        private void certificadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCertificado frm = new FrmCertificado();
            frm.Show();
        }

        private void diasNoLectivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDiasNoLectivos frm = new FrmDiasNoLectivos();
            frm.Show();
        }

        private void profesoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProfesor frm = new FrmProfesor();
            frm.Show();
        }

        private void programarClaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProgramarClase frm = new FrmProgramarClase();
            frm.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmmnotas frm = new Frmmnotas();
                frm.Show();
        }
    }
}
