using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_numericupdown : Form
    {
        public frm_numericupdown()
        {
            InitializeComponent();
        }

        private void btn_mostrar_dia_Click(object sender, EventArgs e)
        {
            int Nrodia = int.Parse(num_dia.Value.ToString());

            switch (Nrodia)
            {
                case 1: txt_resutado.Text = "Lunes";break;
                case 2: txt_resutado.Text = "Martes";break;
                case 3: txt_resutado.Text = "Miercoles";break;
                case 4: txt_resutado.Text = "Jueves";break;
                case 5: txt_resutado.Text = "Viernes";break;
                case 6: txt_resutado.Text = "Sabado"; break;
                case 7: txt_resutado.Text = "Domingo"; break;
            }
        }
    }
}
