using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuxiliosAimaretti.Formularios.SubFormularios
{
    public partial class Recordatorio : Form
    {
        public Recordatorio(String hoy, String recordatorio)
        {
            InitializeComponent();
            txt_pagos_hoy.Text = hoy;
            txt_pagos_recordatorio.Text = recordatorio;
        }
    }
}
