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
            cbActualizar.SelectedIndexChanged += CbActualizar_SelectedIndexChanged;
        }

        private void CbActualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Suponiendo que tienes TextBoxes para Nombre, Categoria y Precio
            var selectedProduct = cbActualizar.SelectedItem.ToString().Split('|');
            tbProductoActualizar.Text = selectedProduct[0].Trim();
            tbCategoriaActualizar.Text = selectedProduct[1].Trim();
            tbPrecioActualizar.Text = selectedProduct[2].Trim();
        }

        private void bActualizarPrecio(object sender, EventArgs e)
        {
            

        }
    }
}
