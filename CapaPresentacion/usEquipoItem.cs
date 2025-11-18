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
    public partial class usEquipoItem : UserControl
    {
        public usEquipoItem()
        {
            InitializeComponent();
        }

        // PROPIEDADES PÚBLICAS PARA ASIGNAR DATOS
        //public Image ImagenEquipo
        //{
        //    get { return picImagen.Image; }
        //    set { picImagen.Image = value; }
        //}

        public string NombreEquipo
        {
            get { return lblNombreEquipo.Text; }
            set { lblNombreEquipo.Text = value; }
        }

        public string Descripcion
        {
            get { return lblDescripcion.Text; }
            set { lblDescripcion.Text = value; }
        }

        //// EVENTO PARA CUANDO SE HAGA CLICK EN EL BOTÓN
        //public event EventHandler VerIntegrantesClicked;

        //private void btnVer_Click(object sender, EventArgs e)
        //{
        //    VerIntegrantesClicked?.Invoke(this, EventArgs.Empty);
        //}
    }
}
