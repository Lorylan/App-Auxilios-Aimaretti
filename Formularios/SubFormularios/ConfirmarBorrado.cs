using PuebaDeDiseñoAA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuebaDeDiseñoAA.Formularios.SubFormularios
{
    public partial class ConfirmarBorrado : Form
    {
        

        public ConfirmarBorrado(string[] info)
        {
            InitializeComponent();
            llenatTxt(info);
        }
        private void llenatTxt(string[] info) {
            txt_dato1.Text = info[0];
            txt_dato2.Text = info[1];
         
        }
    }
}
