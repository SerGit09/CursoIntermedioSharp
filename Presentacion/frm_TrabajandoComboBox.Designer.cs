namespace Presentacion
{
    partial class frm_TrabajandoComboBox
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
            this.cbo_cursos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_curso_seleccionado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_curso_nuevo = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo_cursos
            // 
            this.cbo_cursos.FormattingEnabled = true;
            this.cbo_cursos.Items.AddRange(new object[] {
            "C#",
            "Javascript",
            "CSS",
            "PHP"});
            this.cbo_cursos.Location = new System.Drawing.Point(371, 55);
            this.cbo_cursos.Name = "cbo_cursos";
            this.cbo_cursos.Size = new System.Drawing.Size(253, 21);
            this.cbo_cursos.TabIndex = 0;
            this.cbo_cursos.Text = "Seleccione un curso";
            this.cbo_cursos.SelectedIndexChanged += new System.EventHandler(this.cbo_cursos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Curso nuevo:";
            // 
            // txt_curso_seleccionado
            // 
            this.txt_curso_seleccionado.Location = new System.Drawing.Point(317, 120);
            this.txt_curso_seleccionado.Multiline = true;
            this.txt_curso_seleccionado.Name = "txt_curso_seleccionado";
            this.txt_curso_seleccionado.ReadOnly = true;
            this.txt_curso_seleccionado.Size = new System.Drawing.Size(273, 87);
            this.txt_curso_seleccionado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curso Seleccionado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cursos Disponibles:";
            // 
            // txt_curso_nuevo
            // 
            this.txt_curso_nuevo.Location = new System.Drawing.Point(88, 73);
            this.txt_curso_nuevo.Name = "txt_curso_nuevo";
            this.txt_curso_nuevo.Size = new System.Drawing.Size(135, 20);
            this.txt_curso_nuevo.TabIndex = 5;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(88, 99);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(135, 23);
            this.btn_registrar.TabIndex = 6;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // frm_TrabajandoComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 302);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_curso_nuevo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_curso_seleccionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_cursos);
            this.Name = "frm_TrabajandoComboBox";
            this.Text = "frm_TrabajandoComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_cursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_curso_seleccionado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_curso_nuevo;
        private System.Windows.Forms.Button btn_registrar;
    }
}