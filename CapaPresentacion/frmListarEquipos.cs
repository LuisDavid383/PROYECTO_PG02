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
    public partial class frmListarEquipos : Form
    {
        private clsGestionEquipos_CN ObjGestionEquipos = new clsGestionEquipos_CN();

        int IDUsuarioActual = clsSesionUsuario_CN.idUsuario;


        public frmListarEquipos()
        {
            InitializeComponent();
        }

        private void mtdCargarEquipos()
        {
            flpListaEquipos.Controls.Clear();

            DataTable tabla = ObjGestionEquipos.mtdListarEquiposPorUsuarioCD(IDUsuarioActual);

            foreach (DataRow fila in tabla.Rows)
            {
                usEquipoItem item = new usEquipoItem();

                item.NombreEquipo = fila["NombreEquipo"].ToString();
                item.Descripcion = fila["Descripcion"].ToString();

                // Si tienes imágenes más adelante aquí la cargas:
                // item.ImagenEquipo = Image.FromFile(ruta);

                int idEquipo = Convert.ToInt32(fila["IDEquipo"]);

                flpListaEquipos.Controls.Add(item);
            }
        }

        private void frmListarEquipos_Load(object sender, EventArgs e)
        {
            mtdCargarEquipos();
        }
    }
}
