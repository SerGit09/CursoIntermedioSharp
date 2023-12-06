using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Reportes
{
    public partial class Frm_rpt_Categorias : Form
    {
        public Frm_rpt_Categorias()
        {
            InitializeComponent();
        }

        private void Frm_rpt_Categorias_Load(object sender, EventArgs e)
        {
            this.uSP_Listado_caTableAdapter.Fill(this.dS_Reportes.USP_Listado_ca,cTexto: txt_Parametro1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
