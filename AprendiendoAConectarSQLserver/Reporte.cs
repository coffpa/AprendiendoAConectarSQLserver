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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }
        public int numFact { get; set; }
        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DatosFactura' table. You can move, or remove it, as needed.
            this.DatosFacturaTableAdapter.Fill(this.DataSet1.DatosFactura,numFact);

            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
    }
}
