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
            string cmd = "Select * From Usuario Where id_usuario=" + VentanaLogin.codigo.Trim();
            DataSet ds = Utilidades.Ejecutar(cmd);
            lbLeAtiende.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text.Trim()) == false)
            {
                try
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
        public static int contadorFila = 0;
        public static double total;

        private void btnColocar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                bool existe = false;
                int num_fila = 0;
                if (contadorFila == 0)
                {
                    dataGridView1.Rows.Add(txtCodColum.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value);
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
                total = 0;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    total += Convert.ToDouble(fila.Cells[4].Value);
                   

                }
                lbtotal.Text = "$"+Convert.ToString(total);




            }
        }
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (contadorFila > 0)
            {
                total = total - Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value);
                lbtotal.Text = "$" + Convert.ToString(total); 
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            contadorFila--;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Consultarclientes concli = new Consultarclientes();
            concli.ShowDialog();
            if (concli.DialogResult == DialogResult.OK)
            {
                txtID.Text =Convert.ToString(concli.dataGridView1.Rows[concli.dataGridView1.CurrentRow.Index].Cells[0].Value);
                txtCliente.Text =Convert.ToString(concli.dataGridView1.Rows[concli.dataGridView1.CurrentRow.Index].Cells[1].Value);
                txtCodColum.Focus();
            
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ConsultarProductos conpro = new ConsultarProductos();
            conpro.ShowDialog();
            if (conpro.DialogResult == DialogResult.OK)
            {
                txtCodColum.Text = Convert.ToString(conpro.dataGridView1.Rows[conpro.dataGridView1.CurrentRow.Index].Cells[0].Value);
                txtDescripcion.Text = Convert.ToString(conpro.dataGridView1.Rows[conpro.dataGridView1.CurrentRow.Index].Cells[1].Value);
                txtPrecio.Text=Convert.ToString(conpro.dataGridView1.Rows[conpro.dataGridView1.CurrentRow.Index].Cells[2].Value);
                txtCantidad.Focus();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        public override void Nuevo()
        {
            txtID.Text = "";
            txtCliente.Text = "";
            txtCodColum.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            lbtotal.Text = "";
            dataGridView1.Rows.Clear();
            contadorFila = 0;
            total = 0;
            txtID.Focus();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (contadorFila != 0)
            {
                //try 
                //{
                    string cmd = string.Format("EXEC ActualizarFacturas '{0}'", txtID.Text.Trim());
                    DataSet ds = Utilidades.Ejecutar(cmd);
                    string numfact = ds.Tables[0].Rows[0]["num_fact"].ToString().Trim();
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {   if(!(Convert.ToInt32(fila.Cells[0].Value)==0))
                        {
                        cmd = string.Format("EXEC ActualizarDetalles '{0}','{1}','{2}','{3}'", numfact, Convert.ToString(fila.Cells[0].Value), Convert.ToString(fila.Cells[2].Value).Replace(',', '.'), Convert.ToString(fila.Cells[3].Value));
                        ds = Utilidades.Ejecutar(cmd);
                        }
                    }
                    cmd = "EXEC DatosFactura " + numfact;
                    ds = Utilidades.Ejecutar(cmd);
                    Reporte rp = new Reporte();
                rp.numFact = Convert.ToInt32(numfact);
                //rp.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
                    rp.ShowDialog();
                    Nuevo();
                //}
                //catch (Exception error)
                //{ MessageBox.Show("Ha ocurrido un error" + error.Message); 
                //}
            }

        }

        private void txtCodColum_TextChanged(object sender, EventArgs e)
        {
            //errorProvider1.Clear();
        }
    }
}
