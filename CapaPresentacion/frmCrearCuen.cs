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
    public partial class frmCrearCuen : Form
    {
        private clsCrearCuenta_CN ObjCrearCuenta = new clsCrearCuenta_CN();

        public frmCrearCuen()
        {
            InitializeComponent();
        }

        private void frmCrearCuen_Load(object sender, EventArgs e)
        {
            lblErrorCorreo.Visible = false;
            lblErrorNombre.Visible = false;
            lblErrorApePaterno.Visible = false;
            lblErrorApeMaterno.Visible = false;
            lblErrorDocumento.Visible = false;
            lblErrorFechaNacimiento.Visible = false;
            lblErrorTelefono.Visible = false;
            lblErrorGenero.Visible = false;
            lblErrorNomUsuario.Visible = false;
            lblErrorContraseña.Visible = false;

            cmbTipoDocumento.DataSource = ObjCrearCuenta.mtdListarTipoDocumentoActivosCD();
            cmbTipoDocumento.DisplayMember = "TipoDocumento";
            cmbTipoDocumento.ValueMember = "IDTipoDocumento";

            cmbTipoDocumento.SelectedIndex = -1;
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            //INFORMACION DE LA CUENTA
            string NombreUsuario = txtNomUsuario.Text;
            string Clave = txtContraseña.Text;


            //INFORMACION PERSONAL
            string Nombres = txtNombre.Text.ToUpper();
            string ApellidoPaterno = txtApellidoPaterno.Text.ToUpper();
            string ApellidoMaterno = txtApellidoMaterno.Text.ToUpper();
            string Documento = txtDocumento.Text;
            string Genero = cmbGenero.Text;

            int IDTipoDocumento = Convert.ToInt32(cmbTipoDocumento.SelectedValue);

            DateTime FechaNacimiento = dtpFechaNacimiento.Value;
            string Telefono = txtTelefono.Text;
            string Correo = txtCorreo.Text;

            try
            {
                //NO DEBE PERMITIR QUE OTRO USUARIO SE CREE UNA CUENTA CON UN CORREO YA REGISTRADO
                /*
                 * DAR A CONOCER QUE EL CORREO YA ESTA EN USO
                 */

                ObjCrearCuenta.mtdCrearCuentaCN(Nombres,
                                                ApellidoPaterno,
                                                ApellidoMaterno,
                                                IDTipoDocumento,
                                                Documento,
                                                FechaNacimiento,
                                                Telefono,
                                                Correo,
                                                Genero,
                                                NombreUsuario,
                                                Clave);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void mtdEnterTextBox(string Texto, TextBox text)
        {
            if (text.Text == Texto)
            {
                text.Text = "";
                text.ForeColor = Color.LightGray;
            }
        }

        private void mtdLeaveTextBox(string Texto, TextBox text)
        {
            if (text.Text == "")
            {
                text.Text = Texto;
                text.ForeColor = Color.DimGray;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            mtdEnterTextBox("CORREO", txtCorreo);
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            mtdLeaveTextBox("CORREO", txtCorreo);
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            mtdEnterTextBox("NOMBRE", txtNombre);
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            mtdLeaveTextBox("NOMBRE", txtNombre);
        }

        private void txtApellidoPaterno_Enter(object sender, EventArgs e)
        {
            mtdEnterTextBox("APELLIDO PATERNO", txtApellidoPaterno);
        }

        private void txtApellidoPaterno_Leave(object sender, EventArgs e)
        {
            mtdLeaveTextBox("APELLIDO PATERNO", txtApellidoPaterno);
        }

        private void txtApellidoMaterno_Enter(object sender, EventArgs e)
        {
            mtdEnterTextBox("APELLIDO MATERNO", txtApellidoMaterno);
        }

        private void txtApellidoMaterno_Leave(object sender, EventArgs e)
        {
            mtdLeaveTextBox("APELLIDO MATERNO", txtApellidoMaterno);
        }

        private void txtDocumento_Enter(object sender, EventArgs e)
        {
            mtdEnterTextBox("DOCUMENTO", txtDocumento);
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            mtdLeaveTextBox("DOCUMENTO", txtDocumento);
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            mtdEnterTextBox("TELEFONO", txtTelefono);
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            mtdLeaveTextBox("TELEFONO", txtTelefono);
        }

        private void txtNomUsuario_Enter(object sender, EventArgs e)
        {
            mtdEnterTextBox("NOMBRE DE USUARIO", txtNomUsuario);
        }

        private void txtNomUsuario_Leave(object sender, EventArgs e)
        {
            mtdLeaveTextBox("NOMBRE DE USUARIO", txtNomUsuario);
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            mtdEnterTextBox("CONTRASEÑA", txtContraseña);
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            mtdLeaveTextBox("CONTRASEÑA", txtContraseña);
        }
    }
}
