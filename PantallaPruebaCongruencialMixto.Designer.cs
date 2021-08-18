
namespace NumerosAleatorios
{
    partial class PantallaPruebaCongruencialMixto
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProbabilidad = new System.Windows.Forms.TextBox();
            this.txtGradosLibertad = new System.Windows.Forms.TextBox();
            this.lblProbabilidad = new System.Windows.Forms.Label();
            this.lblGradosLibertad = new System.Windows.Forms.Label();
            this.lblHipotesis = new System.Windows.Forms.Label();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cantIntervalos = new System.Windows.Forms.TextBox();
            this.cant = new System.Windows.Forms.TextBox();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.grdAleatorios = new System.Windows.Forms.DataGridView();
            this.grdPrueba = new System.Windows.Forms.DataGridView();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAleatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrueba)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProbabilidad);
            this.groupBox2.Controls.Add(this.txtGradosLibertad);
            this.groupBox2.Controls.Add(this.lblProbabilidad);
            this.groupBox2.Controls.Add(this.lblGradosLibertad);
            this.groupBox2.Controls.Add(this.lblHipotesis);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(631, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 116);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // txtProbabilidad
            // 
            this.txtProbabilidad.Enabled = false;
            this.txtProbabilidad.Location = new System.Drawing.Point(159, 61);
            this.txtProbabilidad.Name = "txtProbabilidad";
            this.txtProbabilidad.Size = new System.Drawing.Size(101, 29);
            this.txtProbabilidad.TabIndex = 11;
            // 
            // txtGradosLibertad
            // 
            this.txtGradosLibertad.Enabled = false;
            this.txtGradosLibertad.Location = new System.Drawing.Point(159, 28);
            this.txtGradosLibertad.Name = "txtGradosLibertad";
            this.txtGradosLibertad.Size = new System.Drawing.Size(101, 29);
            this.txtGradosLibertad.TabIndex = 10;
            // 
            // lblProbabilidad
            // 
            this.lblProbabilidad.AutoSize = true;
            this.lblProbabilidad.Location = new System.Drawing.Point(52, 64);
            this.lblProbabilidad.Name = "lblProbabilidad";
            this.lblProbabilidad.Size = new System.Drawing.Size(101, 21);
            this.lblProbabilidad.TabIndex = 9;
            this.lblProbabilidad.Text = "Probabilidad:";
            // 
            // lblGradosLibertad
            // 
            this.lblGradosLibertad.AutoSize = true;
            this.lblGradosLibertad.Location = new System.Drawing.Point(6, 32);
            this.lblGradosLibertad.Name = "lblGradosLibertad";
            this.lblGradosLibertad.Size = new System.Drawing.Size(147, 21);
            this.lblGradosLibertad.TabIndex = 8;
            this.lblGradosLibertad.Text = "Grados De Libertad:";
            // 
            // lblHipotesis
            // 
            this.lblHipotesis.AutoSize = true;
            this.lblHipotesis.Location = new System.Drawing.Point(0, 170);
            this.lblHipotesis.Name = "lblHipotesis";
            this.lblHipotesis.Size = new System.Drawing.Size(0, 21);
            this.lblHipotesis.TabIndex = 7;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGraficar.Location = new System.Drawing.Point(480, 84);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(127, 44);
            this.btnGraficar.TabIndex = 10;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // btnPrueba
            // 
            this.btnPrueba.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrueba.Location = new System.Drawing.Point(480, 25);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(127, 45);
            this.btnPrueba.TabIndex = 9;
            this.btnPrueba.Text = "Realizar Prueba";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.Location = new System.Drawing.Point(12, 331);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(218, 31);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtM);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cantIntervalos);
            this.groupBox1.Controls.Add(this.cant);
            this.groupBox1.Controls.Add(this.txtSemilla);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 313);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(99, 210);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(101, 29);
            this.txtM.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "M:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "A:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(99, 175);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(101, 29);
            this.txtA.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Intervalos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "C:";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(99, 140);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(101, 29);
            this.txtC.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Semilla:";
            // 
            // cantIntervalos
            // 
            this.cantIntervalos.Location = new System.Drawing.Point(99, 69);
            this.cantIntervalos.Name = "cantIntervalos";
            this.cantIntervalos.Size = new System.Drawing.Size(101, 29);
            this.cantIntervalos.TabIndex = 1;
            // 
            // cant
            // 
            this.cant.Location = new System.Drawing.Point(99, 34);
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(101, 29);
            this.cant.TabIndex = 0;
            // 
            // txtSemilla
            // 
            this.txtSemilla.Location = new System.Drawing.Point(99, 104);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(101, 29);
            this.txtSemilla.TabIndex = 14;
            // 
            // grdAleatorios
            // 
            this.grdAleatorios.AllowUserToAddRows = false;
            this.grdAleatorios.AllowUserToDeleteRows = false;
            this.grdAleatorios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdAleatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAleatorios.Location = new System.Drawing.Point(236, 25);
            this.grdAleatorios.Name = "grdAleatorios";
            this.grdAleatorios.ReadOnly = true;
            this.grdAleatorios.RowTemplate.Height = 25;
            this.grdAleatorios.Size = new System.Drawing.Size(238, 337);
            this.grdAleatorios.TabIndex = 12;
            // 
            // grdPrueba
            // 
            this.grdPrueba.AllowUserToAddRows = false;
            this.grdPrueba.AllowUserToDeleteRows = false;
            this.grdPrueba.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrueba.Location = new System.Drawing.Point(480, 134);
            this.grdPrueba.Name = "grdPrueba";
            this.grdPrueba.ReadOnly = true;
            this.grdPrueba.RowTemplate.Height = 25;
            this.grdPrueba.Size = new System.Drawing.Size(527, 228);
            this.grdPrueba.TabIndex = 13;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(12, 389);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(134, 37);
            this.lblResultado.TabIndex = 14;
            this.lblResultado.Text = "Resultado";
            // 
            // PantallaPruebaCongruencialMixto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 432);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.grdPrueba);
            this.Controls.Add(this.grdAleatorios);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.groupBox1);
            this.Name = "PantallaPruebaCongruencialMixto";
            this.Text = "Prueba Chi Cuadrado para Congruencial Mixto";
            this.Load += new System.EventHandler(this.PantallaPruebaCongruencialMixto_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAleatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrueba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProbabilidad;
        private System.Windows.Forms.TextBox txtGradosLibertad;
        private System.Windows.Forms.Label lblProbabilidad;
        private System.Windows.Forms.Label lblGradosLibertad;
        private System.Windows.Forms.Label lblHipotesis;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantIntervalos;
        private System.Windows.Forms.TextBox cant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.DataGridView grdAleatorios;
        private System.Windows.Forms.DataGridView grdPrueba;
        private System.Windows.Forms.Label lblResultado;
    }
}