namespace Presentacion
{
    partial class frm_encuesta
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
            this.chk_programacion = new System.Windows.Forms.CheckBox();
            this.chk_excel = new System.Windows.Forms.CheckBox();
            this.chk_reparacion_computadoras = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_redes = new System.Windows.Forms.CheckBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_procesar = new System.Windows.Forms.Button();
            this.rad_presencial = new System.Windows.Forms.RadioButton();
            this.rad_virtual = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_programacion
            // 
            this.chk_programacion.AutoSize = true;
            this.chk_programacion.Location = new System.Drawing.Point(39, 70);
            this.chk_programacion.Name = "chk_programacion";
            this.chk_programacion.Size = new System.Drawing.Size(91, 17);
            this.chk_programacion.TabIndex = 0;
            this.chk_programacion.Text = "Programación";
            this.chk_programacion.UseVisualStyleBackColor = true;
            // 
            // chk_excel
            // 
            this.chk_excel.AutoSize = true;
            this.chk_excel.Location = new System.Drawing.Point(39, 110);
            this.chk_excel.Name = "chk_excel";
            this.chk_excel.Size = new System.Drawing.Size(52, 17);
            this.chk_excel.TabIndex = 1;
            this.chk_excel.Text = "Excel";
            this.chk_excel.UseVisualStyleBackColor = true;
            // 
            // chk_reparacion_computadoras
            // 
            this.chk_reparacion_computadoras.AutoSize = true;
            this.chk_reparacion_computadoras.Location = new System.Drawing.Point(39, 153);
            this.chk_reparacion_computadoras.Name = "chk_reparacion_computadoras";
            this.chk_reparacion_computadoras.Size = new System.Drawing.Size(167, 17);
            this.chk_reparacion_computadoras.TabIndex = 2;
            this.chk_reparacion_computadoras.Text = "Reparación de Computadoras";
            this.chk_reparacion_computadoras.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cursos Disponibles en Promoción";
            // 
            // chk_redes
            // 
            this.chk_redes.AutoSize = true;
            this.chk_redes.Location = new System.Drawing.Point(39, 189);
            this.chk_redes.Name = "chk_redes";
            this.chk_redes.Size = new System.Drawing.Size(57, 17);
            this.chk_redes.TabIndex = 4;
            this.chk_redes.Text = "Redes";
            this.chk_redes.UseVisualStyleBackColor = true;
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(266, 216);
            this.txt_resultado.Multiline = true;
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(339, 123);
            this.txt_resultado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(263, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado de los Cursos Seleccionados";
            // 
            // btn_procesar
            // 
            this.btn_procesar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_procesar.Location = new System.Drawing.Point(36, 237);
            this.btn_procesar.Name = "btn_procesar";
            this.btn_procesar.Size = new System.Drawing.Size(146, 84);
            this.btn_procesar.TabIndex = 7;
            this.btn_procesar.Text = "Procesar";
            this.btn_procesar.UseVisualStyleBackColor = false;
            this.btn_procesar.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // rad_presencial
            // 
            this.rad_presencial.AutoSize = true;
            this.rad_presencial.Location = new System.Drawing.Point(353, 70);
            this.rad_presencial.Name = "rad_presencial";
            this.rad_presencial.Size = new System.Drawing.Size(74, 17);
            this.rad_presencial.TabIndex = 8;
            this.rad_presencial.TabStop = true;
            this.rad_presencial.Text = "Presencial";
            this.rad_presencial.UseVisualStyleBackColor = true;
            // 
            // rad_virtual
            // 
            this.rad_virtual.AutoSize = true;
            this.rad_virtual.Location = new System.Drawing.Point(451, 69);
            this.rad_virtual.Name = "rad_virtual";
            this.rad_virtual.Size = new System.Drawing.Size(54, 17);
            this.rad_virtual.TabIndex = 9;
            this.rad_virtual.TabStop = true;
            this.rad_virtual.Text = "Virtual";
            this.rad_virtual.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(350, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "¿En qué escenario de aprendizaje te gustaría?";
            // 
            // frm_encuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rad_virtual);
            this.Controls.Add(this.rad_presencial);
            this.Controls.Add(this.btn_procesar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.chk_redes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_reparacion_computadoras);
            this.Controls.Add(this.chk_excel);
            this.Controls.Add(this.chk_programacion);
            this.Name = "frm_encuesta";
            this.Text = "ENCUESTA DE CURSOS DISPONIBLES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_programacion;
        private System.Windows.Forms.CheckBox chk_excel;
        private System.Windows.Forms.CheckBox chk_reparacion_computadoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_redes;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_procesar;
        private System.Windows.Forms.RadioButton rad_presencial;
        private System.Windows.Forms.RadioButton rad_virtual;
        private System.Windows.Forms.Label label3;
    }
}