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
    public partial class FormularioPrincipal : Form

    {


        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void ClickOpcionesMenu(object sender, EventArgs e)
        {
                
            ToolStripItem item = (ToolStripItem)sender;

            switch (item.Name)
            {
                case "insertarToolStripMenuItem":
                    Insertar formularioInsertar = new Insertar();
                    formularioInsertar.ShowDialog();
                    break;
                case "eliminarToolStripMenuItem":
                    Eliminar formularioEliminar = new Eliminar();
                    formularioEliminar.ShowDialog();
                    break;
                case "actualizarToolStripMenuItem":
                    Actualizar formularioActualizar = new Actualizar();
                    formularioActualizar.ShowDialog();
                    break;
                case "categoriaToolStripMenuItem":
                    Consultar_Categoria formularioConsultar = new Consultar_Categoria();
                    formularioConsultar.ShowDialog();
                    break;
                case "salirToolStripMenuItem":

                    //Preguntar al usuario si quiere salir
                    DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo);

                    //En caso de Yes, cerramos el programa
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    
                    break;
            }
        }


    }
}
