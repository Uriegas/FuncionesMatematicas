namespace WindowsFormsApplication5
{
    partial class Cofuncion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.funcion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.medida = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.Advertencia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese medidas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "COFUNCIONES";
            // 
            // funcion
            // 
            this.funcion.FormattingEnabled = true;
            this.funcion.Items.AddRange(new object[] {
            "Seno",
            "Coseno",
            "Tangente",
            "Cotangente",
            "Cosecante",
            "Secante"});
            this.funcion.Location = new System.Drawing.Point(39, 98);
            this.funcion.Name = "funcion";
            this.funcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.funcion.Size = new System.Drawing.Size(106, 21);
            this.funcion.TabIndex = 6;
            this.funcion.SelectedIndexChanged += new System.EventHandler(this.funcion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cofunción =";
            // 
            // medida
            // 
            this.medida.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medida.Location = new System.Drawing.Point(151, 94);
            this.medida.Name = "medida";
            this.medida.Size = new System.Drawing.Size(100, 28);
            this.medida.TabIndex = 5;
            this.medida.TextChanged += new System.EventHandler(this.medida_TextChanged);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(161, 142);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 13);
            this.resultado.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(178, 156);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 11;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // Advertencia
            // 
            this.Advertencia.AutoSize = true;
            this.Advertencia.Location = new System.Drawing.Point(148, 142);
            this.Advertencia.Name = "Advertencia";
            this.Advertencia.Size = new System.Drawing.Size(0, 13);
            this.Advertencia.TabIndex = 12;
            // 
            // Cofuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::WindowsFormsApplication5.Properties.Resources.Fondo_con_degradado_azul;
            this.ClientSize = new System.Drawing.Size(308, 235);
            this.Controls.Add(this.Advertencia);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.funcion);
            this.Controls.Add(this.medida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Cofuncion";
            this.Text = "Cofuncion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox funcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox medida;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label Advertencia;
    }
}