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
            string precioAntiguo = cbActualizar.SelectedItem.ToString().Split('|')[2].Trim();
            decimal nuevoPrecio = decimal.Parse(tbPrecioActualizar.Text);
            string nombreProducto = cbActualizar.SelectedItem.ToString().Split('|')[0].Trim();


            // Pregunta al usuario si desea cambiar el valor
            DialogResult dialogResult = MessageBox.Show($"¿Desea cambiar el precio del producto {nombreProducto} de {precioAntiguo} a {nuevoPrecio}?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Actualizar el precio
                BBDD.actualizarPrecioProducto(nombreProducto, nuevoPrecio);

                //Informar al usuario de que la actualización ha sido correcta
                MessageBox.Show("Precio actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Informar al usuario de que la actualización ha sido cancelada
                MessageBox.Show("Actualización cancelada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
