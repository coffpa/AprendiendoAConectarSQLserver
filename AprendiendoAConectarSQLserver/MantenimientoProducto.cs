using miLibreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprendiendoAConectarSQLserver
{
    public partial class MantenimientoProducto : Mantenimiento
    {
        public MantenimientoProducto()
        {
            InitializeComponent();
        }
        public override bool Guardar()
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    string cmd = string.Format("EXEC ActualizaArticulo '{0}','{1}','{2}'", txtIdProducto.Text.Trim(), txtDescripcionProd.Text.Trim(), txtPrecio.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se ha guardado correctamente");
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ha ocurrido un error " + e.Message);
                    return false;
                }
            }
            else { return false; }
        }
        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarArticulo '{0}'", txtIdProducto.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado");

            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error: ", e.Message);
            }
        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }

}
