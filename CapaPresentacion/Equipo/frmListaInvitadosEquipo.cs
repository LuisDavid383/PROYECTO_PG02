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
    public partial class frmListaInvitadosEquipo : Form
    {
        private int IDEquipo_;

        public frmListaInvitadosEquipo(string IDEquipo)
        {
            InitializeComponent();
            IDEquipo_ = int.Parse(IDEquipo);
        }
    }
}
