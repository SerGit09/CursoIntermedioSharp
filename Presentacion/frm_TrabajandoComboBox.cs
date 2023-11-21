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
    public partial class frm_TrabajandoComboBox : Form
    {
        public frm_TrabajandoComboBox()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            string NuevoCurso = txt_curso_nuevo.Text;
            cbo_cursos.Items.Add(NuevoCurso);

            MessageBox.Show("Curso Agregado");
            txt_curso_nuevo.Text = "";
        }

        private void cbo_cursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_curso_seleccionado.Text = "Curso Seleccionado: " +  cbo_cursos.SelectedItem.ToString();
        }
    }
}
