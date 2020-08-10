using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using miLibreria;

namespace AprendiendoAConectarSQLserver
{
    public partial class MantenimientoCliente : Mantenimiento
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }
        public override bool Guardar()
        {
            try
            {
                string cmd = string.Format("EXEC ActualizaCliente '{0}','{1}','{2}'", txtIdCliente.Text.Trim(),txtNombrecli.Text.Trim(), txtApellidoCli.Text.Trim());
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
        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarCliente '{0}'", txtIdCliente.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado");

            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error: ", e.Message);
            }
        }
    }
}
