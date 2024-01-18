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
    public partial class Consultar_Categoria : Form
    {
        public Consultar_Categoria()
        {
            InitializeComponent();
        }

        private void bConsultar_Click(object sender, EventArgs e)
        {
            //Obtenemos la categoria que ha introducido el usuario
            string categoria = tbIndicarCategoria.Text;

            //Obtenemos la lista de productos de la categoria indicada
            List<string> listaProductos = BBDD.obtenerProductosPorCategoria(categoria);

            //Limpiamos el listbox
            lbConsultarProd.Items.Clear();

            //Añadimos los productos al listbox
            foreach (string producto in listaProductos)
            {
                lbConsultarProd.Items.Add(producto);
            }
        }
    }
}
