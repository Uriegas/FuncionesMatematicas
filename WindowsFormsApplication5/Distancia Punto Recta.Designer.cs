namespace WindowsFormsApplication5
{
    partial class Distancia_Punto_Recta
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
            this.label8 = new System.Windows.Forms.Label();
            this.rectaA = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.y1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rectaB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rectaC = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(257, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Recta";
            // 
            // rectaA
            // 
            this.rectaA.Location = new System.Drawing.Point(165, 124);
            this.rectaA.Name = "rectaA";
            this.rectaA.Size = new System.Drawing.Size(52, 20);
            this.rectaA.TabIndex = 64;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(330, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 31);
            this.button2.TabIndex = 63;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.BackColor = System.Drawing.Color.Transparent;
            this.resultado.Location = new System.Drawing.Point(257, 165);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(158, 13);
            this.resultado.TabIndex = 62;
            this.resultado.Text = "No ha ingresado valores válidos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(24, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(24, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "x";
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(42, 157);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(52, 20);
            this.y1.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(5, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 143);
            this.panel1.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 56;
            this.label5.Text = "Resultado =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(59, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "P1";
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(42, 124);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(52, 20);
            this.x1.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(39, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Ingrese un punto y una recta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 38);
            this.label1.TabIndex = 50;
            this.label1.Text = "DISTANCIA PUNTO-RECTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(139, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(234, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "B";
            // 
            // rectaB
            // 
            this.rectaB.Location = new System.Drawing.Point(260, 124);
            this.rectaB.Name = "rectaB";
            this.rectaB.Size = new System.Drawing.Size(52, 20);
            this.rectaB.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(328, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "C";
            // 
            // rectaC
            // 
            this.rectaC.Location = new System.Drawing.Point(354, 124);
            this.rectaC.Name = "rectaC";
            this.rectaC.Size = new System.Drawing.Size(52, 20);
            this.rectaC.TabIndex = 69;
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.SystemColors.Control;
            this.calcular.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.Location = new System.Drawing.Point(302, 206);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(85, 31);
            this.calcular.TabIndex = 71;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // Distancia_Punto_Recta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication5.Properties.Resources.Fondo_con_degradado_azul;
            this.ClientSize = new System.Drawing.Size(440, 361);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rectaC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rectaB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rectaA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Distancia_Punto_Recta";
            this.Text = "Distancia_Punto_Recta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox rectaA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rectaB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rectaC;
        private System.Windows.Forms.Button calcular;
    }
}