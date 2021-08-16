
namespace NumerosAleatorios
{
    partial class Menu
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
            this.btnMixtoMultiplicativo = new System.Windows.Forms.Button();
            this.btnPruebaChiLenguaje = new System.Windows.Forms.Button();
            this.btnPruebaCongruencialMixto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMixtoMultiplicativo
            // 
            this.btnMixtoMultiplicativo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMixtoMultiplicativo.Location = new System.Drawing.Point(31, 16);
            this.btnMixtoMultiplicativo.Name = "btnMixtoMultiplicativo";
            this.btnMixtoMultiplicativo.Size = new System.Drawing.Size(207, 72);
            this.btnMixtoMultiplicativo.TabIndex = 0;
            this.btnMixtoMultiplicativo.Text = "Generar números aleatorios";
            this.btnMixtoMultiplicativo.UseVisualStyleBackColor = true;
            this.btnMixtoMultiplicativo.Click += new System.EventHandler(this.btnMixtoMultiplicativo_Click);
            // 
            // btnPruebaChiLenguaje
            // 
            this.btnPruebaChiLenguaje.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPruebaChiLenguaje.Location = new System.Drawing.Point(31, 94);
            this.btnPruebaChiLenguaje.Name = "btnPruebaChiLenguaje";
            this.btnPruebaChiLenguaje.Size = new System.Drawing.Size(207, 67);
            this.btnPruebaChiLenguaje.TabIndex = 1;
            this.btnPruebaChiLenguaje.Text = "Prueba Chi-Cuadrado";
            this.btnPruebaChiLenguaje.UseVisualStyleBackColor = true;
            this.btnPruebaChiLenguaje.Click += new System.EventHandler(this.btnPruebaChiLenguaje_Click);
            // 
            // btnPruebaCongruencialMixto
            // 
            this.btnPruebaCongruencialMixto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPruebaCongruencialMixto.Location = new System.Drawing.Point(31, 167);
            this.btnPruebaCongruencialMixto.Name = "btnPruebaCongruencialMixto";
            this.btnPruebaCongruencialMixto.Size = new System.Drawing.Size(207, 93);
            this.btnPruebaCongruencialMixto.TabIndex = 2;
            this.btnPruebaCongruencialMixto.Text = "Prueba Chi-Cuadrado (congruencial mixto)";
            this.btnPruebaCongruencialMixto.UseVisualStyleBackColor = true;
            this.btnPruebaCongruencialMixto.Click += new System.EventHandler(this.btnPruebaCongruencialMixto_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 272);
            this.Controls.Add(this.btnPruebaCongruencialMixto);
            this.Controls.Add(this.btnPruebaChiLenguaje);
            this.Controls.Add(this.btnMixtoMultiplicativo);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMixtoMultiplicativo;
        private System.Windows.Forms.Button btnPruebaChiLenguaje;
        private System.Windows.Forms.Button btnPruebaCongruencialMixto;
    }
}