namespace ejercicio3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radio = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.areatotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicio #3: Calcular el Área de un circulo.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(219, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el radio (r) del circulo:";
            // 
            // radio
            // 
            this.radio.Location = new System.Drawing.Point(438, 60);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(128, 20);
            this.radio.TabIndex = 2;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(464, 91);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(74, 24);
            this.calcular.TabIndex = 3;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(285, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "El área del circulo es:";
            // 
            // areatotal
            // 
            this.areatotal.AutoSize = true;
            this.areatotal.Location = new System.Drawing.Point(438, 143);
            this.areatotal.Name = "areatotal";
            this.areatotal.Size = new System.Drawing.Size(13, 13);
            this.areatotal.TabIndex = 5;
            this.areatotal.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 209);
            this.Controls.Add(this.areatotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.radio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox radio;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label areatotal;
    }
}

