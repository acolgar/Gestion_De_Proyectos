using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Proyectos
{
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
            BBDD.cargarProductosActualizar(cbActualizar);
        }
    }
}
