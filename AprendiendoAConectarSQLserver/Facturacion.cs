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
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "Select * From Usuario Where id_usuario=" + VentanaLogin.codigo.Trim() ;
            DataSet ds = Utilidades.Ejecutar(cmd);
            lbLeAtiende.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
        }
    }
}
