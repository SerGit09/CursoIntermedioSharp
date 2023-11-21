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
    public partial class frm_encuesta : Form
    {
        public frm_encuesta()
        {
            InitializeComponent();
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            string Resultado = "";

            if (chk_programacion.Checked)
            {
                Resultado += chk_programacion.Text + ", ";
            }
            if (chk_excel.Checked)
            {
                Resultado += chk_excel.Text + ", ";
            }
            if (chk_reparacion_computadoras.Checked)
            {
                Resultado += chk_reparacion_computadoras.Text + ", ";
            }
            if (chk_redes.Checked)
            {
                Resultado += chk_redes.Text;
            }

            //Evaluando proceso de selección del radio button
            if (rad_presencial.Checked)
            {
                Resultado += " :::::: " + rad_presencial.Text + " :::::: ";
            }
            else
            {
                Resultado += " :::::: " + rad_virtual.Text + " :::::: ";
            }

            txt_resultado.Text = Resultado;
        }
    }
}
