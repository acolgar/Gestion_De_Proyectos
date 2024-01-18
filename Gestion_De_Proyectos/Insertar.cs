using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_De_Proyectos
{
    public partial class Insertar : Form
    {
        public Insertar()
        {
            InitializeComponent();
        }

        private void bInsertar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombreInsertar.Text;
            string categoria = tbCategoriaInsertar.Text;
            decimal precio;

            if (!decimal.TryParse(tbPrecioInsertar.Text, out precio))
            {
                MessageBox.Show("Por favor introduce un precio válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            precio = Math.Round(precio, 2); //Redondeamos el precio a 2 decimales

            string INSTRUCCION = "INSERT INTO dbo.Producto (Nombre, Categoria, Precio) VALUES (@nombre, @categoria, @precio);";

            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("Por favor introduce todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Controlamos que el nombre no tenga más de 50 caracteres, que la categoría no tenga más de 30 y que el precio no sea negativo
            if (nombre.Length > 50 || categoria.Length > 30 || precio < 0)
            {
                MessageBox.Show("Por favor introduce los datos correctamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //He hecho este procedimiento con parámetros para que se introduzca el precio con la , y no de fallo
                SqlParameter paramNombre = new SqlParameter("@nombre", nombre);
                SqlParameter paramCategoria = new SqlParameter("@categoria", categoria);
                SqlParameter paramPrecio = new SqlParameter("@precio", precio);

                BBDD.insertarProductos(INSTRUCCION, paramNombre, paramCategoria, paramPrecio);
                MessageBox.Show("Producto insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiamos los campos
                tbNombreInsertar.Text = "";
                tbCategoriaInsertar.Text = "";
                tbPrecioInsertar.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

