using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCrearCuenta : Form
    {
        private clsCrearCuenta_CN ObjCrearCuenta = new clsCrearCuenta_CN();

        public frmCrearCuenta()
        {
            InitializeComponent();
        }

        public bool mtdVerficarCamposVacios()
        {
            
            
            return true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //INFORMACION DE LA CUENTA
            string NombreUsuario = txtNomUsuario.Text;
            string Correo = txtCorreo.Text;
            string Clave = txtContraseña.Text;
            

            //INFORMACION PERSONAL
            string Nombres = txtNombres.Text;
            string ApellidoPaterno = txtPaterno.Text;
            string ApellidoMaterno = txtMaterno.Text;
            DateTime FechaNacimiento = dtpNacimiento.Value;
            string Telefono = txttelefono.Text;

            try
            {
                ObjCrearCuenta.mtdCrearCuentaCN(NombreUsuario,
                                                Correo,
                                                Clave,
                                                Nombres,
                                                ApellidoPaterno,
                                                ApellidoMaterno,
                                                FechaNacimiento,
                                                Telefono);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
