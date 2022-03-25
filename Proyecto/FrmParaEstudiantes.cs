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
using Proyecto;



namespace Capa1Presentacion
{
    public partial class FrmParaEstudiantes : Form
    {
        public FrmParaEstudiantes()
        {
            InitializeComponent();
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

        private void catalogoMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaterias frm = new FrmMaterias();
            frm.Show();
        }
    }
}
