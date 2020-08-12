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
    public partial class Consultarclientes : Consultas
    {
        public Consultarclientes()
        {
            InitializeComponent();
        }

        private void Consultarclientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarDataGriedView("Cliente").Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            { try
                {
                    DataSet ds;
                    string cmd = string.Format("Select * from Cliente Where nom_cli LIKE ('%" + textBox1.Text.Trim() + "%')");
                    ds = Utilidades.Ejecutar(cmd);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {MessageBox.Show("Ha ocurrido un error"+ error); 
                }
                
                
                
            }
        }
    }
}
