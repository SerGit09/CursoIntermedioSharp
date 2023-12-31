﻿using System;
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
    public partial class frm_principal : Form
    {
        MiPrimerFormulario miPrimerFormulario;
        frm_trackbar frm_Trackbar;
        Frm_Categorias frm_categoria;
        frm_Unidades_Medidas frm_Unidad_Medida;
        public frm_principal()
        {
            InitializeComponent();
        }


        private void miPrimerFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(miPrimerFormulario == null)
            {
                miPrimerFormulario = new MiPrimerFormulario();
                miPrimerFormulario.MdiParent = this;
                miPrimerFormulario.FormClosed += new FormClosedEventHandler(Alta_frm_01);
                miPrimerFormulario.Show();
            }
            else
            {
                //Para que se ponga al frente si ya esta abierto
                miPrimerFormulario.Activate();
            }
        }

        void Alta_frm_01(object sender, EventArgs e)
        {
            miPrimerFormulario = null;
        }

        private void trackbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frm_Trackbar == null)
            {
                frm_Trackbar = new frm_trackbar();
                frm_Trackbar.MdiParent = this;
                frm_Trackbar.FormClosed += new FormClosedEventHandler(Alta_frm_02);
                frm_Trackbar.Show();
            }
            else
            {
                frm_Trackbar.Activate();
            }
        }

        void Alta_frm_02(object sender, EventArgs e)
        {
            frm_Trackbar = null;
        }

        private void m_btn_01_Click(object sender, EventArgs e)
        {
            if (miPrimerFormulario == null)
            {
                miPrimerFormulario = new MiPrimerFormulario();
                miPrimerFormulario.MdiParent = this;
                miPrimerFormulario.FormClosed += new FormClosedEventHandler(Alta_frm_01);
                miPrimerFormulario.Show();
            }
            else
            {
                //Para que se ponga al frente si ya esta abierto
                miPrimerFormulario.Activate();
            }
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_categoria == null)
            {
                frm_categoria = new Frm_Categorias();
                frm_categoria.MdiParent = this;
                frm_categoria.FormClosed += new FormClosedEventHandler(Alta_frm_categoria);
                frm_categoria.Show();
            }
            else
            {
                //Para que se ponga al frente si ya esta abierto
                frm_categoria.Activate();
            }
        }

        void Alta_frm_categoria(object sender, EventArgs e)
        {
            frm_categoria = null;
        }

        private void unidadesMedidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_Unidad_Medida == null)
            {
                frm_Unidad_Medida = new frm_Unidades_Medidas();
                frm_Unidad_Medida.MdiParent = this;
                frm_Unidad_Medida.FormClosed += new FormClosedEventHandler(Alta_frm_Unidades_Medidas);
                frm_Unidad_Medida.Show();
            }
            else
            {
                //Para que se ponga al frente si ya esta abierto
                frm_Unidad_Medida.Activate();
            }
        }

        void Alta_frm_Unidades_Medidas(object sender, EventArgs e)
        {
            frm_Unidad_Medida = null;
        }
    }
}
