using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace miLibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {  SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TQI807P\SQLEXPRESS;Initial Catalog=Administracion;Integrated Security=True");
           con.Open();
           DataSet DS = new DataSet();  
            SqlDataAdapter DP = new SqlDataAdapter(cmd,con);
            DP.Fill(DS);
            con.Close();
            return (DS);
        }
        public static Boolean ValidarFormulario(Control objeto, ErrorProvider Error)
        { Boolean hayErrores = false;
            foreach (Control item in objeto.Controls)
            { if (item is ErrorTXTBox)
                {
                    ErrorTXTBox obj = (ErrorTXTBox)item;
                    if (obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            Error.SetError(obj, "No puede estar vacio");
                            hayErrores = true;
                        }
                    }
                    else
                        Error.SetError(obj, ""); 
                    
                    
                }        
                        
            }
            return hayErrores;
        }
    }
}
