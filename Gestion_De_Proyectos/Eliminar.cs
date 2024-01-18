using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestion_De_Proyectos
{
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();

            // Cargamos los productos en el combobox al iniciar el formulario
            BBDD.cargarProductosEliminar(cbEliminar);
        }


        private void bEliminar_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = cbEliminar.SelectedItem.ToString();
            DialogResult dialogResult = MessageBox.Show($"Estás seguro de que quieres eliminar {productoSeleccionado}?", 
                "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BBDD.eliminarProducto(productoSeleccionado);
                MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Actualizamos el combobox para que no aparezca el producto eliminado

                cbEliminar.Items.Remove(productoSeleccionado);
            }
            else
            {
                MessageBox.Show("Producto no eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }







    }
}
