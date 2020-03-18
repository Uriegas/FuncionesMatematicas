namespace WindowsFormsApplication5
{
    partial class Distancia_entre_dos_puntos
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
            this.x1 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.y1 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "DISTANCIA ENTRE DOS PUNTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese dos puntos";
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(41, 109);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(52, 20);
            this.x1.TabIndex = 7;
            this.x1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x1_KeyPress_1);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(41, 147);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(52, 20);
            this.x2.TabIndex = 8;
            this.x2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "P1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "P2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Resultado =";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(15, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 143);
            this.panel1.TabIndex = 15;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(112, 109);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(52, 20);
            this.y1.TabIndex = 16;
            this.y1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y1_KeyPress_1);
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(112, 147);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(52, 20);
            this.y2.TabIndex = 17;
            this.y2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(60, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(133, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "y";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.BackColor = System.Drawing.Color.Transparent;
            this.resultado.Location = new System.Drawing.Point(290, 134);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(158, 13);
            this.resultado.TabIndex = 20;
            this.resultado.Text = "No ha ingresado valores válidos";
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(340, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 31);
            this.button2.TabIndex = 21;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.SystemColors.Control;
            this.calcular.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.Location = new System.Drawing.Point(340, 166);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(85, 31);
            this.calcular.TabIndex = 22;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // Distancia_entre_dos_puntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication5.Properties.Resources.Fondo_con_degradado_azul;
            this.ClientSize = new System.Drawing.Size(475, 346);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Distancia_entre_dos_puntos";
            this.Text = "Distancia_entre_dos_puntos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button calcular;
    }
}