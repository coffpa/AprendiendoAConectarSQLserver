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
    public partial class VentanaAdmin : FormularioBase
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Usuario Where id_usuario="+VentanaLogin.codigo;
            DataSet DS = Utilidades.Ejecutar(cmd);
            lbNomAd.Text = DS.Tables[0].Rows[0]["nombre"].ToString();
            lbUsAdmin.Text = DS.Tables[0].Rows[0]["cuenta"].ToString();
            lbIDAdmin.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();
            string url = DS.Tables[0].Rows[0]["Foto"].ToString();
            pictureBox1.Image = Image.FromFile(url);

        }

        private void btnGeneradorPrincipal_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal CP = new ContenedorPrincipal();
            this.Hide();
            CP.Show();
        }
    }
}
