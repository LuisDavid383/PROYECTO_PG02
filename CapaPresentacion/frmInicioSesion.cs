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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string clave = txtContraseña.Text;

            if (string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("No puede dejar espacios en blanco");
                return;
            }

            try
            {
                bool ValidarCredencial = ObjCredenciales.mtdCValidarCredencialesCN(correo, clave);

                if (ValidarCredencial)
                {
                    MessageBox.Show("Credenciales Correctas", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Credenciales Incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                // CAPTURAR LA EXCEPCION LANZADA POR EL INCORRECTO FORMATO DEL CORREO
                MessageBox.Show("Correo no válido o sin formato correcto", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrearCuenta CrearCuenta = new frmCrearCuenta();
            CrearCuenta.ShowDialog();
        }
    }
}
