namespace Ev_Final_4toBi
{
    partial class Form2
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
            this.textvar1 = new System.Windows.Forms.TextBox();
            this.textvar2 = new System.Windows.Forms.TextBox();
            this.Btnproducto = new System.Windows.Forms.Button();
            this.Btnsuma = new System.Windows.Forms.Button();
            this.Btnpotencia = new System.Windows.Forms.Button();
            this.Btndivicion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textvar1
            // 
            this.textvar1.Location = new System.Drawing.Point(130, 40);
            this.textvar1.Name = "textvar1";
            this.textvar1.Size = new System.Drawing.Size(100, 22);
            this.textvar1.TabIndex = 0;
            this.textvar1.Text = "Vacio";
            // 
            // textvar2
            // 
            this.textvar2.Location = new System.Drawing.Point(129, 89);
            this.textvar2.Name = "textvar2";
            this.textvar2.Size = new System.Drawing.Size(100, 22);
            this.textvar2.TabIndex = 1;
            this.textvar2.Text = "vacio";
            // 
            // Btnproducto
            // 
            this.Btnproducto.Location = new System.Drawing.Point(154, 118);
            this.Btnproducto.Name = "Btnproducto";
            this.Btnproducto.Size = new System.Drawing.Size(75, 23);
            this.Btnproducto.TabIndex = 2;
            this.Btnproducto.Text = "producto";
            this.Btnproducto.UseVisualStyleBackColor = true;
            this.Btnproducto.Click += new System.EventHandler(this.Btnproducto_Click);
            // 
            // Btnsuma
            // 
            this.Btnsuma.Location = new System.Drawing.Point(153, 157);
            this.Btnsuma.Name = "Btnsuma";
            this.Btnsuma.Size = new System.Drawing.Size(75, 23);
            this.Btnsuma.TabIndex = 3;
            this.Btnsuma.Text = "suma";
            this.Btnsuma.UseVisualStyleBackColor = true;
            this.Btnsuma.Click += new System.EventHandler(this.Btnsuma_Click);
            // 
            // Btnpotencia
            // 
            this.Btnpotencia.Location = new System.Drawing.Point(152, 197);
            this.Btnpotencia.Name = "Btnpotencia";
            this.Btnpotencia.Size = new System.Drawing.Size(75, 23);
            this.Btnpotencia.TabIndex = 4;
            this.Btnpotencia.Text = "potencia";
            this.Btnpotencia.UseVisualStyleBackColor = true;
            this.Btnpotencia.Click += new System.EventHandler(this.Btnpotencia_Click);
            // 
            // Btndivicion
            // 
            this.Btndivicion.Location = new System.Drawing.Point(154, 227);
            this.Btndivicion.Name = "Btndivicion";
            this.Btndivicion.Size = new System.Drawing.Size(75, 23);
            this.Btndivicion.TabIndex = 5;
            this.Btndivicion.Text = "division";
            this.Btndivicion.UseVisualStyleBackColor = true;
            this.Btndivicion.Click += new System.EventHandler(this.Btndivicion_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btndivicion);
            this.Controls.Add(this.Btnpotencia);
            this.Controls.Add(this.Btnsuma);
            this.Controls.Add(this.Btnproducto);
            this.Controls.Add(this.textvar2);
            this.Controls.Add(this.textvar1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textvar1;
        private System.Windows.Forms.TextBox textvar2;
        private System.Windows.Forms.Button Btnproducto;
        private System.Windows.Forms.Button Btnsuma;
        private System.Windows.Forms.Button Btnpotencia;
        private System.Windows.Forms.Button Btndivicion;
    }
}