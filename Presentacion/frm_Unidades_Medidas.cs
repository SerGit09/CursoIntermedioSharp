using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class frm_Unidades_Medidas : Form
    {
        public frm_Unidades_Medidas()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int Estadoguarda = 0; //Sin ninguna accion
        int NumeroCodigo = 0; //Se va a utilizar para guardar el codigo del registro seleccionado
        #endregion

        #region "Mis Metodos"

        private void Formato_ca()
        {
            dtg_categorias.Columns[0].Width = 80;
            dtg_categorias.Columns[0].HeaderText = "CODIGO";

            dtg_categorias.Columns[1].Width = 250;
            dtg_categorias.Columns[1].HeaderText = "UNIDADES DE MEDIDA";
        }

        private void Listado_um(string cTexto)
        {
            dtg_categorias.DataSource = CN_Unidades_Medidas.Listar_um(cTexto);
            this.Formato_ca();
        }

        private void Estado(bool lEstado)
        {
            txt_descripcion_um.Enabled = lEstado;
            btn_guardar.Enabled = lEstado;
            btn_cancelar.Enabled = lEstado;

            btn_actualizar.Enabled = !lEstado;
            btn_eliminar.Enabled = !lEstado;
            btn_reporte.Enabled = !lEstado;
            btn_salir.Enabled = !lEstado;

            txt_buscar.Enabled = !lEstado;
            btn_buscar.Enabled = !lEstado;

            dtg_categorias.Enabled = !lEstado;
        }
        #endregion

        private void frm_Unidades_Medidas_Load(object sender, EventArgs e)
        {
            this.Listado_um("%");
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_descripcion_um.Text))
            {
                MessageBox.Show("No se tiene información para ser guardada","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            string Respuesta = "";
            E_Unidades_Medidas NuevaUnidadMedida = new E_Unidades_Medidas()
            {
                Codigo_um = NumeroCodigo,
                Descripcion_um = txt_descripcion_um.Text.Trim()
            };

            Respuesta = CN_Unidades_Medidas.Guardar_um(Estadoguarda,NuevaUnidadMedida);
            if (Respuesta.Equals("OK"))
            {
                MessageBox.Show("Datos guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Listado_um("%");
                this.Estado(false);
                Estadoguarda = 0;
                NumeroCodigo = 0;
            }
            else
            {
                MessageBox.Show(Respuesta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_buscar.Text))
            {
                MessageBox.Show("Coloque una categoria para buscar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            this.Listado_um(txt_buscar.Text.Trim());
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Estado(true);
            txt_descripcion_um.Text = "";
            Estadoguarda = 1; //Estado de nuevo registro
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Estado(false);
            txt_descripcion_um.Text = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2;//Actualizar registro
            Estado(true);
        }

        private void dtg_categorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NumeroCodigo = int.Parse(dtg_categorias.CurrentRow.Cells[0].Value.ToString());
            txt_descripcion_um.Text = dtg_categorias.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string Respuesta;

            if (MessageBox.Show("¿Esta seguro de eliminar el registro?", "CONFIRMAR ELIMINACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                txt_descripcion_um.Text = "";
                MessageBox.Show("!!Eliminación cancelada!!", "CANCELADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Respuesta = CN_Unidades_Medidas.Eliminar_um(NumeroCodigo);
            if (Respuesta.Equals("OK"))
            {
                this.Listado_um("%");
                NumeroCodigo = 0; 
                txt_descripcion_um.Text = "";
                MessageBox.Show("Registro eliminado", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(Respuesta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_rpt_Unidades_Medidas NuevoReporte = new Reportes.Frm_rpt_Unidades_Medidas();
            NuevoReporte.txt_Parametro1.Text = txt_buscar.Text;
            NuevoReporte.ShowDialog();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
