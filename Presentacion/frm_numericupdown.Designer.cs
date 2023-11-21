namespace Presentacion
{
    partial class frm_numericupdown
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
            this.num_dia = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_mostrar_dia = new System.Windows.Forms.Button();
            this.txt_resutado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_dia)).BeginInit();
            this.SuspendLayout();
            // 
            // num_dia
            // 
            this.num_dia.Location = new System.Drawing.Point(15, 85);
            this.num_dia.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.num_dia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_dia.Name = "num_dia";
            this.num_dia.ReadOnly = true;
            this.num_dia.Size = new System.Drawing.Size(144, 20);
            this.num_dia.TabIndex = 0;
            this.num_dia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_dia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de día de la semana:";
            // 
            // btn_mostrar_dia
            // 
            this.btn_mostrar_dia.Location = new System.Drawing.Point(15, 111);
            this.btn_mostrar_dia.Name = "btn_mostrar_dia";
            this.btn_mostrar_dia.Size = new System.Drawing.Size(144, 23);
            this.btn_mostrar_dia.TabIndex = 2;
            this.btn_mostrar_dia.Text = "Mostrar día en texto";
            this.btn_mostrar_dia.UseVisualStyleBackColor = true;
            this.btn_mostrar_dia.Click += new System.EventHandler(this.btn_mostrar_dia_Click);
            // 
            // txt_resutado
            // 
            this.txt_resutado.Location = new System.Drawing.Point(199, 84);
            this.txt_resutado.Name = "txt_resutado";
            this.txt_resutado.ReadOnly = true;
            this.txt_resutado.Size = new System.Drawing.Size(226, 20);
            this.txt_resutado.TabIndex = 3;
            // 
            // frm_numericupdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_resutado);
            this.Controls.Add(this.btn_mostrar_dia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_dia);
            this.Name = "frm_numericupdown";
            this.Text = "frm_numericupdown";
            ((System.ComponentModel.ISupportInitialize)(this.num_dia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_dia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mostrar_dia;
        private System.Windows.Forms.TextBox txt_resutado;
    }
}