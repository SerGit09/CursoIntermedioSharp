﻿namespace Presentacion.Reportes
{
    partial class Frm_rpt_Categorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_Reportes = new Presentacion.Reportes.DS_Reportes();
            this.uSPListadocaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_Listado_caTableAdapter = new Presentacion.Reportes.DS_ReportesTableAdapters.USP_Listado_caTableAdapter();
            this.txt_Parametro1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadocaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Reporte_Categorias";
            reportDataSource1.Value = this.uSPListadocaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.RPT_Categorias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPListadocaBindingSource
            // 
            this.uSPListadocaBindingSource.DataMember = "USP_Listado_ca";
            this.uSPListadocaBindingSource.DataSource = this.dS_Reportes;
            // 
            // uSP_Listado_caTableAdapter
            // 
            this.uSP_Listado_caTableAdapter.ClearBeforeFill = true;
            // 
            // txt_Parametro1
            // 
            this.txt_Parametro1.Location = new System.Drawing.Point(12, 71);
            this.txt_Parametro1.Name = "txt_Parametro1";
            this.txt_Parametro1.Size = new System.Drawing.Size(160, 20);
            this.txt_Parametro1.TabIndex = 1;
            this.txt_Parametro1.Visible = false;
            // 
            // Frm_rpt_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Parametro1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_rpt_Categorias";
            this.Text = "Frm_rpt_Categorias";
            this.Load += new System.EventHandler(this.Frm_rpt_Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadocaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPListadocaBindingSource;
        private DS_Reportes dS_Reportes;
        private DS_ReportesTableAdapters.USP_Listado_caTableAdapter uSP_Listado_caTableAdapter;
        public System.Windows.Forms.TextBox txt_Parametro1;
    }
}