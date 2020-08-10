using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace miLibreria
{
    public partial class ErrorTXTBox : TextBox
    {
        public ErrorTXTBox()
        {
            
            InitializeComponent();
        }
        public Boolean Validar
        {

            set;
            get;
            
        
        }
    }
}
