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
    public partial class Consultas : FormularioBase
    {
        public Consultas()
        {
            InitializeComponent();
        }
        public DataSet LlenarDataGriedView(string tabla)
        {
            DataSet ds;
            string cmd = string.Format("Select * From " + tabla);
            ds = Utilidades.Ejecutar(cmd);
            return ds;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;
            else 
            { DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
