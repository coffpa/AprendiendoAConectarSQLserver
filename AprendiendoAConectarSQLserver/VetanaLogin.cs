using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using miLibreria;

namespace AprendiendoAConectarSQLserver
{
    public partial class VentanaLogin : FormularioBase
    {
        public VentanaLogin()    
        {
            InitializeComponent();
        }
        public static string codigo="";

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            try
            {
                
                
                String cmd = string.Format(@"select * from Usuario where cuenta='{0}' AND contraseña='{1}'", txtUsuario.Text.Trim(),txtContraseña.Text.Trim());
               
                DataSet DC = Utilidades.Ejecutar(cmd);
                codigo = DC.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                

                string cuenta = DC.Tables[0].Rows[0]["cuenta"].ToString().Trim();
                string contraseña = DC.Tables[0].Rows[0]["contraseña"].ToString().Trim();
                    
                
                if (cuenta == txtUsuario.Text.Trim() && contraseña==txtContraseña.Text.Trim())
                {

                    if (Convert.ToBoolean(DC.Tables[0].Rows[0]["Status_admin"]) == true)
                    {
                        VentanaAdmin venAd = new VentanaAdmin();
                        this.Hide();
                        venAd.Show();
                    }
                    else
                    {
                        VentanaUser venUs = new VentanaUser();
                        this.Hide();
                        venUs.Show();
                    }
                }
                
            }
            catch(Exception error)
            {
               MessageBox.Show("Usuario y/o contraseña incorrecto" + error.Message);

            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void VetanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
