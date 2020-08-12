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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text.Trim()) == false)
            {   try
                {
                    string cmd = string.Format("Select nom_cli From Cliente Where id_Cliente='{0}'", txtID.Text.Trim());
                    DataSet ds = new DataSet();
                    ds = Utilidades.Ejecutar(cmd);
                    txtCliente.Text = ds.Tables[0].Rows[0]["nom_cli"].ToString().Trim();
                    txtCodColum.Focus();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error" + error.Message); 
                }
            }
        }
        public static int contadorFila=0; 

        private void btnColocar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            { bool existe = false;
                int num_fila=0;
                if (contadorFila == 0)
                {   
                    dataGridView1.Rows.Add(txtCodColum.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value)* Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value); 
                    dataGridView1.Rows[contadorFila].Cells[4].Value = importe;
                    contadorFila++; 
                }
                else 
                {

                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                         if (Convert.ToString(fila.Cells[0].Value) == txtCodColum.Text)
                         {
                                existe = true;
                                num_fila = fila.Index;
                                
                         }
                        
                    }
                    if (existe == true)
                    {
                        dataGridView1.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value);
                        dataGridView1.Rows[num_fila].Cells[4].Value = importe;
                    }
                    else 
                    {
                        dataGridView1.Rows.Add(txtCodColum.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);
                        double importe = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value);
                        dataGridView1.Rows[contadorFila].Cells[4].Value = importe;
                        contadorFila++; 
                    }
                }





            }
        }
    }
}
