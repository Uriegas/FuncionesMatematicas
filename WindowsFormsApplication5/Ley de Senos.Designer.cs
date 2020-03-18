namespace WindowsFormsApplication5
{
    partial class Ley_de_Senos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aa = new System.Windows.Forms.TextBox();
            this.bb = new System.Windows.Forms.TextBox();
            this.angulo11 = new System.Windows.Forms.TextBox();
            this.angulo22 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.regresar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.angulo33 = new System.Windows.Forms.TextBox();
            this.cc = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "LEY DE SENOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese al menos 3 medidas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese al menos 3 valores";
            // 
            // aa
            // 
            this.aa.Location = new System.Drawing.Point(40, 127);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(100, 20);
            this.aa.TabIndex = 8;
            // 
            // bb
            // 
            this.bb.Location = new System.Drawing.Point(40, 166);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(100, 20);
            this.bb.TabIndex = 9;
            // 
            // angulo11
            // 
            this.angulo11.Location = new System.Drawing.Point(226, 127);
            this.angulo11.Name = "angulo11";
            this.angulo11.Size = new System.Drawing.Size(100, 20);
            this.angulo11.TabIndex = 10;
            // 
            // angulo22
            // 
            this.angulo22.Location = new System.Drawing.Point(226, 166);
            this.angulo22.Name = "angulo22";
            this.angulo22.Size = new System.Drawing.Size(100, 20);
            this.angulo22.TabIndex = 11;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.BackColor = System.Drawing.Color.Transparent;
            this.resultado.Location = new System.Drawing.Point(165, 261);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(146, 13);
            this.resultado.TabIndex = 12;
            this.resultado.Text = "No ha ingresado ningun valor";
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Resultado =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(14, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "a = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(14, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "b = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(165, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ángulo 1 =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(165, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "ángulo 2 =";
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.SystemColors.Control;
            this.regresar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresar.Location = new System.Drawing.Point(242, 341);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(84, 29);
            this.regresar.TabIndex = 18;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(165, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "ángulo 3 =";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(14, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "c = ";
            // 
            // angulo33
            // 
            this.angulo33.Location = new System.Drawing.Point(226, 205);
            this.angulo33.Name = "angulo33";
            this.angulo33.Size = new System.Drawing.Size(100, 20);
            this.angulo33.TabIndex = 20;
            // 
            // cc
            // 
            this.cc.Location = new System.Drawing.Point(40, 205);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(100, 20);
            this.cc.TabIndex = 19;
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.SystemColors.Control;
            this.calcular.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.Location = new System.Drawing.Point(242, 294);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(84, 29);
            this.calcular.TabIndex = 23;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // Ley_de_Senos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication5.Properties.Resources.Fondo_con_degradado_azul;
            this.ClientSize = new System.Drawing.Size(344, 382);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.angulo33);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.angulo22);
            this.Controls.Add(this.angulo11);
            this.Controls.Add(this.bb);
            this.Controls.Add(this.aa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ley_de_Senos";
            this.Text = "Ley_de_Senos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aa;
        private System.Windows.Forms.TextBox bb;
        private System.Windows.Forms.TextBox angulo11;
        private System.Windows.Forms.TextBox angulo22;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox angulo33;
        private System.Windows.Forms.TextBox cc;
        private System.Windows.Forms.Button calcular;
    }
}