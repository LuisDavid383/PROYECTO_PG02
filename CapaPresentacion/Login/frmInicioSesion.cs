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
    public partial class frmInicioSesion : Form
    {
        private clsCredenciales_CN ObjCredenciales = new clsCredenciales_CN();

        public frmInicioSesion()
        {
            InitializeComponent();
        }

        //METODO QUE VALIDA QUE NO SE INGRESEN CAMPOS VACIOS
        private bool mtdValidarCampoVacio(TextBox txt, string mensaje)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                epLogin.SetError(txt, mensaje);
                return false;
            }
            else
            {
                epLogin.SetError(txt, "");
                return true;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            epLogin.Clear();

            //DAR A CNOCER QUE NO PUEDE ESTAR VACIO
            bool correoValido = mtdValidarCampoVacio(txtCorreo, "El correo no puede estar vacío");
            bool claveValida = mtdValidarCampoVacio(txtContraseña, "La contraseña no puede estar vacía");

            // Si alguno falla, detener
            if (!correoValido || !claveValida)
            {
                return;
            }

            //VALORES
            string correo = txtCorreo.Text;
            string clave = txtContraseña.Text;

            try
            {
                bool ValidarCredencial = ObjCredenciales.mtdCValidarCredencialesCN(correo, clave); //VERIFICAR SI LAS CREDENCIALES SON CORRECTAS
                var GuardarUsuario = ObjCredenciales.mtdObtenerUsuarioCN(correo, clave); //GUARDAR LA INFORMACION DEL USUARIO PARA EL USO DEL SISTEMA

                if (ValidarCredencial)
                {                    
                    //GUADAR EL USUARIO EN UNA CLASE GLOBAL STATIC
                    clsSesionUsuario_CN.idUsuario = GuardarUsuario.idUsuario;
                    clsSesionUsuario_CN.NombreUsuario = GuardarUsuario.nombreUsuario;

                    frmPaginaPrincipal crearEquipo = new frmPaginaPrincipal();
                    crearEquipo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Credenciales Incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCrearCuenta CrearCuenta = new frmCrearCuenta();
            CrearCuenta.ShowDialog();
        }
    }
}
