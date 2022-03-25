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
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EntidadUsuarios usuarios = new EntidadUsuarios();
               usuarios.Nombre = (TXTuser.Text);
                int resultado;
                string permiso;
                BLusuarios logica = new BLusuarios(Configuracion.getConnetionString);

                try
                {
                    if (!string.IsNullOrEmpty(TXTuser.Text) && !string.IsNullOrEmpty(txtContra.Text))
                    {
                    usuarios.Nombre = TXTuser.Text;
                    usuarios.Contra = txtContra.Text;
                    resultado = logica.ComprobarConSP(usuarios);
                    
                    permiso = logica.Mensaje;
                        if (resultado==0)
                        {
                            MessageBox.Show("El usuario no existe", "Aviso", MessageBoxButtons.OK);
                        }
                        else if (resultado == 1)
                        {
                            MessageBox.Show("Contraseña incorrecta", "Aviso", MessageBoxButtons.OK);
                        }

                        if (permiso=="ADMIN")
                        {
                        FrmPrincipal frm = new FrmPrincipal();
                            frm.Show();
                        }
                        if (permiso == "EST")
                        {
                            FrmParaEstudiantes frm = new FrmParaEstudiantes();
                            frm.Show();
                        }

                }
                    else
                    {
                        MessageBox.Show("Debe ingresar todos los datos", "Aviso", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
    }
}
