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
    public partial class MiPrimerFormulario : Form
    {
        public MiPrimerFormulario()
        {
            InitializeComponent();
        }
        //Variables
        bool actualizando = false;
        

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";

            grpMantenimiento.Enabled = false;

            grpBotones.Enabled = true;

            txtCodigo.Enabled = true;
            lst_mantenimiento.Enabled = true;
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string Registro =  txtCodigo.Text.Trim() + " - " +  txtDescripcion.Text.Trim();

            if (actualizando)//Actualizar
            {
                int ElementoSeleccionado = lst_mantenimiento.SelectedIndex;
                lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem);
                lst_mantenimiento.Items.Insert(ElementoSeleccionado, Registro);
                MessageBox.Show("Registro actualizado");
            }
            else//Agregar
            {
                lst_mantenimiento.Items.Add(Registro);

                MessageBox.Show("Registro agregado correctamente");
            }

            

            txtCodigo.Text = "";
            txtDescripcion.Text = "";

            grpMantenimiento.Enabled = false;
            txtCodigo.Enabled = true;
            lst_mantenimiento.Enabled = true;

            grpBotones.Enabled = true; 
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";

            grpMantenimiento.Enabled = true;

            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;
            txtCodigo.Focus();

            grpBotones.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem.ToString());
            MessageBox.Show("Elemento eliminado");
        }

        private void lst_mantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_mantenimiento_Click(object sender, EventArgs e)
        {
            int LongitudTexto;
            string textoSeleccionado = this.lst_mantenimiento.SelectedItem.ToString().Trim();
            LongitudTexto = textoSeleccionado.Length;

            txtCodigo.Text = textoSeleccionado.Substring(0,3);
            txtDescripcion.Text = textoSeleccionado.Substring(6, LongitudTexto -6);

            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizando = true;
            lst_mantenimiento.Enabled = false;

            grpBotones.Enabled = false;
            grpMantenimiento.Enabled = true;
            txtCodigo.Enabled = false;
        }
    }
}
