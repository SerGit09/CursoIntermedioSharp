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
    public partial class frm_datagridview : Form
    {
        public frm_datagridview()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if(txt_nombre.Text != "" && txt_email.Text != "")
            {
                dtg_datos.Rows.Add(txt_nombre.Text,txt_email.Text);
                MessageBox.Show("Agregado");

                txt_email.Text = "";
                txt_nombre.Text = "";
                txt_nombre.Focus();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta;
            Respuesta = MessageBox.Show("¿Estas seguro de eliminar la fila seleccionada?","CONFIRMAR ELIMINACION",MessageBoxButtons.YesNo);
            if(Respuesta == DialogResult.No)
            {
                MessageBox.Show("Eliminacion cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int nFila = dtg_datos.CurrentRow.Index;

            //Quitar
            dtg_datos.Rows.RemoveAt(nFila);
            MessageBox.Show("Registro eliminado");

        }

        private void dtg_datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nombre.Text = dtg_datos.CurrentRow.Cells[0].Value.ToString();
            txt_email.Text = dtg_datos.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
