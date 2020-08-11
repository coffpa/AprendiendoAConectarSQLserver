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
                    if (obj.SoloNumeros == true)
                    {
                        int contador=0, letrasEncontradas=0;
                        foreach (char letra in obj.Text.Trim())
                        { if (char.IsLetter(obj.Text.Trim(), contador))
                            { letrasEncontradas++; 
                            }
                        
                        contador++; 
                       }
                        if (letrasEncontradas != 0)
                        { hayErrores = true;
                            Error.SetError(obj, "Solo numeros");
                        }
                        
                    }
                   
                }
            
                        
            }
            return hayErrores;
        }
    }
}
